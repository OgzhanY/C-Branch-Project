

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:label runat="server" text="Kullanıcı Adı:"></asp:label>
          <asp:textbox runat="server" ID="txtUsername"></asp:textbox>
         <asp:label runat="server" text="Şifre"></asp:label>
  
          <asp:textbox runat="server" ID="txtPassword"></asp:textbox>
        <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblPass" runat="server" Text="Label"></asp:Label>
    <asp:button runat="server" text="Giriş" ID="btnGiris" OnClick="btnGiris_Click" />
    </div>
    </form>
</body>
</html>
