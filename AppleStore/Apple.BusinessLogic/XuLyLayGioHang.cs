using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using AppleStore.Common;
using AppleStore.DataAccess.Select;

namespace AppleStore.BusinessLogic
{
   public class XuLyLayGioHang
    {
        private SqlDataSource _ketqua;
        private GioHang _giohang;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuGioHang dulieugiohang = new TruyVanDuLieuGioHang();
            dulieugiohang.Giohang = Giohang;
            Ketqua = dulieugiohang.Laydulieu();
        }
    }
}
