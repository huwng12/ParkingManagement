using HTQuanLyXe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQuanLyXe.DAO
{
    class quanlyxeDAO
    {

        private static quanlyxeDAO instance;

        internal static quanlyxeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new quanlyxeDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<xeluotDTO> hienthixeluot()
        {
            String Query = "select * from XE where maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<xeluotDTO> listxe = new List<xeluotDTO>();
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                listxe.Add(dt);
            }
            return listxe;
        }
        //hiển thị danh sách tìm kiếm theo mã
        public List<xeluotDTO> timkiemtheoma(string ma)
        {
            String Query = "select * from XE where maSoVe like'%" + ma + "%'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<xeluotDTO > listadmin = new List<xeluotDTO>();
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //tìm kiếm theo biển
        public List<xeluotDTO> timkiemtheobien(string bien)
        {
            String Query = "select * from XE where bienSo like'%" + bien + "%'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<xeluotDTO> listadmin = new List<xeluotDTO>();
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //NHẬP XE vào bến
        public Boolean vaoben(string maSoVe,string loaixe, string bienSo, string tenxe, string nguoigui, DateTime tgvaoben)
        {
            string Queryve = "";
            string Querybai = "";
            string Queryxe = "";
            if (vethang(bienSo))
            {
                Queryve = "declare @gia nvarchar(20); set @gia=''; if ('" + loaixe + "'='Ô tô') set @gia='50000';if ('" + loaixe + "'='Xe máy') set @gia='5000'; if ('" + loaixe + "'='Xe đạp') set @gia='1000'; update VE set bienSo=N'" + bienSo + "',loaiXe=N'" + loaixe + "',giaVe=@gia where maSoVe=N'" + maSoVe + "'";
                Querybai = "update BAIXE set soChoTrong=((select tongSoCho from BAIXE where loaiXe=N'"+loaixe+"') - (select count(bienSo) from XE where loaiXe=N'"+loaixe+"' and maSoVe!=N'Vé tháng')) where loaiXe=N'"+loaixe+"'";              
                Queryxe = "update XE set maSoVe='" + maSoVe + "', tgvaoben='" + DateTime.Now + "' where bienSo='" + bienSo + "'";
            }
            else
            {
                Queryve = "declare @gia nvarchar(20); set @gia=''; if ('" + loaixe + "'='Ô tô') set @gia='50000';if ('" + loaixe + "'='Xe máy') set @gia='5000'; if ('" + loaixe + "'='Xe đạp') set @gia='1000'; update VE set bienSo=N'" + bienSo + "',loaiXe=N'" + loaixe + "',giaVe=@gia where maSoVe=N'" + maSoVe + "'";
                Querybai = "update BAIXE set soChoTrong=((select tongSoCho from BAIXE where loaiXe=N'" + loaixe + "') - (select count(bienSo) from XE where loaiXe=N'" + loaixe + "' and maSoVe!=N'Vé tháng')) where loaiXe=N'" + loaixe + "'";
                Queryxe = "insert into XE values(N'" + maSoVe + "',N'" + bienSo + "',N'" + loaixe + "',N'" + tenxe + "',N'" + nguoigui + "',N'Vé lượt','" + tgvaoben + "',null,null,null)";
            }
            int xe = dataprovider.Instance.ExcuteNonQuery(Queryxe);
            int bai = dataprovider.Instance.ExcuteNonQuery(Querybai);
            int ve = dataprovider.Instance.ExcuteNonQuery(Queryve);
            return (0 < xe &&0<bai && 0<ve);
        }
        // đăng ký vé tháng.
        public Boolean dangkyvethang(string maSoVe, string loaixe, string bienSo, string tenxe, string nguoigui, DateTime tgvaoben)
        {
            int tien=0;
            if (loaixe == "Ô tô")
                tien = 2000000;
            else if (loaixe == "Xe máy")
                tien = 120000;
            else if (loaixe == "Xe đạp")
                tien = 45000;
            
            string query = "insert into XE values(N'Vé tháng',N'" + bienSo + "',N'" + loaixe + "',N'" + tenxe + "',N'" + nguoigui + "',N'Vé tháng','" + tgvaoben + "',null,'" + DateTime.Now + "','" + DateTime.Now.AddDays(30) + "')";
            if(tontaixe(bienSo))
            {
                query = "update XE set tenXe=N'" + tenxe + "',nguoigui=N'" + nguoigui + "',loaiVe=N'Vé tháng',ngayDangKy='"+DateTime.Now+"',ngayHetHan='"+DateTime.Now.AddDays(30)+"' where bienSo=N'"+bienSo+"'";
            }
            string querytk = "insert into THONGKE values(N'Vé tháng',N'" + bienSo + "',N'" + loaixe + "',N'" + tenxe + "',N'" + nguoigui + "',N'Vé tháng',"+tien+",'" + tgvaoben + "','" + tgvaoben + "','" + DateTime.Now + "','" + DateTime.Now.AddDays(30) + "')";
            string querytien = "update BAIXE set soTienThuVe=soTienThuVe+"+tien+" where loaiXe=N'"+loaixe+"'";
            return (0 < dataprovider.Instance.ExcuteNonQuery(query)&&0<dataprovider.Instance.ExcuteNonQuery(querytien) &&0<dataprovider.Instance.ExcuteNonQuery(querytk));
        }
        //sửa thông tin xe trong bến
        public Boolean sua(string maSoVe, string loaixe, string bienSo, string tenxe, string nguoigui)
        {
            string queryve1 = "update VE set bienSo=null, giaVe=null, loaiXe=null where bienSo=N'" + bienSo + "'";
            string Queryve = "declare @gia nvarchar(20); set @gia=''; if ('" + loaixe + "'='Ô tô') set @gia='50000';if ('" + loaixe + "'='Xe máy') set @gia='5000'; if ('" + loaixe + "'='Xe đạp') set @gia='1000'; update VE set bienSo=N'" + bienSo + "',loaiXe=N'" + loaixe + "',giaVe=@gia where maSoVe=N'" + maSoVe + "'";
            string Queryxe = "update XE set maSoVe=N'" + maSoVe+ "',loaiXe=N'"+loaixe+"',tenXe=N'" + tenxe+ "',nguoigui=N'" + nguoigui  + "' where bienSo=N'" + bienSo+"'";
            int xe = dataprovider.Instance.ExcuteNonQuery(Queryxe);
            int ve1 = dataprovider.Instance.ExcuteNonQuery(queryve1);
            int ve = dataprovider.Instance.ExcuteNonQuery(Queryve);
            return (0 < xe && 0 < ve&& 0<ve1);
        }


        //tính tiền phạt 
        public int tinhtienphat(string bien)
        {
            int tienphat = 0;
            DateTime ngaymuon = Convert.ToDateTime(laytgvao(bien));
            DateTime ngaytra = Convert.ToDateTime(DateTime.Now);
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;
            if (vethang(bien))
                tienphat = 0;
            else if (TongSoNgay >= 3 && TongSoNgay <= 7)
            {
                if (layloaixe(bien) == "Ô tô")
                    tienphat = 50000 * 24 * TongSoNgay;
                if (layloaixe(bien) == "Xe máy")
                    tienphat = 5000 * 24 * TongSoNgay;
                if (layloaixe(bien) == "Xe đạp")
                    tienphat = 1000 * 24 * TongSoNgay;

            }
            else if (TongSoNgay > 7)
            {
                if (layloaixe(bien) == "Ô tô")
                    tienphat = 2 * 50000 * 24 * TongSoNgay;
                if (layloaixe(bien) == "Xe máy")
                    tienphat = 2 * 5000 * 24 * TongSoNgay;
                if (layloaixe(bien) == "Xe đạp")
                    tienphat = 2 * 1000 * 24 * TongSoNgay;
            }
            else
                tienphat = 0;
            return tienphat;
        }

        public bool lidophat(string bien)
        {
            bool result;
            if (tinhtienphat(bien) != 0)
            {
                DateTime ngaymuon = Convert.ToDateTime(laytgvao(bien));
                DateTime ngaytra = Convert.ToDateTime(DateTime.Now);
                TimeSpan Time = ngaytra - ngaymuon;
                int TongSoNgay = Time.Days;
                if (TongSoNgay >= 3 && TongSoNgay <= 7)
                {
                    result = false;
                    return result;
                }
                else if (TongSoNgay > 7)
                {
                    result = true;
                    return result;
                }
            }
            result = true;
            return result;
        }

        //Hàm tính tiền gửi
        public int tinhtiengui(string bien)
        {
            int tiengui = 0;
            DateTime ngaymuon = Convert.ToDateTime(laytgvao(bien));
            DateTime ngaytra = Convert.ToDateTime(DateTime.Now);
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;
            int TongSoGio = Time.Hours;
            if (vethang(bien))
                tiengui = 0;
            else if (TongSoGio <= 1 && TongSoNgay < 1)
            {
                if (layloaixe(bien) == "Ô tô")
                    tiengui = 50000;
                if (layloaixe(bien) == "Xe máy")
                    tiengui = 5000;
                if (layloaixe(bien) == "Xe đạp")
                    tiengui = 1000;
            }
            else if ((TongSoGio > 2 || TongSoGio < 24) && TongSoNgay < 1)
            {
                if (layloaixe(bien) == "Ô tô")
                    if (TongSoGio <= 1)
                        tiengui = 50000 * TongSoGio;
                if (layloaixe(bien) == "Xe máy")
                    if (TongSoGio <= 1)
                        tiengui = 5000 * TongSoGio;
                if (layloaixe(bien) == "Xe đạp")
                    if (TongSoGio <= 1)
                        tiengui = 1000 * TongSoGio;
            }
            else
            {
                if (layloaixe(bien) == "Ô tô")
                    tiengui = (50000 * TongSoGio) + (50000 * 24 * TongSoNgay) ;
                if (layloaixe(bien) == "Xe máy")
                    tiengui = (5000 * TongSoGio) + (5000 * 24 * TongSoNgay);
                if (layloaixe(bien) == "Xe đạp")
                    tiengui = (1000 * TongSoGio) + (1000 * 24 * TongSoNgay);

            }
            return tiengui;
        }

        //Tổng tiền cần thanh toán
        public int tinhtongtiengui(string bien)
        {
            int tien = 0;
            if (vethang(bien))
                tien = 0;
            else
                tien = tinhtiengui(bien) + tinhtienphat(bien); ;
            return tien;
        }
        //xuất xe ra khỏi bến
        public Boolean xuatben(string bien, string ma,DateTime ra)
        {
            int ttien = tinhtiengui(bien);
            string querytien = "update BAIXE set soTienThuVe=soTienThuVe+" + ttien + " where loaiXe=(select loaiXe from XE where bienSo='"+bien+"')";
            string queryve = "update VE set bienSo=null, loaiXe=null where bienSo='" + bien + "'";
            string query = "delete from Xe where bienSo='" + bien + "'and maSoVe='"+ma+"'";
            if (vethang(bien))
                query = "update XE set maSoVe=N'Vé tháng', tgvaoben=null where bienSo=N'"+bien+"'";
            string Querybai = "update BAIXE set soChoTrong=((select tongSoCho from BAIXE where loaiXe=(select loaiXe from XE where bienSo=N'" + bien + "')) + 1 - (select count(bienSo) from XE where loaiXe=(select loaiXe from XE where bienSo=N'" + bien + "') and maSoVe!=N'Vé tháng')) where loaiXe=(select loaiXe from XE where bienSo=N'" + bien + "')";
            string querytk = "insert into THONGKE values((select maSoVe from XE where bienSo='" + bien + "'),'" + bien + "',(select loaiXe from XE where bienSo='" + bien + "'),(select tenXe from XE where bienSo='" + bien + "'),(select nguoigui from XE where bienSo='" + bien + "'),(select loaiVe from XE where bienSo='" + bien + "'),"+ttien+",(select tgvaoben from XE where bienSo='" + bien + "'),'" +DateTime.Now+ "',null,null)";
            int tien = dataprovider.Instance.ExcuteNonQuery(querytien);
            int bai = dataprovider.Instance.ExcuteNonQuery(Querybai);
            int tk = dataprovider.Instance.ExcuteNonQuery(querytk);
            int ve = dataprovider.Instance.ExcuteNonQuery(queryve);
            int xe = dataprovider.Instance.ExcuteNonQuery(query);
            return  (0<xe && 0< tk && 0<bai && 0<tien);
        }
        //kiểm tra xem xe có khớp vé hay không
        public Boolean khopvexe(string bien, string ma)
        {
            string query = "select * from Xe where bienSo='" + bien + "' and maSoVe='"+ma+"'";
            return dataprovider.Instance.ExcuteQuery(query).Rows.Count > 0;
        }
        //kiểm tra xem xe có tồn tại hay không
        public Boolean tontaixe(string bien)
        {
            string query = "select * from Xe where bienSo='" + bien + "' and maSoVe!='Vé tháng'";
            return dataprovider.Instance.ExcuteQuery(query).Rows.Count > 0;
        }
        public Boolean tontaive(string ma)
        {
            string query = "select * from Xe where maSoVe='" + ma + "'";
            return dataprovider.Instance.ExcuteQuery(query).Rows.Count > 0;
        }
        //tổng số xe trong bến
        public int tongxemay()
        {
            String Query = "select * from XE where loaiXe='Xe máy' and loaiVe!=N'Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        public int tongxedap()
        {
            String Query = "select * from XE where loaiXe='Xe đạp' and loaiVe!=N'Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        public int tongoto()
        {
            string Query = "select * from XE where loaiXe='Ô tô' and loaiVe!=N'Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        public Boolean vethang(string bien)
        {
            string query = "select * from XE where bienSo='"+bien+"' and loaiVe=N'Vé tháng'";
            return dataprovider.Instance.ExcuteQuery(query).Rows.Count>0;
        }
        //lấy tên
        public string layten(string bien)
        {
            string x ="";
            String Query = "select * from XE where bienSo='" + bien + "'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                x = dt.Tenxe;
            }
            return x;
        }
        //lấy màu
        public string laynguoigui(string bien)
        {
            string x = "";
            String Query = "select * from XE where bienSo='" + bien + "'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                x = dt.Nguoigui;
            }
            return x;
        }
        //lấy tg  vào
        public DateTime laytgvao(string bien)
        {
            DateTime x=DateTime.Now;
            String Query = "select * from XE where bienSo='" + bien + "'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                x = dt.Tgvaoben;
            }
            return x;
        }

        
        //lấy loại xe
        public string layloaixe(string bien)
        {
            string x = "";
            String Query = "select * from XE where bienSo='" + bien + "'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                x = dt.Loaixe;
            }
            return x;
        }
        
    }
}
