<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="e_Wallet.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to eWallet</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 80%;">
                <tr>
                    <td><asp:Label ID="lblWelcome" runat="server"></asp:Label></td>
                    <td><asp:Label ID="lblAccountNo" runat="server"></asp:Label></td>
                </tr>
            </table>

        </div>
        <br />
        <br />
        <div>
            <table  style="width: 70%;">
                <tr>
                    <td><asp:ImageButton ID="btnAccount" runat="server" ImageUrl="~/image/myaccount.jpg"  OnClick="btnGetAccount_Click" /></td>
                    <td><asp:ImageButton ID="btnviewprofile" runat="server" ImageUrl="~/image/viewprofile.jpg"  /></td>
                    <td><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/credit card transaction.jpg"  /></td>
                </tr>
                <td><asp:Label ID="Label1" runat="server"></asp:Label>
            </table>
        </div>
    </form>
</body>
</html>
