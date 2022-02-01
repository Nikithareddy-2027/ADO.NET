<%@ Page Title="" Language="C#" MasterPageFile="~/Cargo.Master" AutoEventWireup="true" CodeBehind="Transaction_Details.aspx.cs" Inherits="CargoManagementSystem.Transaction_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    function validate()
    {
       
    }
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Transaction Details</h2>
    <hr />

        <div style =" background-color: antiquewhite;height : 253px; width : 426px">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="TransId"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTransId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="TotalAmount"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTotalAmount" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Date"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="BankAccNo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBankaccno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="txtSave" runat="server" Text="Save" OnClick="txtSave_Click"  />
                        <asp:Button ID="txtExit" runat="server" Text="Exit"  />
                    </td>
                </tr>
            </table>
        </div>
    
</asp:Content>
