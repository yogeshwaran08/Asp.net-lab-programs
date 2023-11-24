<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <table class="nav-justified">
        <tr>
            <td style="width: 249px; height: 22px">
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            </td>
            <td style="width: 318px; height: 22px">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="This Field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 249px; height: 22px">
                <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td style="width: 318px; height: 22px">
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLname" ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 249px; height: 22px">
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            </td>
            <td style="width: 318px; height: 22px">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 249px; height: 22px">
                <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="width: 318px; height: 22px">
                <asp:TextBox ID="txtPaword" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPaword" ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 249px; height: 22px">
                <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td style="width: 318px; height: 22px">
                <asp:TextBox ID="txtCnfPword" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCnfPword" ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPaword" ControlToValidate="txtCnfPword" ErrorMessage="Password doesn't match" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 249px">Age</td>
            <td style="width: 318px">
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAge" ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Age must between 1- 100" ForeColor="Red" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 249px">&nbsp;</td>
            <td style="width: 318px">
                <asp:Button ID="Button1" runat="server" Text="Register Now" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

    
</asp:Content>
