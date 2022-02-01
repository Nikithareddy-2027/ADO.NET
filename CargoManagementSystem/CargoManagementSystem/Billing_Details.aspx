<%@ Page Title="" Language="C#" MasterPageFile="~/Cargo.Master" AutoEventWireup="true" CodeBehind="Billing_Details.aspx.cs" Inherits="CargoManagementSystem.Billing_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Billing Details</h2>
    <hr />

    <div style =" background-color: antiquewhite;height : 253px; width : 426px">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="BillNo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBillNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="CustId"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="TransId"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txttransId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Date"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="AmountPaid"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAmountPaid" runat="server"></asp:TextBox>
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
