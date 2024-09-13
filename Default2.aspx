<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 529px;
            height: 103px;
        }
        .auto-style4 {
            text-align: center;
            width: 250px;
            font-weight: bold;
        }
        .auto-style5 {
            font-weight: bold;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            font-weight: bold;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style7" colspan="2">STUDENT&#39;S DETAILS</td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">ID</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="225px" CssClass="auto-style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">NAME</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="225px" CssClass="auto-style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">AGE</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="225px" CssClass="auto-style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">ADDRESS</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="225px" CssClass="auto-style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">MOBILE NO</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="225px" CssClass="auto-style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" BackColor="#FF9900" BorderColor="#FF9900" CssClass="auto-style5"  Height="29px" Width="84px" />
                    <b>&nbsp;&nbsp;&nbsp;
                    </b>
                    <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" BackColor="#FF9900" BorderColor="#FF9900" CssClass="auto-style5"  Height="29px" Width="84px" />
                    <b>&nbsp;&nbsp;&nbsp;
                    </b>
                    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" BackColor="#FF9900" BorderColor="#FF9900" CssClass="auto-style5" Height="29px" Width="84px" />
                    <b>&nbsp;&nbsp;&nbsp;
                    </b>
                    <asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" BackColor="#FF9900" BorderColor="#FF9900" CssClass="auto-style5" Height="29px" Width="84px" />
                </td>
            </tr>
        </table>
       </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" style="text-align: center; margin-left: 379px; font-weight: 700;" Width="822px" BackColor="#FF9900" CellPadding="4" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </form>
    
</body>
</html>
