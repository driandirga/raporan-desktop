namespace Raporan_Desktop
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.controlBox = new Bunifu.UI.WinForms.BunifuFormControlBox();
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
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormControlBox controlBox;
    }
}