using HTQuanLyXe.DAO;
using HTQuanLyXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DataTable = System.Data.DataTable;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Word;

namespace HTQuanLyXe.GUI.QUANLYXE
{
    public partial class QLTho : Form
    {
        public QLTho()
        {
            InitializeComponent();
            if (!taikhoan.quyenadmin)
            {
                this.btthem.Enabled = false;
                this.btxoa.Enabled = false;
                this.btthaydoithongtin.Enabled = false;
                this.refreshbtn.Enabled = false;
                this.chiaca_btn.Enabled = false;
                this.button2.Enabled = false;

            }
        }

        My_DB db = new My_DB();
        thoDAO tho = new thoDAO();

        public void fillGrid(SqlCommand command)
        {
            dataGridViewadmin.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewadmin.RowTemplate.Height = 80;
            dataGridViewadmin.DataSource = tho.getTho(command);
            dataGridViewadmin.AllowUserToAddRows = false;
        }
        private void QLTho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyXeOKDataSet1.Tho' table. You can move, or remove it, as needed.
            this.thoTableAdapter1.Fill(this.quanLyXeOKDataSet1.Tho);
            // TODO: This line of code loads data into the 'quanLyXeOKDataSet.Tho' table. You can move, or remove it, as needed.
            //this.thoTableAdapter.Fill(this.quanLyXeOKDataSet.Tho);
            dataGridViewadmin.AllowUserToAddRows = false;
            dataGridViewadmin.ReadOnly = true;
            dataGridViewadmin.RowTemplate.Height = 80;
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();

        }


        private void btthem_Click(object sender, EventArgs e)
        {
            thoDAO tho = new thoDAO();
            int id = Convert.ToInt32(txtma.Text);
            string name = txtten.Text;
            DateTime date = txtngay.Value;
            date.ToString("yyyy-MM-dd");
            string gioitinh = txtgt.Text;
            string phone = txtdt.Text;
            string diachi = txtdc.Text;
            string loainv = txtloainv.Text;
            float luong = float.Parse(txtluong.Text);
            int born_year = txtngay.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The THO age must be between 1- and 100 - Try again!", "Invalid ngày sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif() && !tho.checkIDExist(id))
            {
                
                if (tho.insertTho(id, name, date, gioitinh, phone, diachi, loainv, luong))
                {
                    MessageBox.Show("Đã thêm thợ thành công", "Thêm thợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtma.Text = "";
                    txtten.Text = "";
                    txtloainv.Text = "";
                    txtgt.Text = "";
                    txtdt.Text = "";
                    txtdc.Text = "";
                    txtngay.Value = DateTime.Now;
                    txtluong.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm thợ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền full thông tin hoặc thông tin đã bị trùng", "thêm thợ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((txtma.Text.Trim() == "")
                || (txtten.Text.Trim() == "")
                || (txtdc.Text.Trim() == "")
                || (txtngay.Text.Trim() == "")
                || (txtloainv.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            thoDAO tho = new thoDAO();
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    if (tho.DeleteTho(Int32.Parse(txtma.Text)))
                    {
                        MessageBox.Show("Xóa thành công", "Xóa thợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtma.Text = "";
                        txtten.Text = "";
                        txtloainv.Text = "";
                        txtgt.Text = "";
                        txtdt.Text = "";
                        txtdc.Text = "";
                        txtngay.Value = DateTime.Now;
                        txtluong.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("lỗi!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btthaydoithongtin_Click(object sender, EventArgs e)
        {
            thoDAO tho = new thoDAO();
            int id = Convert.ToInt32(txtma.Text);
            string name = txtten.Text;
            DateTime date = txtngay.Value;
            date.ToString("yyyy-MM-dd");
            string gioitinh = txtgt.Text;
            string phone = txtdt.Text;
            string diachi = txtdc.Text;
            string loainv = txtloainv.Text;
            float luong = float.Parse(txtluong.Text);
            int born_year = txtngay.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The THO age must be between 1- and 100 - Try again!", "Invalid ngày sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {

                if (tho.EditTho(id, name, date, gioitinh, phone, diachi, loainv, luong))
                {
                    MessageBox.Show("Đã chỉnh sửa thợ thành công", "Chỉnh sửa thợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Chỉnh sửa thợ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền full thông tin", "chỉnh sửa thợ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridViewadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridViewadmin.Rows[index];
            txtma.Text = selectRow.Cells[0].Value.ToString();
            txtten.Text = selectRow.Cells[1].Value.ToString();
            txtngay.Text= selectRow.Cells[2].Value.ToString();
            txtgt.Text = selectRow.Cells[3].Value.ToString();
            
            
            txtdt.Text = selectRow.Cells[4].Value.ToString();
            txtdc.Text = selectRow.Cells[5].Value.ToString();
            txtloainv.Text = selectRow.Cells[6].Value.ToString();
            txtluong.Text = selectRow.Cells[7].Value.ToString();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Tho"));
        }

        private void txttimkiemadmim_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonbttimkiemtheoma_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho WHERE CONCAT(IdTho,ten,vaitro,luong) LIKE'%" + txttimkiemadmim.Text + "% '");
            fillGrid(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dataGridViewadmin.Columns.Count;
            object missing = System.Reflection.Missing.Value;
            Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
            string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
                + DateTime.Today.Year.ToString("0000");
            foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
                para1.Range.Font.Bold = 2;        // Độ Đậm Chữ
                para1.Range.Font.Size = 14;
                para1.Range.Text = "Trường Đại Học Sư Phạm Kỹ Thuật Tp Hồ Chí Minh\n" + time
                                + "\nMôn: Lập trình trên Windows\n\t\t                       Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\n                                                          Course Semester\n";
                para1.Range.Text = "Người thực hiện:";
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                para1.Range.Text = "Họ và tên: Nguyễn Minh Trí";
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                para1.Range.Text = "MSSV: 20110422";
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Range footersRange = section.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                para1.Range.Fields.Add(footersRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
                para1.Range.Font.Bold = 2;        // Độ Đậm Chữ
                para1.Range.Font.Size = 14;
                para1.Range.Text = "TP.HCM, " + time;


                section.Borders.Enable = 1;
                section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                section.Borders.OutsideColor = WdColor.wdColorBlack;

            }

            // Tạo bảng danh sách sinh viên
            Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewadmin.Rows.Count + 1, dataGridViewadmin.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewadmin.Columns[c].HeaderText;
                tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
                tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text

                    tableST.Rows[i].Cells[j].Range.Text = dataGridViewadmin.Rows[i - 2].Cells[j - 1].Value.ToString();
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            object filename = @"C:\Users\TRI PC\Desktopscore_list.doc";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);
        }

        private void chiaca_btn_Click(object sender, EventArgs e)
        {
            ChiaCaForm form = new ChiaCaForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" SELECT Id FROM TimeLamViec", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //idl.updateTimeDayNew(Convert.ToInt32(table.Rows[i][0].ToString()));
            }
            MessageBox.Show("Đã Resest Thời Gian Làm Việc Cho Ngày Mới");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
