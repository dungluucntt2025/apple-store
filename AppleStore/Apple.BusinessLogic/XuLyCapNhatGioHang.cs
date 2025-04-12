using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using AppleStore.DataAccess.Update;

namespace AppleStore.BusinessLogic
{
   public class XuLyCapNhatGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            CapNhatDuLieuGioHang dulieugiohang = new CapNhatDuLieuGioHang();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.capnhatdulieu();
        }
    }
}
