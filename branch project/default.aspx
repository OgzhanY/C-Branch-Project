<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.WebForm1" %>

<%@ Register Src="~/SliderKutuphanesi.ascx" TagPrefix="uc1" TagName="SliderKutuphanesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  
    <uc1:SliderKutuphanesi runat="server" ID="SliderKutuphanesi" />
  

</asp:Content>
