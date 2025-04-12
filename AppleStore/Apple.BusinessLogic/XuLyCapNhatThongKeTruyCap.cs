using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.DataAccess.Update;

namespace AppleStore.BusinessLogic
{
   public class XuLyCapNhatThongKeTruyCap
    {
       public void Thucthi()
       {
           CapNhatDuLieuThongKeTruyCap dulieuthongketruycap = new CapNhatDuLieuThongKeTruyCap();
           dulieuthongketruycap.Capnhatdulieu();
       }
    }
}
