using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyXe.GUI.QUANLYXE
{
    public partial class dangkyvethang : Form
    {
        public static Boolean vethangok = false;
        public dangkyvethang()
        {
            InitializeComponent();
            bien.Text = danhsachxe.bien;
            ten.Text = danhsachxe.tenxe;
            nguoigui.Text = danhsachxe.nguoigui;
            loai.Text = danhsachxe.loaixe;
            tgvao.Text = DateTime.Now.ToString();
            tgra.Text = DateTime.Now.AddDays(30).ToString();
            if (loai.Text =="Ô tô")
                tien.Text = "2,000,000".ToString();
            if (loai.Text=="Xe máy")
                tien.Text = "120,000".ToString();
            if (loai.Text == "Xe đạp")
                tien.Text = "45,000".ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vethangok = true;
            this.Close();
        }

        private void nguoigui_Click(object sender, EventArgs e)
        {

        }

        private void dangkyvethang_Load(object sender, EventArgs e)
        {

        }
    }
}
