using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using AppleStore.DataAccess.Update;

namespace AppleStore.BusinessLogic
{
   public class XuLyCapNhatSanPham
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void Thucthi()
        {
            CapNhatDuLieuSanPham dulieusanpham = new
            CapNhatDuLieuSanPham();
            dulieusanpham.Sanpham = this.Sanpham;
            dulieusanpham.CapNhatSanphammoi();
        }
    }
}
