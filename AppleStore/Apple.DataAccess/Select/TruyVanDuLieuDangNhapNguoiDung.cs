using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using System.Web.UI.WebControls;

namespace AppleStore.DataAccess.Select
{
   public class TruyVanDuLieuDangNhapNguoiDung
    {
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DangNhapNguoiDung_Select";
            sqldata.SelectParameters.Add("TenDangNhap", Nguoidung.Tendangnhap);
            sqldata.SelectParameters.Add("MatKhau", Nguoidung.Matkhau);
            return sqldata;
        }
    }
}
