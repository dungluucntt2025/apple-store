using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppleStore.BusinessLogic;

namespace Web.Admin
{
    public partial class Admin_SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HienSanPham();
            }
        }
        private void HienSanPham()
        {
            XuLyLaySanPham xulysanpham = new XuLyLaySanPham();
            try
            {
                xulysanpham.Thucthi();
            }
            catch
            {
                Response.Redirect("../Trangloi.aspx");
            }
            dtlSanpham.DataSource = xulysanpham.Ketqua;
            dtlSanpham.DataBind();
        }
        protected void bntThemSanPham_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThemSanPham.aspx");
        }
    }

}