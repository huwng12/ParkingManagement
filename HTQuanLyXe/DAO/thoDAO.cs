using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace HTQuanLyXe.DAO
{
     class thoDAO
    {
        My_DB mydb = new My_DB();
        public int IdTho { get; set; }
        public string ten { get; set; }
        public DateTime ngaysinh { get; set; }
        public bool gioitinh { get; set; }
        public string phone { get; set; }
        public string vaitro { get; set; }
        public string diachi { get; set; }
        public float luong { get; set; }
        public bool insertTho(int IdTho, string ten, DateTime ngaysinh, string gioitinh, string phone, string diachi, string vaitro, float luong)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Tho ( IdTho, ten, ngaysinh, gioitinh, phone, diachi,  vaitro, luong)" +
                "VALUES ( @idtho, @ten, @ns, @gt, @ph , @dc, @vt, @luong) ", mydb.getConnection);
            command.Parameters.Add("@idtho", SqlDbType.Int).Value = IdTho;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = ten;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@vt", SqlDbType.NVarChar).Value = vaitro;
            command.Parameters.Add("@luong", SqlDbType.Float).Value = luong;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public bool DeleteTho(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Tho WHERE IdTho = " + id, mydb.getConnection);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }

        public bool EditTho(int IdTho, string ten, DateTime ngaysinh, string gioitinh, string phone, string diachi, string vaitro, float luong)
        {
            SqlCommand command = new SqlCommand("UPDATE Tho SET ten = @ten, ngaysinh = @ns, gioitinh = @gt, phone=@ph, diachi=@dc, vaitro=@vt, luong=@luong WHERE IdTho = @sid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = IdTho;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = ten;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@vt", SqlDbType.NVarChar).Value = vaitro;
            command.Parameters.Add("@luong", SqlDbType.Float).Value = luong;
            mydb.openConnection();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getTho(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkIDExist(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho WHERE IdTho = @stid", mydb.getConnection);
            command.Parameters.Add("@stid", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /*
        public List<string> convert()  // Convert dữ liệu trong List Student sang String, từ Id Gender đều sang String 
        {
            List<string> stnew = new List<string>(); // Create new list of strings
            string a = Convert.ToString(Id);
            string b = Convert.ToString(fname);
            string c = Convert.ToString(lname);
            string d = Convert.ToString(bdate);
            string e = Convert.ToString(gender);
            string f = Convert.ToString(phone);
            string g = Convert.ToString(address);

            if (e == "False")
            {
                e = "Female";
            }
            if (e == "True")
            {
                e = "Male";
            }
            stnew.Add(a);
            stnew.Add(b); stnew.Add(c); stnew.Add(d); stnew.Add(e); stnew.Add(f); stnew.Add(g);
            return stnew;
        }
        */
        public bool updateCaLam(int Id, int Thu2, int Thu3, int Thu4, int Thu5, int Thu6, int Thu7, int CN)
        {
            SqlCommand command = new SqlCommand("UPDATE [ChiaCa] SET Thu2=@t2, Thu3=@t3, Thu4=@t4, Thu5=@t5, Thu6=@t6, Thu7=@t7, CN=@cn WHERE Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
            command.Parameters.Add("@t3", SqlDbType.Int).Value = Thu3;
            command.Parameters.Add("@t4", SqlDbType.Int).Value = Thu4;
            command.Parameters.Add("@t5", SqlDbType.Int).Value = Thu5;
            command.Parameters.Add("@t6", SqlDbType.Int).Value = Thu6;
            command.Parameters.Add("@t7", SqlDbType.Int).Value = Thu7;
            command.Parameters.Add("@cn", SqlDbType.Int).Value = CN;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
