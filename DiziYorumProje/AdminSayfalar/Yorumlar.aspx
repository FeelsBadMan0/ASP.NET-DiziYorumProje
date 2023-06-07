<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Kullanıcı</th>
            <th>Blog</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("YORUMID") %></td>
                    <td><%# Eval("KULLANICIAD") %></td>
                    <td><%# Eval("BLOGBASLIK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-danger" runat="server" NavigateUrl='<%# "YorumSil.aspx?YORUMID="+ Eval("YORUMID") %>'>Sil</asp:HyperLink>

                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" CssClass="btn btn-warning" runat="server" NavigateUrl='<%# "YorumGuncelle.aspx?YORUMID="+ Eval("YORUMID") %>'>Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
