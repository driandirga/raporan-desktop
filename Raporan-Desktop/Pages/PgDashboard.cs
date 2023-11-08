using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raporan_Desktop.Pages
{
    public partial class PgDashboard : UserControl
    {
        public PgDashboard()
        {
            //if (Program.IsInDesignMode()) return;
            InitializeComponent();
            
        }

        private void PgDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLinkChrome_Click(object sender, EventArgs e)
        {
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            string url = "https://www.microsoft.com/id-id/";

            Process.Start(chromePath,url);
        }

        private void btnLinkMozila_Click(object sender, EventArgs e)
        {
            string mozillaPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            string url = "https://www.microsoft.com/id-id/";

            Process.Start(mozillaPath, url);
        }
    }
}
