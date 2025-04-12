using System;
using System.Collections.Generic;
using System.Text;
using AppleStore.DataAccess.Select;
using System.Web.UI.WebControls;

namespace AppleStore.BusinessLogic
{
    public class XuLyLayTimSanPham
    {
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        private string _tieuchuantim;
        public string Tieuchuantim
        {
            get { return _tieuchuantim; }
            set { _tieuchuantim = value; }
        }
        public void thucthi()
        {
            TruyVanDuLieuTimSanPham timsanpham = new TruyVanDuLieuTimSanPham();
            Ketqua = timsanpham.Laydulieu(Tieuchuantim);

        }
    }
}