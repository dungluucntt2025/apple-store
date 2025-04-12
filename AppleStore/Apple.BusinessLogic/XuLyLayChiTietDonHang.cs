using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using System.Web.UI.WebControls;
using AppleStore.DataAccess.Select;

namespace AppleStore.BusinessLogic
{
  public  class XuLyLayChiTietDonHang
    {
        private ChiTietDonHang _chitietdonhang;
        public ChiTietDonHang Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuChiTietDonHang truyvanchitietdonhang = new
            TruyVanDuLieuChiTietDonHang();
            truyvanchitietdonhang.Chitietdonhang = this.Chitietdonhang;
            Ketqua = truyvanchitietdonhang.Laydulieu();
        }
    }
}
