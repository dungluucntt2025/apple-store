using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.Common;
using AppleStore.DataAccess.Insert;

namespace AppleStore.BusinessLogic
{
   public class XuLyThemNguoiDung
    {
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuNguoiDung nguoidungdata = new ChenDuLieuNguoiDung();
            nguoidungdata.Nguoidung = this.Nguoidung;
            nguoidungdata.chendulieunguoidung();
            this.Nguoidung.Idnguoidung = nguoidungdata.Nguoidung.Idnguoidung;
        }
    }
}
