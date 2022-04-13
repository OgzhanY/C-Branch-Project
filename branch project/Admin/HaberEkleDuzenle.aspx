<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="HaberEkleDuzenle.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin.HaberEkleDuzenle" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td>Haber Başlık</td>
            <td>
                <asp:TextBox ID="txtHaberBaslik" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Haber İçerik</td>
            <td>
                <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server" BasePath="ckeditor">
                </CKEditor:CKEditorControl>
            </td>
        </tr>
        <tr>
            <td>Haber Resim</td>
            <td>
                <asp:Image ID="imgResim" runat="server" width="120" />
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
                <asp:Button ID="btnDuzenle" runat="server" Text="Düzenle" Visible="False" OnClick="btnDuzenle_Click" />
                <asp:HiddenField ID="HiddenField1" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table align="center" class="auto-style1">
                    <tr>
                        <td>Haber Başlığı</td>
                        <td>İçerik</td>
                        <td>Resimler</td>
                        <td>İşlemler</td>
                    </tr>

                    <asp:Repeater ID="rptHaberGoster" runat="server">
                        <ItemTemplate>

                        


                    <tr>
                        <td><%#Eval("HaberBaslik") %></td>
                        <td>&nbsp;</td>
                        <td><img src="../resimler/<%#Eval("HaberResimler") %>" width="80px" height="80px" /></td>
                        <td>
                            <a href="haber_ekleduzenle.aspx?shid=<%#Eval("HaberID") %>"> Sil -</a>
                            <a href="haber_ekleduzenle.aspx?dhid=<%#Eval("HaberID") %>">  Düzenle </a>
                        </td>
                    </tr>

                    </ItemTemplate>
                    </asp:Repeater>

                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
</asp:Content>
