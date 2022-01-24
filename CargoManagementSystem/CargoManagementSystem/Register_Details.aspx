<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_Details.aspx.cs" Inherits="CargoManagementSystem.Register_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
                   
                    </td>
                    <td>
                        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>     
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter First Name" BorderColor="#FF9933" ControlToValidate="txtFName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Lastname"></asp:Label>        
                    </td>
                    <td>
                        <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>          
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLName" ErrorMessage="ENter Last Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
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
                        <asp:Label ID="Label4" runat="server" Text="PhoneNumber"></asp:Label>    
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhNo" runat="server"></asp:TextBox>              
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhNo" ErrorMessage="Enter Phone Number"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtPhNo" ErrorMessage="Invalid Format" MaximumValue="9999999999" MinimumValue="0000000000"></asp:RangeValidator>
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
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Re-enterPassword"></asp:Label>        
                    </td>
                    <td>
                        <asp:TextBox ID="txtRepwd" runat="server"></asp:TextBox>          
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtRepwd" ErrorMessage="Password does not match"></asp:CompareValidator>
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
