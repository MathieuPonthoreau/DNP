<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Celsius to Fahrenheit :<br />
            <asp:TextBox ID="TextBoxCtoF" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="ButtonCtoF" runat="server" OnClick="ButtonCtoF_Click" Text="Convert" />
            <br />
            <br />
            Fahrenheit to Celsius<br />
            <asp:TextBox ID="TextBoxFtoC" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="ButtonFtoC" runat="server" OnClick="ButtonFtoC_Click" Text="Convert" />
        </div>
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
    </form>
</body>
</html>
