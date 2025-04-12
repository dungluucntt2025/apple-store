using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using System.Web.UI.WebControls;

namespace AppleStore.DataAccess.Select
{
  public  class TruyVanDuLieuGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "GioHang_Select";
            sqldata.SelectParameters.Add("CartGUID", Giohang.Cartguid);
            return sqldata;
        }
    }
}
