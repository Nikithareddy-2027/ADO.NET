<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cust.aspx.cs" Inherits="CargoManagementSystem.Cust" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style =" background-color: antiquewhite;height : 500px; width : 400px">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="CustName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="CustId"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="PinCode"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label12" runat="server" Text="PhNo"></asp:Label>
                    </td>
                     <td>
                         <asp:TextBox ID="txtPhno" runat="server"></asp:TextBox>
                    </td>
                </tr>
            
                

                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="ReceiverName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtReceivername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="ReceiverId"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtreceiverid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRecAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRecCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="PinCode"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRecPincode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="PhNo"></asp:Label>
                    </td>
                     <td>
                         <asp:TextBox ID="txtRecPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Save" />
                        <asp:Button ID="Button2" runat="server" Text="Exit" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
