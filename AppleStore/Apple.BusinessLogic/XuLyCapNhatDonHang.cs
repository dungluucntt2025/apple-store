using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using AppleStore.DataAccess.Update;

namespace AppleStore.BusinessLogic
{
   public class XuLyCapNhatDonHang
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public void Thucthi()
        {
            CapNhatDuLieuDonHang donhangupdate = new CapNhatDuLieuDonHang();
            donhangupdate.Donhang = this.Donhang;
            donhangupdate.capnhatdulieu();
        }
    }
}
