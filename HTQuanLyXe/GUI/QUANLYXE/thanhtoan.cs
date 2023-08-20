using HTQuanLyXe.DAO;
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
    public partial class thanhtoan : Form
    {
        public static Boolean ok=false;
        public thanhtoan()
        {
            InitializeComponent();
            bien.Text = danhsachxe.bien;
            ma.Text = danhsachxe.mave;
            ten.Text = quanlyxeDAO.Instance.layten(danhsachxe.bien);
            nguoigui.Text = quanlyxeDAO.Instance.laynguoigui(danhsachxe.bien);
            loai.Text = quanlyxeDAO.Instance.layloaixe(danhsachxe.bien);
            tgvao.Text = quanlyxeDAO.Instance.laytgvao(danhsachxe.bien).ToString();
            tgra.Text = DateTime.Now.ToString();
            tienphat.Text = quanlyxeDAO.Instance.tinhtienphat(danhsachxe.bien).ToString();
            if(quanlyxeDAO.Instance.tinhtienphat(danhsachxe.bien) != 0)
            {
                label9.Show();
                if (quanlyxeDAO.Instance.lidophat(danhsachxe.bien) == false)
                    lidophat.Text = "Phạt x2 tiền giữ xe vì đã quá 3 ngày)";
                else
                    lidophat.Text = "Phạt x3 tiền giữ xe vì đã quá 7 ngày)";
            }    
            else
            {
                label9.Hide();
                lidophat.Hide();
            }    
            tien.Text = quanlyxeDAO.Instance.tinhtiengui(danhsachxe.bien).ToString();
            tongtien.Text = quanlyxeDAO.Instance.tinhtongtiengui(danhsachxe.bien).ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }

        private void thanhtoan_Load(object sender, EventArgs e)
        {

        }

        private void lidophat_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
