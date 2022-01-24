<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CargoManagementSystem.Login" %>

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
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>     
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>       
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Mail"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Format"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>        
                    </td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>         
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPwd" ErrorMessage="Strong Password"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                

                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="txtSignIn" runat="server" Text="Sign-in" />
                        <asp:Button ID="txtForgetPwd" runat="server" Text="Forget Password" />
                    </td>
                </tr>
                </table>
            <hr />
            <asp:HyperLink ID="Register" runat="server" NavigateUrl="~/Register_Details.aspx">Register</asp:HyperLink>
            <hr />
          </div>
     
        <p>
            <asp:Label Text ="" ID="lblResult" runat="server" />
            </p>
     
    </form>
</body>
</html>
