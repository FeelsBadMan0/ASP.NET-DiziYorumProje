<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="DiziYorumProje.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contact-content">
        <div class="container">
            <div class="contact-info">
                <h2>İLETİŞİM</h2>
                <p>Blog sayfamızda bulunan film ve dizilere eklenmesini isteklerinizi veya yorumlarda yaşadığınız bir problemi bize gönderebilirsiniz. Mail kısmını kullanırken lütfen iletişim bilgilerinizi doğru bir şekilde girdiğinize emin olun ve size geri dönüş yapmamızı bekleyin.</p>
            </div>
            <div class="contact-details">
                <form runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" required="" style="margin: 0px 0px 32px 0px"></asp:TextBox>
                    <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesaj" required="" TextMode="MultiLine" Height="300px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="GÖNDER" OnClick="Button1_Click" />
                </form>
            </div>
            <div class="contact-details">
                <div class="col-md-6 contact-map">
                    <h4>BİZİ BULUN</h4>
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d49608.04887519162!2d34.784045814122045!3d39.003836635522376!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x152a9365bbeaaf23%3A0x29a7032020a9dce5!2zVG9wcmFrbGksIFRvcGFrbMSxL0F2YW5vcy9OZXbFn2VoaXI!5e0!3m2!1str!2str!4v1686038827898!5m2!1str!2str" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
                </div>
                <div class="col-md-6 company_address">
                    <h4>BİZE ULAŞIN</h4>
                    <p>Nevşehir</p>
                    <p>Avanos</p>
                    <p>Türkiye</p>
                    <p>Telefon:(384) 222 - 6661</p>
                    <p>Fax: (384) 223 - 6642</p>
                    <p>Mail: <a href="mailto:info@deneme.com">info@deneme.com</a></p>
                    <p>Bizi Takip Edin: <a href="#">Facebook</a>, <a href="#">Twitter</a></p>
                </div>
                <div class="clearfix"></div>
            </div>


        </div>
    </div>
    </div>	

</asp:Content>
