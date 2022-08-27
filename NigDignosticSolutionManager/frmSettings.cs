using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace NigDignosticSolutionManager
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbComPort.Items.AddRange(ports);
            cmbComPort.SelectedIndex = cmbComPort.FindStringExact(Properties.Settings1.Default.ComPort);
            cmbBaudRate.ValueMember = "hai";
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                cmbComPort.Items.AddRange(ports);
                //Properties.Settings1.Default.ComPort = cmbComPort.SelectedItem.ToString();
                //Properties.Settings1.Default.BaudRate = Convert.ToInt16(cmbBaudRate.SelectedItem);
                //Properties.Settings1.Default.DataBits = Convert.ToInt32(cmbDataBits.SelectedItem);
                //Properties.Settings1.Default.StopBits = cmbStopBits.SelectedItem.ToString();
                //Properties.Settings1.Default.ParityBits = cmbParityBits.SelectedItem.ToString();
                //Properties.Settings1.Default.Save();
                MessageBox.Show("Saved Successfully \nAfter Save application need be restart !", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
