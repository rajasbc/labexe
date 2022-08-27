using Newtonsoft.Json;
using NigDignostic.Helpers;
using NigDignosticSolutionManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NigDignosticSolutionManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Users users = new Users();
        bool _IsLoginSuccess = false;

        private void BtnSubmit_ClickAsync(object sender, EventArgs e)
        {
            if (ValidateLoginCredentials())
            {
                EnableDisableInputs(false);
                bwLoader.RunWorkerAsync();
            }
        }
        public static bool Isconnected = false;

        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 10000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else if (reply.Status == IPStatus.TimedOut)
                {
                    return Isconnected;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        private async Task<bool> ValidateCredentialsUsingAPI()
        {
            try
            {
                var body = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("email", txtUsername.Text),
                    new KeyValuePair<string, string>("password", txtPassword.Text)
                };
                string baseAddress = GetAppSettingsKey.GetAppSettingValue("ApiBaseAddress");
                HttpResponseMessage response = await APIHelper.LoginAsync(baseAddress, APIConstants.Login, new FormUrlEncodedContent(body));
                if (response.IsSuccessStatusCode)
                {
                    Root root = JsonConvert.DeserializeObject<Root>(response.Content.ReadAsStringAsync().Result);
                    if (root != null)
                    {
                        UserData.Name = root.Lab_profile.Name;
                        UserData.access_token = root.Access_token;
                        return true;
                    }
                    else
                    {
                        lblErrorTxt.Text = "Incorrect credentials. Please enter valid credentials.";
                        lblErrorTxt.Visible = true;
                    }
                }
                else
                {
                    lblErrorTxt.Text = "Incorrect credentials. Please enter valid credentials.";
                    lblErrorTxt.Visible = true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private bool ValidateLoginCredentials()
        {
        
            bool IsValidated = true;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                IsValidated = false;
            }
            if (string.IsNullOrEmpty(password))
            {
                IsValidated = false;
            }

            //TO DO : Show login validation message
            if (!IsValidated)
            {
                lblErrorTxt.Text = "Please Enter Username && Password";
                lblErrorTxt.Visible = true;
            }

            return IsValidated;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblErrorTxt.Visible = false;    
        }

        private void LinkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Forget Password feature is under construction", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BwLoader_DoWorkAsync(object sender, DoWorkEventArgs e)
        {
            var IsValidLogin = ValidateCredentialsUsingAPI().Result;
            if (IsValidLogin)
            {
                _IsLoginSuccess = true;
            }
            else
            {
                _IsLoginSuccess = false;
            }
        }

        public void BwLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool Isconnect = CheckForInternetConnection();
            if (_IsLoginSuccess)
            {
                //CommonData.ClearExistingData();
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
                Hide();
            }
            else
            {
                if (Isconnect == false)
                {
                    lblErrorTxt.Text = "Please Check Your Internet Connection!";
                    lblErrorTxt.Visible = true;
                }
                else if (!_IsLoginSuccess)
                {
                    lblErrorTxt.Text = "Incorrect credentials. Please enter valid credentials.";
                    lblErrorTxt.Visible = true; 
                }
               
            }
            EnableDisableInputs(true);
        }

        private void EnableDisableInputs(bool IsDisable)
        {
            txtUsername.Enabled = IsDisable;
            txtPassword.Enabled = IsDisable;
            btnSubmit.Enabled = IsDisable;
            btnCancel.Enabled = IsDisable;
            pcLoader.Visible = !IsDisable;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateLoginCredentials())
                {
                    EnableDisableInputs(false);
                    bwLoader.RunWorkerAsync();
                }
            }
        }
    }
}
