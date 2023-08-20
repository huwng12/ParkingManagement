using HTQuanLyXe.DAO;
using HTQuanLyXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataTable = System.Data.DataTable;
using System.Drawing.Printing;
using Font = System.Drawing.Font;
using Point = System.Drawing.Point;
using Microsoft.Office.Interop.Word;
namespace HTQuanLyXe
{
    public partial class ChiaCaForm : Form
    {
        public ChiaCaForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        thoDAO tho = new thoDAO();
        public DataTable showData(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void buttonChiaCa_Click(object sender, EventArgs e)
        {
            SqlCommand commandCa = new SqlCommand(" SELECT Tho.IdTho, Thu2, Thu3, Thu4, Thu5, Thu6, Thu7, CN FROM ChiaCa RIGHT JOIN Tho ON ChiaCa.id = Tho.IdTho ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapter.Fill(tableCa);

            int n;
            Random rd = new Random();
            n = rd.Next(1, 4);
            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCa.Columns.Count; j++)
                {
                    tableCa.Rows[i][j] = n;
                    n++;
                    if (n == 4)
                    {
                        n = 1;
                    }
                }
                /*
                tho.updateCaLam(Convert.ToInt32(tableCa.Rows[i]["id"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu2"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu3"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu4"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu5"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu6"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["Thu7"].ToString()),
                    Convert.ToInt32(tableCa.Rows[i]["CN"].ToString()));
                */
                
            }

            dataGridViewChiaCaNV.DataSource = tableCa;
            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCa.Columns.Count; j++)
                {
                    if (Convert.ToInt32(tableCa.Rows[i][j].ToString()) == 3)
                    {
                        dataGridViewChiaCaNV.Rows[i].Cells[j].Value = "Ca1, Ca2";

                    }
                    else if (Convert.ToInt32(tableCa.Rows[i][j].ToString()) == 2)
                    {
                        dataGridViewChiaCaNV.Rows[i].Cells[j].Value = "Ca1, Ca3";
                    }
                    else
                    {
                        dataGridViewChiaCaNV.Rows[i].Cells[j].Value = "Ca2, Ca3";
                    }
                }
            }
            dataGridViewChiaCaNV.AllowUserToAddRows = false;
            MessageBox.Show("CHIA CA THÀNH CÔNG CHO NHÂN VIÊN!!!");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void buttonSaveWord_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dataGridViewChiaCaNV.Columns.Count;
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
            Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewChiaCaNV.Rows.Count + 1, dataGridViewChiaCaNV.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewChiaCaNV.Columns[c].HeaderText;
                tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
                tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dataGridViewChiaCaNV.Rows[i - 2].Cells[j - 1].Value.ToString();
                    //tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            object filename = @"C:\Users\TRI PC\Documents\chiaCa.doc";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);
        }
    
    }
}
