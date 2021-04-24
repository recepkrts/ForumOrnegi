<%@ Page Language="C#" AutoEventWireup="true" CodeFile="enter.aspx.cs" Inherits="enter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        E-Postanız:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Şifreniz:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş Yap" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
