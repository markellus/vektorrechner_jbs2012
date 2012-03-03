using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VektorRechner
{
    public partial class Website : Form
    {
        public Website()
        {
            InitializeComponent();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            lblWebsite.Text = Convert.ToString(webBrowser1.Url);
        }
    }
}
