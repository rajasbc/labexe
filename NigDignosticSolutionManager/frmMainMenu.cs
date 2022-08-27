using NigDignosticSolutionManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace NigDignosticSolutionManager
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            //DataGridViewDesignHelper.DesignDataGridView(dataGridView1);
            //UpcommingResult();
        }
        //SampleBarcode _sampleBarcode = new SampleBarcode();
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["nigsoftcon"].ToString());
        //public DataGridViewCellEventHandler txtBillId_TextChanged_1;

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            frmReport frmReport = new frmReport
            {
                TopLevel = false,
                MdiParent = this
            };
            pnlBody.Controls.Add(frmReport);
            frmReport.Show();
            tlsLblLoggedUser.Text = string.Format("Logged in : {0}", UserData.Name);
        }

        //private void TlsRptlgBtn_Click(object sender, EventArgs e)
        //{
        //    pnlBody.Controls.Clear();
        //    FrmReportLog frmReportLog = new FrmReportLog();
        //    frmReportLog.TopLevel = false;
        //    pnlBody.Controls.Add(frmReportLog);
        //    frmReportLog.Show();
        //}

        private void TlsSettingsBtn_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            frmSettings frmSettings = new frmSettings();
            frmSettings.TopLevel = false;
            frmSettings.MdiParent = this;
            pnlBody.Controls.Add(frmSettings);
            frmSettings.Show();
        }

        private void TlsReportsBtn_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            frmReport frmReport = new frmReport
            {
                TopLevel = false,
                MdiParent = this
            };
            pnlBody.Controls.Add(frmReport);
            frmReport.Show();

        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            frmSettings frmSettings = new frmSettings
            {
                TopLevel = false,
                MdiParent = this
            };
            pnlBody.Controls.Add(frmSettings);
            frmSettings.Show();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Login")
                {
                    f.Close();
                }
                else
                {
                    Login login = new Login();
                    login.Show();
                }
            }
        }

       
        private void OnChange(object sender, SqlNotificationEventArgs e)
        {

        }
       

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
                       
        }
               
        
    }
}
