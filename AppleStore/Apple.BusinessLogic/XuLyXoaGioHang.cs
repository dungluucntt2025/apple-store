using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using AppleStore.DataAccess.Delete;

namespace AppleStore.BusinessLogic
{
   public class XuLyXoaGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            XoaDuLieuGioHang dulieugiohang = new XoaDuLieuGioHang();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.Xoadulieu();
        }
    }
}
