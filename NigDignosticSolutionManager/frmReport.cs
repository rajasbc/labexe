using Newtonsoft.Json;
using NigDignostic.Helpers;
using NigDignosticSolutionManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NigDignosticSolutionManager.Models.MachineReports;
using System.ServiceProcess;
using System.Timers;

namespace NigDignosticSolutionManager
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            DataGridViewDesignHelper.DesignDataGridView(dgvTestResult);
            DataGridViewDesignHelper.DesignDataGridView(dataGridView1);
        }

        SampleBarcodeMachine _barcode = new SampleBarcodeMachine();
        string _fileName = "ReceivedData.txt";
        string _folderName = "NigDignosticSolutionManager";
        string _GuarnteedWritePath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        HttpResponseMessage _reportCreate = new HttpResponseMessage();
        string baseAddress = GetAppSettingsKey.GetAppSettingValue("ApiBaseAddress");
        bool _IsLoginSuccess = false;
        private bool uncheckedAll = false;
        List<PatientTestFieldList> _PatientTestFieldLists = new List<PatientTestFieldList>();
        List<TestFieldResult> _testFieldResults = new List<TestFieldResult>();
        List<TestResults> _testResults = new List<TestResults>();
        SampleInfo _patientProfile = new SampleInfo();
        List<PatientDetail> _patientDetails = new List<PatientDetail>();
        List<Testdetail> _testdetails = new List<Testdetail>();
        List<MachineReport> _machineReport = new List<MachineReport>();
        DataTable dt = new DataTable();
        BindingReport _reportsData = new BindingReport();
        string dataIn;
        Dictionary<string, string> hashTable = new Dictionary<string, string>();
        List<TestDetail> _rootTests = new List<TestDetail>();
        RootTest _rootTest = new RootTest();
        List<StoreTestResults> _storeTestResults = new List<StoreTestResults>();

        string path = @"C:\ProgramData\NigDignosticSolutionManager\ReceivedData.txt";


        //SqlConnection con = new SqlConnection
        //{
        //    ConnectionString = "Data Source=NIG-SOFT;Initial Catalog=Carelabs;Integrated Security=True"
        //};
        //private System.Timers.Timer timer;

        //public System.Timers.Timer timer { get; private set; }

        //string path = @"C:\ProgramData\NigDignosticSolutionManager\ReceivedData.txt";
        private void FrmReport_Load(object sender, EventArgs e)
        {
            MachineReports();
            txtBillId.Focus();
            EnableDisableInputs(true);
            FetchTestFieldReportFromNigsoftApi();
            //if(!serialPort1.IsOpen)
            Connection();
            //GetFileData();
        }

        private void Connection()
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = "COM2"; /*Properties.Settings1.Default.ComPort;*/
                    serialPort1.BaudRate = 9600; //Convert.ToInt32(Properties.Settings1.Default.BaudRate);
                    serialPort1.DataBits = 8; /*Convert.ToInt32(Properties.Settings1.Default.DataBits);*/
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                    serialPort1.Open();
                    progressBar1.Value = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> TestDetailsBySample()
        {
            try
            {
                string SampleBarcodeId = "";  // MUST set the Regex result to a variable for it to take effect
                SampleBarcodeId = Regex.Replace(txtBillId.Text = _barcode.Barcode, @"\s+", "");
                var body = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("bill_id", SampleBarcodeId)
                    };

                HttpResponseMessage response = await APIHelper.PostMethodAsync(baseAddress, APIConstants.TestDetailsBySampleId, new FormUrlEncodedContent(body), UserData.access_token);
                if (response.IsSuccessStatusCode)
                {
                    var sampleDetailsObjects = JsonConvert.DeserializeObject<RootOne>(response.Content.ReadAsStringAsync().Result);
                    if (sampleDetailsObjects != null)
                    {

                        _patientDetails = sampleDetailsObjects.Patient_details.Where(x => x.Patient_id > 0).ToList();
                        _testdetails = sampleDetailsObjects.Testdetails.Where(x => x.Bill_id > 0).ToList();
                        return true;
                    }
                }

                else
                {
                    ClearInputs();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void FetchPatientInformationFromNigSoft()
        {
            try
            {
                //Patient Details
                var billData = _patientDetails.FirstOrDefault(x => x.Patient_id.ToString() != null);
                if (billData != null)
                {
                    txtPatientName.Text = billData.Name;
                    txtAge.Text = billData.Age;
                    txtGender.Text = billData.Gender;
                    txtDOB.Text = billData.Dob;
                }
                else
                {
                    MessageBox.Show(string.Format("Bill ID {0} is not found.", txtBillId.Text), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPatientName.Text = "";
                    txtAge.Text = "";
                    txtGender.Text = "";
                    txtDOB.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async void FetchTestFieldReportFromNigsoftApi()
        {
            try
            {
                HttpResponseMessage response = await APIHelper.GetMethodAsync(baseAddress, APIConstants.TestFieldList, UserData.access_token);
                if (response.IsSuccessStatusCode)
                {
                    var PatientTestFieldList = JsonConvert.DeserializeObject<List<PatientTestFieldList>>(response.Content.ReadAsStringAsync().Result);
                    if (PatientTestFieldList != null)
                    {
                        _PatientTestFieldLists = PatientTestFieldList.Where(x => x.Field_id > 0).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid exception occured on patient profile information binding");
            }
        }

        private async void SubmitButton()
        {
            try
            {
                if (btnSubmit.InvokeRequired)
                {
                    btnSubmit.Invoke(new Action(SubmitButton));
                    return;
                }
                if (ValidateInputs())
                {
                    btnSubmit.Enabled = false;

                    if (_testdetails != null)
                    {
                        foreach (DataGridViewRow row in dgvTestResult.Rows)
                        {
                            if (row.Cells[0].Value != null || ((bool)dgvTestResult.SelectedRows[0].Cells[0].Value != false))
                            {
                                if ((bool)row.Cells[0].Value == true)
                                {
                                    _testResults.Add(new TestResults()
                                    {
                                        Test_id = row.Cells[8].Value.ToString(),
                                        Field_id = row.Cells[9].Value.ToString(),
                                        Test_value = row.Cells[2].Value.ToString(),
                                        Machine_short_name = row.Cells[6].Value.ToString(),
                                        Test_name = row.Cells[1].Value.ToString()
                                    });
                                }
                            }
                        }
                    }

                    if (_testResults.Count > 0)
                    {
                        var ListOfTest = _testdetails.Where(x => x.Test_id > 0).ToList();
                        foreach (var items in ListOfTest)
                        {
                            var testData = _PatientTestFieldLists.Where(x => x.Test_id == items.Test_id).ToList();
                            if (testData != null)
                            {
                               // var MatchedTestId = testData.Where(x => _testResults.Any(y => y.Test_id == x.Test_id.ToString())).ToList();
                                List<TestRecord> testRecords = new List<TestRecord>();
                                foreach (var fieldList in testData)
                                {
                                    foreach (var fields in _testResults)
                                    {
                                        if (fieldList.Test_short_name == fields.Machine_short_name)
                                        {
                                            testRecords.Add(new TestRecord()
                                            {
                                                field_id = fieldList.Field_id.ToString(),
                                                test_value = fields.Test_value,
                                                test_name = fieldList.Field_name
                                            });
                                        }
                                       
                                    }
                                }
                                if (testRecords.Count > 0)
                                {
                                    
                                    RecordCreate recordCreate = new RecordCreate
                                        {
                                            test_id = testData.FirstOrDefault().Test_id.ToString(),
                                            bill_id = _testdetails.FirstOrDefault().Bill_id.ToString(),
                                            patient_id = _patientDetails.FirstOrDefault().Patient_id.ToString(),
                                            group_id = testData.FirstOrDefault().Group_id.ToString(),
                                            department_id = testData.FirstOrDefault().Department_id.ToString(),
                                            test_result = testRecords
                                        };
                                        string content = JsonConvert.SerializeObject(recordCreate);
                                        HttpResponseMessage _reportCreate = await APIHelper.PostMethodAsync(baseAddress, APIConstants.ReportCreate, new StringContent(content, UnicodeEncoding.UTF8, "application/json"), UserData.access_token);
                                        testRecords.Clear();
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("No Test results found.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        if (_reportCreate.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Record created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputs();
                            _testResults.Clear();
                            checkBox1.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Record creation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select atleast one test result to proceed", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btnSubmit.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid exception occured on saving tests Report Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSubmit_ClickAsync(object sender, EventArgs e)
        {
             EnableDisableInputs(false);
            backgroundWorker1.RunWorkerAsync();

            //SavedataToDB();

        }

        //private void SavedataToDB()
        //{


        //    SqlConnection conn1 = new SqlConnection("Data Source=NIG-SOFT;Initial Catalog=Carelabs;Integrated Security=True");
            
        //    SqlCommand concmd = new SqlCommand("Select Barcode from CareTestRecord where Barcode ='" + txtBarcode.Text + "'", conn1);
        //    SqlDataAdapter sdreportlog = new SqlDataAdapter(concmd);
        //    DataTable dtreportlog = new DataTable();
        //    sdreportlog.Fill(dtreportlog);
        //    if (dtreportlog.Rows.Count > 0)
        //    {
        //        MessageBox.Show(string.Format("Record Already Exist....!"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //MessageBox.Show("Record Already Exist....!");
        //    }
        //    else
        //    {
        //        foreach (DataGridViewRow row in dgvTestResult.Rows)
        //        {
        //            conn1.Open();
        //            SqlCommand dgvcmd = new SqlCommand("INSERT INTO CareTestRecord ([Barcode],[PatientName],[ReportDate],[TestfieldName],[TestResult],[LowerRef],[HigherRef],[Unit],[Testname]) Values ('" + txtBillId.Text + "','" + txtPatientName.Text + "'," +
        //                       "'" + txtReportDate.Text + "','" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[4].Value + "','" +
        //                         row.Cells[5].Value + "','" + row.Cells[7].Value + "')", conn1);
        //            dgvcmd.ExecuteNonQuery();
        //            conn1.Close();
        //        }
                
        //        MessageBox.Show("saved");
        //    }
            
        //    //dgvTestResult.Rows.Clear();
        //    ClearInputs();
        //}

        private bool ValidateInputs()
        {
            bool Isvalidated = true;
            string billId = txtBillId.Text.Trim();
            int count = dgvTestResult.Rows.Count;
            if (string.IsNullOrEmpty(billId))
            {
                Isvalidated = false;
                MessageBox.Show("Please Scan Patient Bill ID", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (count == 0)
            {
                Isvalidated = false;
                MessageBox.Show("No Test results found.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Isvalidated;
        }

        public void ClearInputs()
        {
            frmReport frmReport = new frmReport();
            frmReport.Refresh();
            txtBillId.Text = "";
            txtPatientName.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtDOB.Text = "";
            txtBarcode.Text = "";
            txtReportDate.Text = "";
            txtBillAge.Text = "";
            txtBillGender.Text = "";
            txtBillDOB.Text = "";
            dgvTestResult.DataSource = null;
            dgvTestResult.Refresh();
            dgvTestResult.Rows.Clear();
            txtBillId.Focus();
            _testFieldResults.Clear();
        }

        private void EnableDisableInputs(bool IsDisable)
        {
            txtBillId.Enabled = IsDisable;
            PcLoader.Visible = !IsDisable;
        }

        private void BwLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            var IsvalidBillId = TestDetailsBySample().Result;

            if (IsvalidBillId)
            {
                _IsLoginSuccess = true;
            }
            else
            {
                _IsLoginSuccess = false;
            }
        }

        private void BwLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_IsLoginSuccess)
            {
                FetchPatientInformationFromNigSoft();
                FetchTestFieldReportFromNigsoftApi();
                PatientTestResultFromJson();
            }
            else
            {
                MessageBox.Show("Incorrect Bill id. Please scan valid Bill id.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            EnableDisableInputs(true);
        }

        private async void BtnPatientNameRefresh_ClickAsync(object sender, EventArgs e)
        {
            ClearInputs();
            await TestDetailsBySample();
        }

        public void TxtBillId_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBillId.Text.Length >= 8 && txtBillId.Text.Length < 20)
            {
                FetchTestFieldReportFromNigsoftApi();
                EnableDisableInputs(false);
                bwLoader.RunWorkerAsync();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                for (int i = 0; i < dgvTestResult.RowCount; i++)
                {
                    dgvTestResult[0, i].Value = true;
                }
            }
            else
            {
                if (uncheckedAll)
                {
                    for (int i = 0; i < dgvTestResult.RowCount; i++)
                    {
                        dgvTestResult[0, i].Value = false;
                    }
                }
            }
            uncheckedAll = true;
        }

        private void DgvTestResult_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTestResult.SelectedRows[0].Cells[0].Value != null)
            {
                if (e.RowIndex >= 0)
                {
                    if ((bool)dgvTestResult.SelectedRows[0].Cells[0].Value == false)
                    {
                        dgvTestResult.SelectedRows[0].Cells[0].Value = true;
                    }
                    else
                    {
                        dgvTestResult.SelectedRows[0].Cells[0].Value = false;
                    }
                    foreach (DataGridViewRow r in dgvTestResult.Rows)
                    {
                        if ((bool)r.Cells[0].Value == true)
                        {
                            uncheckedAll = false;
                            break;
                        }
                    }
                    checkBox1.Checked = false;
                }

                bool check = true;
                foreach (DataGridViewRow r in dgvTestResult.Rows)
                {
                    if ((bool)r.Cells[0].Value == false)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    checkBox1.Checked = true;
                }
            }
        }

        private void DataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //ContextMenu m = new ContextMenu();
                //m.MenuItems.Add(new MenuItem("Copy"));

                //int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                //m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SubmitButton();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableDisableInputs(true);
        }


        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string json = File.ReadAllText(path);
            List<RootTest> Orders = JsonExtensions.FromDelimitedJson<RootTest>(new StringReader(json)).ToList();

            try
            {
                Thread.Sleep(2000);
                dataIn = serialPort1.ReadExisting();
                var parse = Regex.Replace(dataIn, @"[^\u0020-\u007E]", " ");
                string[] Filter = parse.Split('\r', ' ', '*');
                List<string> sampl = Filter.ToList();
                var ReportData = sampl.Where(x => x != "" && x != "H" && x != "L").ToList();
                var re = ReportData[0].Substring(19);
                //re = re.TrimStart('0');
                re = re.Replace(".", "-");
                ReportData[2] = re;
                _rootTest.Sample_id = ReportData[2];
                _rootTest.Sample_date = ReportData[1].ToString();
                hashTable.Add("WBC", Convert.ToString(Calculatioin(double.Parse(ReportData[3]))));
                hashTable.Add("LYM%", ReportData[5].TrimStart('0'));
                hashTable.Add("MIX%", ReportData[7].TrimStart('0'));
                hashTable.Add("NEU%", ReportData[9].TrimStart('0'));
                hashTable.Add("LYM#", ReportData[4].TrimStart('0'));
                hashTable.Add("MIX#", ReportData[6].TrimStart('0'));
                hashTable.Add("NEU#", ReportData[8].TrimStart('0'));
                hashTable.Add("RBC", ReportData[24].TrimStart('0'));
                hashTable.Add("HGB", ReportData[25].TrimStart('0'));
                hashTable.Add("HCT", ReportData[26].TrimStart('0'));
                hashTable.Add("MCV", ReportData[27].TrimStart('0'));
                hashTable.Add("MCH", ReportData[28].TrimStart('0'));
                hashTable.Add("MCHC", ReportData[29].TrimStart('0'));
                hashTable.Add("RDW", ReportData[30].TrimStart('0'));
                hashTable.Add("PLT", Convert.ToString(Calculatioin(double.Parse(ReportData[32]))));
                hashTable.Add("MPV", ReportData[33].TrimStart('0'));
                hashTable.Add("PDW", ReportData[35].TrimStart('0'));
                foreach (var item in hashTable)
                {
                    _rootTests.Add(new TestDetail()
                    {
                        Test_name = item.Key,
                        Test_result = item.Value
                    });
                }
                _rootTest.Test_details = _rootTests;

                var findDuplicateReport = Orders.All(x => x.Sample_id != _rootTest.Sample_id);
                if (findDuplicateReport)
                {
                    var serialize = JsonConvert.SerializeObject(_rootTest, Newtonsoft.Json.Formatting.Indented);
                    File.AppendAllText(path, serialize);
                }



                hashTable.Clear();
                _rootTest.Test_details.Clear();


               // GetFileData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private double Calculatioin(double v)
        {
            double result = 1000 * v;
            return result;
        }
        //private void GetFileData()
        //{
        //    try
        //    {


        //        string json = File.ReadAllText(path);
        //        List<RootTest> Orders = JsonExtensions.FromDelimitedJson<RootTest>(new StringReader(json)).ToList();
        //        if (Orders.Count() > 0)
        //        {
        //            foreach (var items in Orders)
        //            {
        //                var data = items.Sample_id;
        //                var parsememo = Regex.Replace(data, @"[^\u0020-\u007E]", " ");
        //                string[] FilterSpace = parsememo.Split('\r', ' ');
        //                List<string> sample = FilterSpace.ToList();
        //                var ReportData = sample.Where(x => x != "" && x != "H" && x != "L").ToList();
        //                ReportData[2] = ReportData[2].Replace(".", "-");

        //                if (ReportData[2] == _barcode.Barcode)
        //                {


        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}



        private void MachineReports()
        {
            try
            {
                List<Reportjson> reportjsons = new List<Reportjson>();
                string path = @"C:\ProgramData\NigDignosticSolutionManager\ReceivedData.txt";
                string json = File.ReadAllText(path);
                List<RootTest> Orders = JsonExtensions.FromDelimitedJson<RootTest>(new StringReader(json)).ToList();
                if (Orders.Count > 0)
                {
                    foreach (RootTest getFileData in Orders)
                    {
                        reportjsons.Add(new Reportjson()
                        {
                            barcode = getFileData.Sample_id,
                            TestDate = getFileData.Sample_date
                        });


                        ListToDataTableConverter converter = new ListToDataTableConverter();
                        var curDate = DateTime.Now.ToString("MM/dd/y", CultureInfo.InvariantCulture);
                        
                            dt = converter.ToDataTable(reportjsons);
                            dataGridView1.DataSource = dt;
                        
                       

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PatientTestResultFromJson()
        {
            try
            {
                string json = File.ReadAllText(path);
                List<RootTest> Orders = JsonExtensions.FromDelimitedJson<RootTest>(new StringReader(json)).ToList();
                var getSelectedBillId = Orders.Where(x => x.Sample_id == _barcode.Barcode).FirstOrDefault();

                if (getSelectedBillId != null)
                {
                    txtBarcode.Text = getSelectedBillId.Sample_id;
                    txtReportDate.Text = getSelectedBillId.Sample_date;

                    var ListOfTest = _testdetails.Where(x => x.Test_id > 0).ToList();
                    foreach (var TestList in ListOfTest)
                    {
                        var TestData = _PatientTestFieldLists.Where(x => x.Test_id == TestList.Test_id).ToList();
                        if (TestData.Count > 0)
                        {
                            foreach (var item in getSelectedBillId.Test_details)
                            {
                                foreach (var items in TestData)
                                {
                                    if (item.Test_name == items.Test_short_name)
                                    {
                                        _storeTestResults.Add(new StoreTestResults()
                                        {
                                            Field_id = items.Field_id.ToString(),
                                            Field_name = items.Field_name,
                                            Test_result = item.Test_result,
                                            Min_range = items.Min_range,
                                            Max_range = items.Max_range,
                                            Units = items.Units,
                                            Test_field_name = item.Test_name,
                                            Test_id = items.Test_id.ToString(),
                                            Test_name_nigsoft = TestList.Test_name
                                        });
                                    }
                                }
                            }
                        }
                    }
                    Gridview();
                    _storeTestResults.Clear();


                }
                else
                {
                    MessageBox.Show("Test Results is Empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Gridview()
        {
            var TestResults = _storeTestResults.Where(x => x.Test_id != null).ToList();

            if (TestResults.Count > 0)
            {
                foreach (var Result in TestResults)
                {
                    int m = dgvTestResult.Rows.Add();
                    dgvTestResult.Rows[m].Cells[0].Value = false;
                    dgvTestResult.Rows[m].Cells[1].Value = Result.Field_name;
                    dgvTestResult.Rows[m].Cells[2].Value = Result.Test_result;
                    dgvTestResult.Rows[m].Cells[3].Value = Result.Min_range;
                    dgvTestResult.Rows[m].Cells[4].Value = Result.Max_range;
                    dgvTestResult.Rows[m].Cells[5].Value = Result.Units;
                    dgvTestResult.Rows[m].Cells[6].Value = Result.Test_field_name;
                    dgvTestResult.Rows[m].Cells[7].Value = Result.Test_name_nigsoft;
                    dgvTestResult.Rows[m].Cells[8].Value = Result.Test_id;
                    dgvTestResult.Rows[m].Cells[9].Value = Result.Field_id;
                    dgvTestResult.AllowUserToAddRows = false;
                    dgvTestResult.RowHeadersVisible = false;
                }
            }
        }

        private void DataGridView1_CellClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    dgvTestResult.DataSource = null;
                    dgvTestResult.Rows.Clear();
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    _barcode.PatientName = Convert.ToString(selectedRow.Cells["TestDate"].Value);
                    _barcode.Barcode = selectedRow.Cells["barcode"].Value.ToString();
                    EnableDisableInputs(false);
                    TestDetailsBySample();
                    if (!bwLoader.IsBusy)
                    {
                        bwLoader.RunWorkerAsync();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _machineReport.Clear();
            MachineReports();
            //Deletefile();

        }
        //public void Deletefile()
        //{
        //    try
        //    {
        //        timer = new System.Timers.Timer();
        //        timer.Interval = (10000) * 6;
        //        timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        //        string[] Files = Directory.GetFiles(@"C:\ProgramData\NigDignosticSolutionManager\ReceivedData.txt");
        //        for (int i = 0; i < Files.Length; i++)
        //        {
        //            //Here we will find wheter the file is 7 days old
        //            if (DateTime.Now.Subtract(File.GetCreationTime(Files[i])).TotalDays > 7)
        //            {
        //                File.Delete(Files[i]);
                       
        //            }
        //        }
        //        timer.Enabled = true;
        //        timer.Start();
        //    }
        //    catch
        //    {
        //    }
        //}

        //private void timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void DgvTestResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
