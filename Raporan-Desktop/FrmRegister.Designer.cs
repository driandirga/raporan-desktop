using Bunifu.UI.WinForms;
using Raporan_Desktop.Properties;
using System;

namespace Raporan_Desktop
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.controlBox = new Bunifu.UI.WinForms.BunifuFormControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblErrPassword = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblErrUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblErrEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblAsk = new Bunifu.UI.WinForms.BunifuLabel();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.lblRegister = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnRegister = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.snackbarPro = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.BunifuFormDrag = null;
            this.controlBox.CloseBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.CloseBoxOptions.BorderRadius = 0;
            this.controlBox.CloseBoxOptions.Enabled = true;
            this.controlBox.CloseBoxOptions.EnableDefaultAction = true;
            this.controlBox.CloseBoxOptions.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox.CloseBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("controlBox.CloseBoxOptions.Icon")));
            this.controlBox.CloseBoxOptions.IconAlt = null;
            this.controlBox.CloseBoxOptions.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.controlBox.CloseBoxOptions.IconHoverColor = System.Drawing.Color.White;
            this.controlBox.CloseBoxOptions.IconPressedColor = System.Drawing.Color.White;
            this.controlBox.CloseBoxOptions.IconSize = new System.Drawing.Size(18, 18);
            this.controlBox.CloseBoxOptions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox.HelpBox = false;
            this.controlBox.HelpBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.HelpBoxOptions.BorderRadius = 0;
            this.controlBox.HelpBoxOptions.Enabled = true;
            this.controlBox.HelpBoxOptions.EnableDefaultAction = true;
            this.controlBox.HelpBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.controlBox.HelpBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("controlBox.HelpBoxOptions.Icon")));
            this.controlBox.HelpBoxOptions.IconAlt = null;
            this.controlBox.HelpBoxOptions.IconColor = System.Drawing.Color.Black;
            this.controlBox.HelpBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.controlBox.HelpBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.controlBox.HelpBoxOptions.IconSize = new System.Drawing.Size(22, 22);
            this.controlBox.HelpBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.controlBox.Location = new System.Drawing.Point(720, 0);
            this.controlBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.controlBox.MaximizeBox = false;
            this.controlBox.MaximizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.MaximizeBoxOptions.BorderRadius = 0;
            this.controlBox.MaximizeBoxOptions.Enabled = true;
            this.controlBox.MaximizeBoxOptions.EnableDefaultAction = true;
            this.controlBox.MaximizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.controlBox.MaximizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("controlBox.MaximizeBoxOptions.Icon")));
            this.controlBox.MaximizeBoxOptions.IconAlt = ((System.Drawing.Image)(resources.GetObject("controlBox.MaximizeBoxOptions.IconAlt")));
            this.controlBox.MaximizeBoxOptions.IconColor = System.Drawing.Color.Black;
            this.controlBox.MaximizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.controlBox.MaximizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.controlBox.MaximizeBoxOptions.IconSize = new System.Drawing.Size(16, 16);
            this.controlBox.MaximizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.controlBox.MinimizeBox = true;
            this.controlBox.MinimizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.MinimizeBoxOptions.BorderRadius = 0;
            this.controlBox.MinimizeBoxOptions.Enabled = true;
            this.controlBox.MinimizeBoxOptions.EnableDefaultAction = true;
            this.controlBox.MinimizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.controlBox.MinimizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("controlBox.MinimizeBoxOptions.Icon")));
            this.controlBox.MinimizeBoxOptions.IconAlt = null;
            this.controlBox.MinimizeBoxOptions.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.controlBox.MinimizeBoxOptions.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.controlBox.MinimizeBoxOptions.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.controlBox.MinimizeBoxOptions.IconSize = new System.Drawing.Size(14, 14);
            this.controlBox.MinimizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.controlBox.Name = "controlBox";
            this.controlBox.ShowDesignBorders = false;
            this.controlBox.Size = new System.Drawing.Size(80, 38);
            this.controlBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Raporan_Desktop.Properties.Resources.register;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblErrPassword);
            this.pnlRight.Controls.Add(this.lblErrUsername);
            this.pnlRight.Controls.Add(this.lblErrEmail);
            this.pnlRight.Controls.Add(this.txtEmail);
            this.pnlRight.Controls.Add(this.lblAsk);
            this.pnlRight.Controls.Add(this.linkRegister);
            this.pnlRight.Controls.Add(this.lblRegister);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.btnRegister);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRight.Location = new System.Drawing.Point(400, 38);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(400, 412);
            this.pnlRight.TabIndex = 18;
            // 
            // lblErrPassword
            // 
            this.lblErrPassword.AllowParentOverrides = false;
            this.lblErrPassword.AutoEllipsis = false;
            this.lblErrPassword.CursorType = null;
            this.lblErrPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrPassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrPassword.Location = new System.Drawing.Point(67, 258);
            this.lblErrPassword.Name = "lblErrPassword";
            this.lblErrPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrPassword.Size = new System.Drawing.Size(103, 15);
            this.lblErrPassword.TabIndex = 15;
            this.lblErrPassword.Text = "Password not Valid.";
            this.lblErrPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrPassword.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblErrPassword.Visible = false;
            // 
            // lblErrUsername
            // 
            this.lblErrUsername.AllowParentOverrides = false;
            this.lblErrUsername.AutoEllipsis = false;
            this.lblErrUsername.CursorType = null;
            this.lblErrUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrUsername.Location = new System.Drawing.Point(67, 128);
            this.lblErrUsername.Name = "lblErrUsername";
            this.lblErrUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrUsername.Size = new System.Drawing.Size(106, 15);
            this.lblErrUsername.TabIndex = 14;
            this.lblErrUsername.Text = "Username not Valid.";
            this.lblErrUsername.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblErrUsername.Visible = false;
            // 
            // lblErrEmail
            // 
            this.lblErrEmail.AllowParentOverrides = false;
            this.lblErrEmail.AutoEllipsis = false;
            this.lblErrEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblErrEmail.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblErrEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrEmail.Location = new System.Drawing.Point(67, 193);
            this.lblErrEmail.Name = "lblErrEmail";
            this.lblErrEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrEmail.Size = new System.Drawing.Size(82, 15);
            this.lblErrEmail.TabIndex = 13;
            this.lblErrEmail.Text = "Email not Valid.";
            this.lblErrEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblErrEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.AutoSizeHeight = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(67, 149);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            stateProperties4.ForeColor = System.Drawing.Color.DarkGray;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties4;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(3);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "Enter Your Email";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(260, 38);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 3;
            this.txtEmail.TextMarginTop = 1;
            this.txtEmail.TextPlaceholder = "Enter Your Email";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyDown += txtEmail_KeyDown;
            this.txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // lblAsk
            // 
            this.lblAsk.AllowParentOverrides = false;
            this.lblAsk.AutoEllipsis = false;
            this.lblAsk.CursorType = null;
            this.lblAsk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsk.ForeColor = System.Drawing.Color.Silver;
            this.lblAsk.Location = new System.Drawing.Point(67, 362);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAsk.Size = new System.Drawing.Size(120, 16);
            this.lblAsk.TabIndex = 11;
            this.lblAsk.Text = "Have an account?";
            this.lblAsk.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAsk.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.linkRegister.Location = new System.Drawing.Point(281, 362);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(46, 16);
            this.linkRegister.TabIndex = 5;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Login";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // lblRegister
            // 
            this.lblRegister.AllowParentOverrides = false;
            this.lblRegister.AutoEllipsis = false;
            this.lblRegister.CursorType = null;
            this.lblRegister.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.Silver;
            this.lblRegister.Location = new System.Drawing.Point(142, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRegister.Size = new System.Drawing.Size(113, 29);
            this.lblRegister.TabIndex = 8;
            this.lblRegister.Text = "Register";
            this.lblRegister.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRegister.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(67, 214);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            stateProperties8.ForeColor = System.Drawing.Color.DarkGray;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties8;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Enter Your Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(260, 38);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 1;
            this.txtPassword.TextPlaceholder = "Enter Your Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += txtPassword_KeyDown;
            this.txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AnimationSpeed = 200;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.AutoSizeHeight = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = null;
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.IconPadding = 10;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(67, 84);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Modified = false;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            stateProperties12.ForeColor = System.Drawing.Color.DarkGray;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnIdleState = stateProperties12;
            this.txtUsername.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsername.PlaceholderText = "Enter Your Username";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(260, 38);
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginBottom = 0;
            this.txtUsername.TextMarginLeft = 3;
            this.txtUsername.TextMarginTop = 1;
            this.txtUsername.TextPlaceholder = "Enter Your Username";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WordWrap = true;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyDown += txtUsername_KeyDown;
            this.txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // btnRegister
            // 
            this.btnRegister.AllowAnimations = true;
            this.btnRegister.AllowMouseEffects = true;
            this.btnRegister.AllowToggling = false;
            this.btnRegister.AnimationSpeed = 200;
            this.btnRegister.AutoGenerateColors = false;
            this.btnRegister.AutoRoundBorders = false;
            this.btnRegister.AutoSizeLeftIcon = true;
            this.btnRegister.AutoSizeRightIcon = true;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.ButtonText = "REGISTER";
            this.btnRegister.ButtonTextMarginLeft = 0;
            this.btnRegister.ColorContrastOnClick = 45;
            this.btnRegister.ColorContrastOnHover = 45;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRegister.CustomizableEdges = borderEdges1;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegister.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnRegister.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnRegister.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.btnRegister.IconLeft = null;
            this.btnRegister.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegister.IconMarginLeft = 11;
            this.btnRegister.IconPadding = 10;
            this.btnRegister.IconRight = null;
            this.btnRegister.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegister.IconSize = 25;
            this.btnRegister.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnRegister.IdleBorderRadius = 0;
            this.btnRegister.IdleBorderThickness = 0;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Empty;
            this.btnRegister.IdleIconLeftImage = null;
            this.btnRegister.IdleIconRightImage = null;
            this.btnRegister.IndicateFocus = false;
            this.btnRegister.Location = new System.Drawing.Point(67, 291);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegister.OnDisabledState.BorderRadius = 15;
            this.btnRegister.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnDisabledState.BorderThickness = 1;
            this.btnRegister.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegister.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegister.OnDisabledState.IconLeftImage = null;
            this.btnRegister.OnDisabledState.IconRightImage = null;
            this.btnRegister.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.btnRegister.onHoverState.BorderRadius = 15;
            this.btnRegister.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.onHoverState.BorderThickness = 1;
            this.btnRegister.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.btnRegister.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.onHoverState.IconLeftImage = null;
            this.btnRegister.onHoverState.IconRightImage = null;
            this.btnRegister.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.btnRegister.OnIdleState.BorderRadius = 15;
            this.btnRegister.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnIdleState.BorderThickness = 1;
            this.btnRegister.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.btnRegister.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.btnRegister.OnIdleState.IconLeftImage = null;
            this.btnRegister.OnIdleState.IconRightImage = null;
            this.btnRegister.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.btnRegister.OnPressedState.BorderRadius = 15;
            this.btnRegister.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnPressedState.BorderThickness = 1;
            this.btnRegister.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(13)))));
            this.btnRegister.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.OnPressedState.IconLeftImage = null;
            this.btnRegister.OnPressedState.IconRightImage = null;
            this.btnRegister.Size = new System.Drawing.Size(260, 39);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.TextMarginLeft = 0;
            this.btnRegister.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegister.UseDefaultRadiusAndThickness = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dock
            // 
            this.dock.AllowFormDragging = true;
            this.dock.AllowFormDropShadow = true;
            this.dock.AllowFormResizing = false;
            this.dock.AllowHidingBottomRegion = true;
            this.dock.AllowOpacityChangesWhileDragging = false;
            this.dock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.dock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.dock.BorderOptions.BottomBorder.ShowBorder = true;
            this.dock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.dock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.dock.BorderOptions.LeftBorder.ShowBorder = true;
            this.dock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.dock.BorderOptions.RightBorder.BorderThickness = 1;
            this.dock.BorderOptions.RightBorder.ShowBorder = true;
            this.dock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.dock.BorderOptions.TopBorder.BorderThickness = 1;
            this.dock.BorderOptions.TopBorder.ShowBorder = true;
            this.dock.ContainerControl = this;
            this.dock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.dock.DockingIndicatorsOpacity = 0.5D;
            this.dock.DockingOptions.DockAll = false;
            this.dock.DockingOptions.DockBottomLeft = false;
            this.dock.DockingOptions.DockBottomRight = false;
            this.dock.DockingOptions.DockFullScreen = false;
            this.dock.DockingOptions.DockLeft = false;
            this.dock.DockingOptions.DockRight = false;
            this.dock.DockingOptions.DockTopLeft = false;
            this.dock.DockingOptions.DockTopRight = false;
            this.dock.FormDraggingOpacity = 0.9D;
            this.dock.ParentForm = this;
            this.dock.ShowCursorChanges = true;
            this.dock.ShowDockingIndicators = true;
            this.dock.TitleBarOptions.AllowFormDragging = true;
            this.dock.TitleBarOptions.BunifuFormDock = this.dock;
            this.dock.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.dock.TitleBarOptions.TitleBarControl = null;
            this.dock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // snackbarPro
            // 
            this.snackbarPro.AllowDragging = false;
            this.snackbarPro.AllowMultipleViews = true;
            this.snackbarPro.ClickToClose = true;
            this.snackbarPro.DoubleClickToClose = true;
            this.snackbarPro.DurationAfterIdle = 3000;
            this.snackbarPro.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.ErrorOptions.ActionBorderRadius = 1;
            this.snackbarPro.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbarPro.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbarPro.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.snackbarPro.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.snackbarPro.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.snackbarPro.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbarPro.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbarPro.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.snackbarPro.ErrorOptions.IconLeftMargin = 12;
            this.snackbarPro.FadeCloseIcon = false;
            this.snackbarPro.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.snackbarPro.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.InformationOptions.ActionBorderRadius = 1;
            this.snackbarPro.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbarPro.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbarPro.InformationOptions.BackColor = System.Drawing.Color.White;
            this.snackbarPro.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.snackbarPro.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.snackbarPro.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbarPro.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbarPro.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.snackbarPro.InformationOptions.IconLeftMargin = 12;
            this.snackbarPro.Margin = 10;
            this.snackbarPro.MaximumSize = new System.Drawing.Size(0, 0);
            this.snackbarPro.MaximumViews = 7;
            this.snackbarPro.MessageRightMargin = 15;
            this.snackbarPro.MessageTopMargin = 0;
            this.snackbarPro.MinimumSize = new System.Drawing.Size(0, 0);
            this.snackbarPro.ShowBorders = false;
            this.snackbarPro.ShowCloseIcon = false;
            this.snackbarPro.ShowIcon = true;
            this.snackbarPro.ShowShadows = true;
            this.snackbarPro.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.SuccessOptions.ActionBorderRadius = 1;
            this.snackbarPro.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbarPro.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbarPro.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.snackbarPro.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.snackbarPro.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.snackbarPro.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbarPro.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbarPro.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.snackbarPro.SuccessOptions.IconLeftMargin = 12;
            this.snackbarPro.ViewsMargin = 7;
            this.snackbarPro.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackbarPro.WarningOptions.ActionBorderRadius = 1;
            this.snackbarPro.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackbarPro.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackbarPro.WarningOptions.BackColor = System.Drawing.Color.White;
            this.snackbarPro.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.snackbarPro.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.snackbarPro.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackbarPro.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.snackbarPro.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.snackbarPro.WarningOptions.IconLeftMargin = 12;
            this.snackbarPro.ZoomCloseIcon = true;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.controlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }
        
        #endregion

        private Bunifu.UI.WinForms.BunifuFormControlBox controlBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRight;
        private Bunifu.UI.WinForms.BunifuLabel lblAsk;
        private System.Windows.Forms.LinkLabel linkRegister;
        private Bunifu.UI.WinForms.BunifuLabel lblRegister;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegister;
        private Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuFormDock dock;
        private Bunifu.UI.WinForms.BunifuSnackbar snackbarPro;
        private Bunifu.UI.WinForms.BunifuLabel lblErrEmail;
        private Bunifu.UI.WinForms.BunifuLabel lblErrPassword;
        private Bunifu.UI.WinForms.BunifuLabel lblErrUsername;
    }
}