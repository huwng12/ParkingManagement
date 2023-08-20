using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyXe
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dangnhap form = new dangnhap();
            this.Hide();
            form.Show();
            
        }

        private void linklbTermCondition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mercedes-benz.com.vn/en/passengercars/content-pool/tool-pages/legal/privacy-statement.html");
        }

        private void btnConnectFB_Click(object sender, EventArgs e)
        {
        
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?=75548495");
        }
    }
}
