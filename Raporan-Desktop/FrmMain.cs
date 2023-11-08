using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Raporan_Desktop
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load -= FrmMain_Load;
            this.Shown -= FrmMain_Shown;
            tooglePanels();
        }

        private static FrmMain _instance;

        public static FrmMain Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmMain();
                }
                return _instance;
            }
        }

        public static void ShowFrmMain()
        {
            Instance.Show();
        }

        public static void HideFrmMain()
        {
            Instance.Hide();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            
        }

        private bool showPnlMaster = false;
        private bool showPnlActivity = false;
        private bool showPnlExam = false;
        private bool showPnlFinance = false;
        private bool showPnlSetting = false;

        private void tooglePanels()
        {   
            // Master
            this.pnlMaster.Height = showPnlMaster ? 39 * 4 : 0;

            // Activity
            this.pnlActivity.Height = showPnlActivity ? 39 * 2 : 0;

            // Exam
            this.pnlExam.Height = showPnlExam ? 39 * 1 : 0;

            // Finance
            this.pnlFinance.Height = showPnlFinance ? 39 * 3 : 0;

            // Setting
            this.pnlSetting.Height = showPnlSetting ? 39 * 1 : 0;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            showPnlMaster = !showPnlMaster;
            tooglePanels();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            showPnlActivity = !showPnlActivity;
            tooglePanels();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            showPnlExam = !showPnlExam;
            tooglePanels();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            showPnlFinance = !showPnlFinance;
            tooglePanels();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showPnlSetting = !showPnlSetting;
            tooglePanels();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pagesMain.SelectedTab = tabDashboard;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            pagesMain.SelectedTab = tabClass;
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            pagesMain.SelectedTab = tabStudy;
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pagesMain.SelectedTab = tabTeacher;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pagesMain.SelectedTab = tabStudent;
        }
    }
}
