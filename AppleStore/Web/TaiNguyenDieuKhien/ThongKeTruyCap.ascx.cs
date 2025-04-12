using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppleStore.BusinessLogic;

namespace Web.TaiNguyenDieuKhien
{
    public partial class ThongKeTruyCap : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOnline.Text = Application["SoNguoiOnLine"].ToString();
            XuLyLayThongKeTruyCap thongketruycap = new XuLyLayThongKeTruyCap();
            thongketruycap.Thucthi();
            // Hiển thị lượt truy cập ra điều khiển GridView1
            GridView1.DataSource = thongketruycap.Ketqua; // GridView1 là ID của GridView
            GridView1.DataBind();
        }
    }
}