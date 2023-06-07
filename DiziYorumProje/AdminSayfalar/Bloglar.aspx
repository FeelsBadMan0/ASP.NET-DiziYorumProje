<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Bloglar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Başlık</th>
            <th>Tarih</th>
            <th>Tür</th>
            <th>Kategori</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BLOGID") %></td>
                    <td><%# Eval("BLOGBASLIK") %></td>
                    <td><%# Eval("BLOGTARIH") %></td>
                    <td><%# Eval("TURAD") %></td>
                    <td><%# Eval("KATEGORIAD") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-danger" runat="server" NavigateUrl='<%# "BlogSil.aspx?BLOGID="+ Eval("BLOGID") %>'>Sil</asp:HyperLink>

                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" CssClass="btn btn-warning" runat="server" NavigateUrl='<%# "BlogGuncelle.aspx?BLOGID="+ Eval("BLOGID") %>'>Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YeniBlog.aspx" class="btn btn-primary">Yeni Blog</a>
</asp:Content>
