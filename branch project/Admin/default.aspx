<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div> <!-- Default u master page nin ana sayfası olarak belirledik -->
        Admin Panel Home Page<asp:Button ID="btnCikis" runat="server" Text="Çıkış" OnClick="btnCikis_Click" /><br />
        <a href="pagelist.aspx">Sayfalar</a>
        <a href="hbrlist.aspx">Haberler</a>
        

    </div>
</asp:Content>
