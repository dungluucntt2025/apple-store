<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Top10SanPham.ascx.cs"
    Inherits="Web.TaiNguyenDieuKhien.Top10SanPham" %>
<marquee height="300" direction="up" scrollamount="1" scrolldelay="10" truespeed="truespeed"
    onmouseover="this.stop()" onmouseout="this.start()" style="text-align: center"><asp:DataList id="dtl10SanPham" runat="server" Width="200px"><ItemTemplate>
<table cellspacing="0" cellPadding="0" width="200">
<tbody>
<tr>
<td style="width: 180px; height: 19px; background-color: gainsboro">
<asp:Label id="Label1" runat="server" Text='<%# Eval("TenSanPham") %>' 
ForeColor="Maroon" Font-Bold="True">
</asp:Label>
</td>
</tr>

<tr>
<td style="width: 200px">

<a href='<%# Eval("IdSanPham","../ChiTietSanPham.aspx?IdSanPham={0}") %>' ><img src='<%# Eval("IDHinhSanPham","../HienThiHinhSanPham.ashx?IdHinhSanPham={0}") %>' height="200" alt="" /></a>
</td></tr>

<tr>
<td style="width: 200px; height: 40px" valign="top">
<asp:Label id="Label2" runat="server" Text='<%# Eval("GiaSanPham","{0:##,###,###} VND") %>' ForeColor="Maroon" Font-Bold="True"></asp:Label></td></tr>
</tbody></table>
</ItemTemplate>
</asp:DataList>
</marquee>
