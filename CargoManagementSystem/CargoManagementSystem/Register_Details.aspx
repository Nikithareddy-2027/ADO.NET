<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_Details.aspx.cs" Inherits="CargoManagementSystem.Register_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div ><h1>Register</h1>
            <table>
                <tr>
                    <td>FirstName
                    </td>
                    <td>
                        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>     
                        
                    </td>
                </tr>
                <tr>
                    <td>Lastname    
                    </td>
                    <td>
                        <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>          
                       
                    </td>
                </tr>
                <tr>
                    <td>Email
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>       
                       
                    </td>
                </tr>
                <tr>
                    <td>PhoneNumber
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhNo" runat="server"></asp:TextBox>              
                       
                    </td>
                </tr>
                <tr>
                    <td>Password    
                    </td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>         
                       
                    </td>
                </tr>
                <tr>
                    <td>Re-enterPassword
                    </td>
                    <td>
                        <asp:TextBox ID="txtRepwd" runat="server"></asp:TextBox>          
                        
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="txtSubmit" runat="server" Text="Submit" />
                        <asp:Button ID="txtExit" runat="server" Text="Exit" />
                    </td>
                </tr>
                </table>
            <hr />
            <asp:Label Text ="" ID="lblResult" runat="server" />
            <hr />
          </div>
    </form>
</body>
</html>
