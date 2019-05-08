using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Broser
{
    public partial class frmWebBrowser : Form
    {
        public frmWebBrowser()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome(); //home button
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (webBrowser.IsBusy)
            {
                webBrowser.Stop(); //stop loading if something is loading
            }
            else
            {
                webBrowser.Refresh(); //refresh page if nothing is loading
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack(); //goes back if possible
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward(); //goes forward if possible
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string webpage = txtAddressBar.Text.Trim();
            webBrowser.Navigate(webpage); //navigates to the web page listed in the web address bar 
        }

        private void txtAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string webpage = txtAddressBar.Text.Trim();
                webBrowser.Navigate(webpage); //navigates to the web page listed in the web address bar (pressing enter)
            }
        }
    }
}
