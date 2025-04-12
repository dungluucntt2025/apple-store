using System;
using System.Web;
using System.Data;
using System.Web.UI;
using AppleStore.Common;
using AppleStore.BusinessLogic;
using System.Web.UI.WebControls;


namespace Web
{
    /// <summary>
    /// Summary description for HienThiSanPham
    /// </summary>
    public class HienThiHinhSanPham : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            SanPham sanpham = new SanPham();
            sanpham.Idhinhsanpham = int.Parse(context.Request.QueryString["Idhinhsanpham"]);
            XuLyLayHinhSanPham XuLyLayHinh = new XuLyLayHinhSanPham();
            XuLyLayHinh.Sanpham = sanpham;
            XuLyLayHinh.Thucthi();
            SqlDataSource src = new SqlDataSource();
            src = XuLyLayHinh.Ketqua;
            DataView view = (DataView)src.Select(DataSourceSelectArguments.Empty);
            context.Response.BinaryWrite((byte[])view[0]["DuLieuHinhSanPham"]);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }
}