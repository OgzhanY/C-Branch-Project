<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="pagelist.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="grdPages"  runat="server" AutoGenerateColumns="False">
        <Columns>
           
            <asp:TemplateField HeaderText="PageID">
                <EditItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("PageID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("PageID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PageName">
                <EditItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("PageName") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("PageName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                   
                </EditItemTemplate>
                <ItemTemplate>
                   <a href='pagemanagement.aspx?pageid=<%#Eval("PageID") %>'>Düzenle</a> 
                </ItemTemplate>
            </asp:TemplateField>
          <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    
                </EditItemTemplate>
                <ItemTemplate>
                   <a href='pagemanagement.aspx?pagesil=<%#Eval("PageID") %>'>Sil</a> 
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
