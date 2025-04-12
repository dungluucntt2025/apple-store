using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using AppleStore.DataAccess.Select;

namespace AppleStore.BusinessLogic
{
   public class XuLyLaySanPham
    {
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuSanPham dulieusanpham = new TruyVanDuLieuSanPham();
            Ketqua = dulieusanpham.Laydulieu();
        }
    }
}
