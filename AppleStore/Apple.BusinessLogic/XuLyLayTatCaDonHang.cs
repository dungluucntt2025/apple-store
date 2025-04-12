using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using AppleStore.DataAccess.Select;

namespace AppleStore.BusinessLogic
{
   public class XuLyLayTatCaDonHang
    {
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuTatCaDonHang truyvantatcadonhang = new TruyVanDuLieuTatCaDonHang();
            Ketqua = truyvantatcadonhang.Laydulieu();
        }
    }
}
