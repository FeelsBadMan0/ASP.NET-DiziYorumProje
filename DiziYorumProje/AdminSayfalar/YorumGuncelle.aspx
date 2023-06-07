<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form runat="server" class="form-group">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" PlaceHolder="Blog Başlık" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" PlaceHolder="Kullanıcı Adı"></asp:TextBox>
        <br />
         <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" PlaceHolder="Yorum İçreik" TextMode="MultiLine" Height="300px"></asp:TextBox>
        <br />
         <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
