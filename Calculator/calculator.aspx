<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="Calculator.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>First Number</td>
                    <td>:</td>
                    <td><asp:TextBox runat="server" ID="txtFirstNumber"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Second Number</td>
                    <td>:</td>
                    <td><asp:TextBox runat="server" ID="txtSecondNumber"></asp:TextBox></td>
                </tr>
                <tr runat="server" id="resSum" visible="false">
                    <td>Sum</td>
                    <td>:</td>
                    <td><asp:Label runat="server" ID="lblSum"></asp:Label></td>
                </tr>
                <tr runat="server" id="resMul" visible="false">
                    <td>Product</td>
                    <td>:</td>
                    <td><asp:Label runat="server" ID="lblMul"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="3"><asp:Button runat="server" ID="btnCalculate" Text="Calculate" OnClick="btnCalculate_Click" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="gvCalculation" runat="server"></asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
