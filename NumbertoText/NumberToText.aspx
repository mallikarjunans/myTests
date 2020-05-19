<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumberToText.aspx.cs" Inherits="NumbertoText.NumberToText1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox id="txtNumber" runat="server" text="Enter Number:"></asp:TextBox>
        
        <asp:Button runat="server" id="btnSubmit" Text="Convert" OnClick="btnSubmit_OnClick" />
       </br>
        <asp:Label id="lblText" runat="server">Converted Text:</asp:Label>
    </div>

    </form>
</body>
</html>
