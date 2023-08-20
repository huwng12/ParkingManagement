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
    public partial class contactForm : Form
    {
        public contactForm()
        {
            InitializeComponent();
        }

        private void buttonFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/sktmaneytri/");
        }

        private void buttonINS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/sktmaneytri/");
        }

        private void buttonYOU_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC8jxBCYMGZmMFty1nh_cpYw");
        }
    }
}
