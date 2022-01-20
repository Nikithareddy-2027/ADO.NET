 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="TrainingApplication.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Training Application</title>
</head>
<body>
    <form runat="server">
        <div style =" background-color: antiquewhite;height : 253px; width : 426px">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="EmpId"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="EmpName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="EmpJob"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpJob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="EmpSal"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="EmpDeptNo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpDeptNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Location"></asp:Label>
                    </td>
                     <td>
                         <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="txtSubmit" runat="server" Text="Submit" OnClick="txtSubmit_Click" />
                        <asp:Button ID="txtEdit" runat="server" Text="Edit" OnClick="txtEdit_Click" />
                        <asp:Button ID="txtUpdate" runat="server" Text="Update" OnClick="txtUpdate_Click" />
                        <asp:Button ID="txtRest" runat="server" Text="Reset" OnClick="txtRest_Click" />
                        <asp:Button ID="txtDelete" runat="server" Text="Delete" OnClick="txtDelete_Click" />
                    </td>
                </tr>
            </table>


            <hr />
            <asp:Label Text ="" ID="lblResult" runat="server" />
            <hr />
            <h2>Table Details</h2>
            <asp:GridView ID="gvEmployeeDetails" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
