<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h3> Bank Customer Request</h3>
    <div>
        <table cellpadding="10" cellspacing="10" style="border: 1px solid #ddd;">
            <tr>
                <td class="auto-style1"> &nbsp;Name </td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Email
                </td>
                <td>
                    <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Mobile No.
                </td>
                <td>
                    <asp:TextBox ID="txtMob" runat="server" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                      &nbsp;</td>
                <td>
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GrdCustomer" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [data]"></asp:SqlDataSource>
    </div>
    </form>

</body>
</html>
