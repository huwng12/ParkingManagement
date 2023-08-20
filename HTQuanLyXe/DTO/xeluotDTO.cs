using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQuanLyXe.DTO
{
    class xeluotDTO
    {
        private string masove;
        private string bienso;
        private string loaixe;
        private string tenxe;
        private string nguoigui;
        private string loaive;
        private DateTime tgvaoben;
        //private DateTime ngayDangKy;
        //private DateTime ngayHetHan;



        public string Masove
        {
            get
            {
                return masove;
            }

            set
            {
                masove = value;
            }
        }

        public string Bienso
        {
            get
            {
                return bienso;
            }

            set
            {
                bienso = value;
            }
        }

        public string Loaixe
        {
            get
            {
                return loaixe;
            }

            set
            {
                loaixe = value;
            }
        }

        public string Tenxe
        {
            get
            {
                return tenxe;
            }

            set
            {
                tenxe = value;
            }
        }

        public string Nguoigui
        {
            get
            {
                return nguoigui;
            }

            set
            {
                nguoigui = value;
            }
        }

        public string Loaive
        {
            get
            {
                return loaive;
            }

            set
            {
                loaive = value;
            }
        }
        public DateTime Tgvaoben
        {
            get
            {
                return tgvaoben;
            }

            set
            {
                tgvaoben = value;
            }
        }
        //private DateTime NgayDangKy
        //{
        //    get
        //    {
        //        return ngayDangKy;
        //    }

        //    set
        //    {
        //        ngayDangKy = value;
        //    }
        //}
        //private DateTime NgayHetHan
        //{
        //    get
        //    {
        //        return ngayHetHan;
        //    }

        //    set
        //    {
        //        ngayHetHan = value;
        //    }
        //}


        public xeluotDTO(DataRow row)
        {
            this.Masove = row["maSoVe"].ToString();
            this.Bienso = row["bienSo"].ToString();
            this.Loaixe = row["loaiXe"].ToString();
            this.Tenxe = row["tenxe"].ToString();
            this.Nguoigui = row["nguoigui"].ToString();
            this.Loaive = row["loaiVe"].ToString();
            this.Tgvaoben = DateTime.Parse(row["tgvaoben"].ToString());
            //this.NgayDangKy = DateTime.Parse(row["ngayDangKi"].ToString());
           // this.NgayHetHan = DateTime.Parse(row["ngayHetHan"].ToString());
        }
    }
}
