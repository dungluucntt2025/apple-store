using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using System.Web.UI.WebControls;

namespace AppleStore.DataAccess.Delete
{
   public class XoaDuLieuGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Xoadulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "GioHang_Delete";
            sqldata.DeleteParameters.Add("IDGioHang", Giohang.Idgiohang.ToString());
            sqldata.Delete();
        }
    }
}
