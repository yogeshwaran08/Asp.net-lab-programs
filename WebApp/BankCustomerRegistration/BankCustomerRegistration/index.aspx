<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h3> Bank Customer Request</h3>
    <div>
        <table cellpadding="10" cellspacing="10" style="border: 1px solid #ddd;">
            <tr>
                <td> Customer Name </td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Current State
                </td>
                <td>
                    <asp:DropDownList Width="170px" ID="ddlstate" runat="server">
                        <asp:ListItem>--Select State--</asp:ListItem>
                        <asp:ListItem>TamilNadu</asp:ListItem>
                        <asp:ListItem>Andra Pradesh</asp:ListItem>
                        <asp:ListItem>Karnataka</asp:ListItem>
                        <asp:ListItem>Kerala</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Current City
                </td>
                <td>
                    <asp:DropDownList Width="170px" ID="ddlcity" runat="server">
                        <asp:ListItem>--Select City--</asp:ListItem>
                        <asp:ListItem>Chennai</asp:ListItem>
                        <asp:ListItem>Bangalore</asp:ListItem>
                        <asp:ListItem>Madurai</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Mobile No.
                </td>
                <td>
                    <asp:TextBox ID="txtMob" runat="server" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Aadhaar No.
                </td>
                <td>
    <asp:TextBox ID="txtaadhaar" MaxLength="12" AutoPostBack="true" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" colspan="2">
                    <asp:Label Text="" ID="lblaadhar" runat="server"></asp:Label>
                    <asp:Button ID="btnverify" runat="server" Text="Verify Aadhaar" OnClick="btnverify_Click" />
                </td>
            </tr>
            <tr>
                <td>
                      <asp:Button ID="btnclear" runat="server" Text="Reset" OnClick="btnclear_Click" />
                </td>
                <td>
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GrdCustomer" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
                <asp:BoundField DataField="Aadhar" HeaderText="Aadhar" SortExpression="Aadhar" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BankCustomerConnectionString3 %>" SelectCommand="SELECT * FROM [data]" EnableCaching="false" ></asp:SqlDataSource>
    </div>
    </form>

</body>
</html>
