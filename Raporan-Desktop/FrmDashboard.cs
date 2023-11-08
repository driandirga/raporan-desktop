using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raporan_Desktop
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private static FrmDashboard _instance;

        public static FrmDashboard Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmDashboard();
                }
                return _instance;
            }
        }

        public static void ShowFrmDashboard()
        {
            Instance.Show();
        }

        public static void HideFrmDashboard()
        {
            Instance.Hide();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
