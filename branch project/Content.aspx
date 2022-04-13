<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.WebForm2" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="litPagename" runat="server"></asp:Literal>
    <asp:Literal ID="litIcerik" runat="server"></asp:Literal>
    <CKEditor:CKEditorControl ID="ckEditor" runat="server"></CKEditor:CKEditorControl>
   
</asp:Content>
