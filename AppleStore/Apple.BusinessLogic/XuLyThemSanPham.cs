using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using AppleStore.DataAccess.Insert;

namespace AppleStore.BusinessLogic
{
   public class XuLyThemSanPham
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuSanPham dulieusanpham = new ChenDuLieuSanPham();
            dulieusanpham.Sanpham = this.Sanpham;
            dulieusanpham.ChenDuLieu();
        }
    }
}
