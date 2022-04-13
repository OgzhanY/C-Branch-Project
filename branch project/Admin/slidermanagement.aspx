<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="slidermanagement.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grdResim"  runat="server" AutoGenerateColumns="False">
        <Columns>
           
            <asp:TemplateField HeaderText="ResimID">
                <EditItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("ResimID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ResimID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Resim">
                <EditItemTemplate>
                   
                </EditItemTemplate>
                <ItemTemplate>
                   <img src='Resimler/<%#Eval("ResimYolu") %>' width="100" height="50" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                   
                </EditItemTemplate>
                <ItemTemplate>
                   <a href='slidermanagement.aspx?pageekle=<%#Eval("ResimID") %>'>Slayta Ekle</a> 
                </ItemTemplate>
            </asp:TemplateField>
          <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    
                </EditItemTemplate>
                <ItemTemplate>
                   <a href='slidermanagement.aspx?pagesil=<%#Eval("ResimID") %>'>Sil</a> 
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:FileUpload ID="fuResim" runat="server" AllowMultiple="True" /> <br />
    <asp:Button ID="btnYukle" runat="server" Text="Yükle" OnClick="btnYukle_Click" />
</asp:Content>
