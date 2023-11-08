using Raporan_Desktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hashing = Raporan_Desktop.Helpers.Hashing;

namespace Raporan_Desktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;
        }

        private static FrmLogin _instance;

        public static FrmLogin Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmLogin();
                }
                return _instance;
            }
        }

        public static void ShowFrmLogin()
        {
            Instance.Show();
        }

        public static void HideFrmLogin()
        {
            Instance.Hide();
        }

        public static List<User> superusers = new List<User>
        {
            new User {
                UserId = 1,
                FirstName = "Drian",
                LastName = "Dirga",
                Username = "driandirga",
                Email = "driandirga@gmail.com",
                PasswordHash = "qB//jDj6R6+p6bmXED4w3tgHOQjqSTzjziWFUmZ5bHVpZ9/S", // rahasia123
                Salt = "qB//jDj6R6+p6bmXED4w3sVhQlFPzWFMpZQ4g4BFehQKSRvu",
                Image = null, //File.ReadAllBytes("path/to/your/image.jpg"),
                Level = 0,
                IsStatus = true,
            },
            new User {
                UserId = 1,
                FirstName = "Super",
                LastName = "User",
                Username = "superusers",
                Email = "superuser@gmail.com",
                PasswordHash = "+h9odNy9/fyBjHGnofTNtjWkPqTZGFuzVKxw12G5vZIqp34r", // admin123
                Salt = "KgX3TNUSSFCRtEKYo41WVtZQv8237VDBT9EHI7D0y8gg3gYv",
                Image = null, //File.ReadAllBytes("path/to/your/image.jpg"),
                Level = 0,
                IsStatus = true,
            },
        };

        private readonly ApplicationDbContext context = ApplicationDbContext.Instance;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.UfClear();

            this.Load -= FrmLogin_Load;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    snackbarPro.Show(this,
                        "Username is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    this.txtUsername.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    snackbarPro.Show(this,
                        "Password is empty",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    this.txtPassword.Focus();
                    return;
                }
                this.UfLogin(this.txtUsername.Text, this.txtPassword.Text);
            }
            catch (Exception ex)
            {
                snackbarPro.Show(this,
                    ex.Message,
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
            }
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
                    this.txtUsername.Focus();
                    return;
                }
                e.Handled = e.SuppressKeyPress = true;
                this.txtPassword.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
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
                    this.txtPassword.Focus();
                    return;
                }
                e.Handled = e.SuppressKeyPress = true;
                this.UfLogin(this.txtUsername.Text, this.txtPassword.Text);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void UfClear()
        {
            try
            {
                this.txtUsername.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
                this.txtUsername.Focus();
            }
            catch (Exception ex)
            {
                snackbarPro.Show(this,
                    ex.Message,
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
            }
        }

        private void UfLogin(string Username, string Password)
        {
            try
            {
                string cSalt = string.Empty;
                string cPasswordHash = string.Empty;
                bool cUserDb = false;
                if (!(superusers.Any(u => u.Username == Username)))
                {
                    cUserDb = true;
                    if (!(context.Users.Any(u => u.Username == Username)))
                    {
                        snackbarPro.Show(this,
                        "Username or Password Wrong",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                        this.txtPassword.Text = string.Empty;
                        this.txtPassword.Focus();
                        return;
                    }
                }

                if (cUserDb)
                {
                    cSalt = context.Users.Where(u => u.Username == Username)
                                         .FirstOrDefault()?.Salt;
                    cPasswordHash = context.Users.Where(u => u.Username == Username)
                                                 .FirstOrDefault()?.PasswordHash;
                }
                else
                {
                    cSalt = superusers.Where(u => u.Username == Username)
                                      .FirstOrDefault()?.Salt;
                    cPasswordHash = superusers.Where(u => u.Username == Username)
                                              .FirstOrDefault()?.PasswordHash;
                }

                string cPassword = Hashing.CheckPassword(Password, cSalt);

                if (cPassword != cPasswordHash)
                {
                    snackbarPro.Show(this,
                        "Username or Password Wrong",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000);
                    this.txtPassword.Text = string.Empty;
                    this.txtPassword.Focus();
                    return;
                }
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
            FrmRegister.ShowFrmRegister();
        }
    }
}
