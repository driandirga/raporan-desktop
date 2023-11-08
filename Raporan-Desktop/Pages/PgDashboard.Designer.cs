namespace Raporan_Desktop.Pages
{
    partial class PgDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardTeacher = new Bunifu.Framework.UI.BunifuCards();
            this.cardStudent = new Bunifu.Framework.UI.BunifuCards();
            this.cardAttendance = new Bunifu.Framework.UI.BunifuCards();
            this.cardIncome = new Bunifu.Framework.UI.BunifuCards();
            this.btnLinkChrome = new System.Windows.Forms.Button();
            this.btnLinkMozila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardTeacher
            // 
            this.cardTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.cardTeacher.BorderRadius = 5;
            this.cardTeacher.BottomSahddow = true;
            this.cardTeacher.color = System.Drawing.Color.Tomato;
            this.cardTeacher.LeftSahddow = false;
            this.cardTeacher.Location = new System.Drawing.Point(23, 23);
            this.cardTeacher.Name = "cardTeacher";
            this.cardTeacher.RightSahddow = true;
            this.cardTeacher.ShadowDepth = 20;
            this.cardTeacher.Size = new System.Drawing.Size(198, 119);
            this.cardTeacher.TabIndex = 0;
            // 
            // cardStudent
            // 
            this.cardStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.cardStudent.BorderRadius = 5;
            this.cardStudent.BottomSahddow = true;
            this.cardStudent.color = System.Drawing.Color.CadetBlue;
            this.cardStudent.LeftSahddow = false;
            this.cardStudent.Location = new System.Drawing.Point(251, 23);
            this.cardStudent.Name = "cardStudent";
            this.cardStudent.RightSahddow = true;
            this.cardStudent.ShadowDepth = 20;
            this.cardStudent.Size = new System.Drawing.Size(198, 119);
            this.cardStudent.TabIndex = 1;
            // 
            // cardAttendance
            // 
            this.cardAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.cardAttendance.BorderRadius = 5;
            this.cardAttendance.BottomSahddow = true;
            this.cardAttendance.color = System.Drawing.Color.Purple;
            this.cardAttendance.LeftSahddow = false;
            this.cardAttendance.Location = new System.Drawing.Point(479, 23);
            this.cardAttendance.Name = "cardAttendance";
            this.cardAttendance.RightSahddow = true;
            this.cardAttendance.ShadowDepth = 20;
            this.cardAttendance.Size = new System.Drawing.Size(198, 119);
            this.cardAttendance.TabIndex = 2;
            // 
            // cardIncome
            // 
            this.cardIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.cardIncome.BorderRadius = 5;
            this.cardIncome.BottomSahddow = true;
            this.cardIncome.color = System.Drawing.Color.LimeGreen;
            this.cardIncome.LeftSahddow = false;
            this.cardIncome.Location = new System.Drawing.Point(707, 23);
            this.cardIncome.Name = "cardIncome";
            this.cardIncome.RightSahddow = true;
            this.cardIncome.ShadowDepth = 20;
            this.cardIncome.Size = new System.Drawing.Size(198, 119);
            this.cardIncome.TabIndex = 3;
            // 
            // btnLinkChrome
            // 
            this.btnLinkChrome.Location = new System.Drawing.Point(151, 265);
            this.btnLinkChrome.Name = "btnLinkChrome";
            this.btnLinkChrome.Size = new System.Drawing.Size(75, 23);
            this.btnLinkChrome.TabIndex = 4;
            this.btnLinkChrome.Text = "Chrome";
            this.btnLinkChrome.UseVisualStyleBackColor = true;
            this.btnLinkChrome.Click += new System.EventHandler(this.btnLinkChrome_Click);
            // 
            // btnLinkMozila
            // 
            this.btnLinkMozila.Location = new System.Drawing.Point(251, 265);
            this.btnLinkMozila.Name = "btnLinkMozila";
            this.btnLinkMozila.Size = new System.Drawing.Size(75, 23);
            this.btnLinkMozila.TabIndex = 5;
            this.btnLinkMozila.Text = "Mozilla";
            this.btnLinkMozila.UseVisualStyleBackColor = true;
            this.btnLinkMozila.Click += new System.EventHandler(this.btnLinkMozila_Click);
            // 
            // PgDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.btnLinkMozila);
            this.Controls.Add(this.btnLinkChrome);
            this.Controls.Add(this.cardIncome);
            this.Controls.Add(this.cardAttendance);
            this.Controls.Add(this.cardStudent);
            this.Controls.Add(this.cardTeacher);
            this.Name = "PgDashboard";
            this.Size = new System.Drawing.Size(930, 500);
            this.Load += new System.EventHandler(this.PgDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardTeacher;
        private Bunifu.Framework.UI.BunifuCards cardStudent;
        private Bunifu.Framework.UI.BunifuCards cardAttendance;
        private Bunifu.Framework.UI.BunifuCards cardIncome;
        private System.Windows.Forms.Button btnLinkChrome;
        private System.Windows.Forms.Button btnLinkMozila;
    }
}
