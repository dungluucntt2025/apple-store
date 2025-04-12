<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true"
    CodeBehind="SanPham.aspx.cs" Inherits="Web.Admin.Admin_SanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Button ID="bntThemSanPham" runat="server" Text="Thêm Sản Phẩm" OnClick="bntThemSanPham_Click" /><br />
    <div>
        <asp:DataList ID="dtlSanpham" runat="server" RepeatColumns="3" Width="750px" CellPadding="0">
            <ItemTemplate>
                <asp:Panel ID="Panel1" runat="server" BorderColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px"
                    Width="250px">
                    <table cellpadding="0" cellspacing="0" style="width: 250px; height: 200px">
                        <tr>
                            <td rowspan="1" style="width: 125px; height: 150px" align="center" valign="middle">
                                <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl='<%# Eval("IdHinhSanPham","../HienThiHinhSanPham.ashx?IdHinhSanPham={0}") %>'
                                    Width="125px" />
                            </td>
                            <td style="width: 125px; height: 150px" align="center" valign="middle">
                                <div>
                                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("IdSanPham","SuaSanPham.aspx?IdSanPham={0}") %>'
                                        Text='<%# Eval("TenSanPham") %>'></asp:HyperLink>
                                </div>
                                <br />
                                <div>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("GiaSanPham","{0:###,###,###} VND") %>'></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" rowspan="1">
                                <asp:Label ID="Label2" runat="server" Text=''></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </ItemTemplate>
        </asp:DataList>
        <%--
        <asp:DataList ID="dtlSanpham" runat="server" RepeatColumns="1" Width="530px" CaptionAlign="Top" HorizontalAlign="Center">
        <ItemTemplate>
            <asp:Panel ID="Panel1" runat="server" BorderColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px"
                Width="170px" Height="250px">
            <table cellpadding="0" cellspacing="0" style="width: 250px; height:300px">
                <tr>
                    <td style="align="center" valign="middle">
                        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl='<%# Eval("IdHinhSanPham","../HienThiHinhSanPham.ashx?IdHinhSanPham={0}") %>'
                            Width="125px" /></td>
                    <td style="align="center" valign="middle">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("IdSanPham","SuaSanPham.aspx?IdSanPham={0}") %>'
                            Text='<%# Eval("TenSanPham") %>'></asp:HyperLink>
                        <br />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("GiaSanPham","{0:###,###,###} VND") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MoTaSanPham") %>'></asp:Label></td>
                </tr>
            </table>
            </asp:Panel>
        </ItemTemplate>
        
    </asp:DataList>--%>
        <%--<asp:Panel ID="Panel1" runat="server" BorderColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px"
            Width="100%">
            <asp:DataList ID="dtlSanpham" runat="server" RepeatColumns="3" Width="750px" CellPadding="0">
                <ItemTemplate>
                    <table cellpadding="0" cellspacing="0" style="background:#e6e6ed; width: 100%; height: 300px" border="1">
                        <tr>
                        <td style="align="center" valign="middle">
                        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl='<%# Eval("IdHinhSanPham","../HienThiHinhSanPham.ashx?IdHinhSanPham={0}") %>'
                            Width="125px" /></td>
                            <td style="align="center" valign="middle">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("IdSanPham","SuaSanPham.aspx?IdSanPham={0}") %>'
                            Text='<%# Eval("TenSanPham") %>'></asp:HyperLink>
                        <br />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("GiaSanPham","{0:###,###,###} VND") %>'></asp:Label></td>
                        </tr>
                        <tr>
                        <td colspan="2">
                        <asp:Label ID="Label2" runat="server" Text='hihi'></asp:Label></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </asp:Panel>--%>
    </div>
</asp:Content>
