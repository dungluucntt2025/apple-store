using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using AppleStore.DataAccess.Select;

namespace AppleStore.BusinessLogic
{
  public  class XuLyLayTinhTrangDonHang
    {

        private SqlDataSource _ketqua;

        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuTinhTrangDonHang Dulieutinhtrangdonhang = new TruyVanDuLieuTinhTrangDonHang();
            Ketqua = Dulieutinhtrangdonhang.Laydulieu();
        }
    }
}
