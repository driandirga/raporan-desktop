using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.Helpers.Transitions;
using Raporan_Desktop.Data;
using Raporan_Desktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hashing = Raporan_Desktop.Helpers.Hashing;

namespace Raporan_Desktop
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            this.Load += FrmRegister_Load;
        }

        private static FrmRegister _instance;

        public static FrmRegister Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmRegister();
                }
                return _instance;
            }
        }

        public static void ShowFrmRegister()
        {
            Instance.Show();
        }

        public static void HideFrmRegister()
        {
            Instance.Hide();
        }

        private readonly User newUser = new User();

        private readonly ApplicationDbContext context = ApplicationDbContext.Instance;

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.UfClear();

            this.Load -= FrmRegister_Load;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    snackbarPro.Show(this,
                        "Username is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                if (txtEmail.Text == "")
                {
                    snackbarPro.Show(this,
                        "Email is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                if (txtPassword.Text == "")
                {
                    snackbarPro.Show(this,
                        "Password is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                if (this.lblErrUsername.Visible == true)
                {
                    snackbarPro.Show(this,
                        "Username not Valid",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                if (this.lblErrEmail.Visible == true)
                {
                    snackbarPro.Show(this,
                        "Email not Valid",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                if (this.lblErrPassword.Visible == true)
                {
                    snackbarPro.Show(this,
                        "Password not Valid",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                this.UfRegister();
            }
            catch (Exception ex)
            {
                snackbarPro.Show(this,
                    ex.Message,
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text == "")
                {
                    snackbarPro.Show(this,
                        "Email is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }
                e.Handled = e.SuppressKeyPress = true;
                this.txtPassword.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text == "")
                {
                    snackbarPro.Show(this,
                        "Password is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }
                e.Handled = e.SuppressKeyPress = true;

                if (this.lblErrUsername.Visible == true)
                {
                    snackbarPro.Show(this,
                        "Username not Valid",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                if (this.lblErrEmail.Visible == true)
                {
                    snackbarPro.Show(this,
                        "Email not Valid",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                if (this.lblErrPassword.Visible == true)
                {
                    snackbarPro.Show(this,
                        "Password not Valid",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }

                this.UfRegister();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == "")
                {
                    snackbarPro.Show(this,
                        "Username is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    return;
                }
                e.Handled = e.SuppressKeyPress = true;
                this.txtEmail.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void UfClear()
        {
            try
            {
                this.lblErrUsername.Visible = false;
                this.lblErrEmail.Visible = false;
                this.lblErrPassword.Visible = false;
                this.txtEmail.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
                this.txtUsername.Text = string.Empty;
            }
            catch (Exception ex)
            {
                snackbarPro.Show(this,
                    ex.Message,
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
            }
        }

        private async void UfRegister()
        {
            try
            {
                newUser.FirstName = string.Empty;
                newUser.LastName = string.Empty;
                newUser.Email = this.txtEmail.Text.Trim();
                newUser.Username = this.txtUsername.Text.Trim();
                (newUser.PasswordHash, newUser.Salt) = Hashing.
                    HashPasswordSalt(this.txtPassword.Text.Trim());
                newUser.Level = 3;
                newUser.IsStatus = true;

                context.Users.Add(newUser);
                await context.SaveChangesAsync();
                
                this.UfClear();
                this.Hide();
                FrmMain.ShowFrmMain();
            }
            catch (Exception ex)
            {
                snackbarPro.Show(this,
                    ex.Message,
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.UfClear();
            this.Hide();
            FrmLogin.ShowFrmLogin();
        }

        private bool IsUsernameExists(string cUsername)
        {
            return context.Users.Any(u => u.Username == cUsername);
        }

        private bool IsEmailExists(string cEmail)
        {
            return context.Users.Any(u => u.Email == cEmail);
        }

        private void ValidateUsername(string cUsername)
        {
            string usernamePattern = @"[A-Za-z\d@$!%*?&]{8}$";

            if (Regex.IsMatch(cUsername, usernamePattern))
            {
                this.lblErrUsername.Visible = false;
                bool isUsernameExists = IsUsernameExists(cUsername);

                if (isUsernameExists)
                {
                    this.lblErrUsername.Visible = true;
                    this.lblErrUsername.Text = "Username already exists.";
                    return;
                }
            }
            else
            {
                this.lblErrUsername.Visible = true;
                this.lblErrUsername.Text = "Minimum username must be 8 characters";
            }
        }

        private void ValidateEmail(string cEmail)
        {
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (Regex.IsMatch(cEmail, emailPattern))
            {
                this.lblErrEmail.Visible = false;
                bool isEmailExists = IsEmailExists(cEmail);

                if (isEmailExists)
                {
                    this.lblErrEmail.Visible = true;
                    this.lblErrEmail.Text = "Email already exists.";
                    return;
                }
            }
            else
            {
                this.lblErrEmail.Visible = true;
                this.lblErrEmail.Text = "Email not Valid";
            }
        }

        private void ValidatePassword(string cPassword)
        {
            string passwordPattern = @"(?=.*\d)[A-Za-z\d@$!%*?&]{8}$";

            if (Regex.IsMatch(cPassword, passwordPattern))
            {
                this.lblErrPassword.Visible = false;
            }
            else
            {
                this.lblErrPassword.Visible = true;
                this.lblErrPassword.Text = "Minimum password must be 8 characters and 1 number";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string cEmail = this.txtEmail.Text;

            if (cEmail != string.Empty)
            {
                this.ValidateEmail(cEmail);
            }
            else
            {
                this.lblErrEmail.Visible = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string cUsername = this.txtUsername.Text;

            if (cUsername != string.Empty)
            {
                this.ValidateUsername(cUsername);
            }
            else
            {
                this.lblErrUsername.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string cPassword = this.txtPassword.Text;

            if (cPassword != string.Empty)
            {
                this.ValidatePassword(cPassword);
            }
            else
            {
                this.lblErrPassword.Visible = false;
            }
        }
    }
}
