<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="hbrlist.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin.hbrlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grdHaber"  runat="server" AutoGenerateColumns="False">
        <Columns>
           
            <asp:TemplateField HeaderText="HaberID">
                <EditItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("HaberID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("HaberID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PageName">
                <EditItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("HaberBaslik") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("HaberBaslik") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                   
                </EditItemTemplate>
                <ItemTemplate>
                   <a href='HaberEkleDuzenle.aspx?haberid=<%#Eval("HaberID") %>'>Düzenle</a> 
                </ItemTemplate>
            </asp:TemplateField>
          <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    
                </EditItemTemplate>
                <ItemTemplate>
                   <a href='HaberEkleDuzenle.aspx?habersil=<%#Eval("HaberID") %>'>Sil</a> 
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
