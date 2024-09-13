<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>DetailsView CRUD Operations</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Employee Details</h3>

            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="Id" OnItemInserted="DetailsView1_ItemInserted"
                OnItemUpdated="DetailsView1_ItemUpdated" OnItemDeleted="DetailsView1_ItemDeleted" OnModeChanging="DetailsView1_ModeChanging">
                <Fields>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" InsertVisible="False" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile No" SortExpression="MobileNo" />

                    <asp:CommandField ShowInsertButton="True" ShowEditButton="True" ShowDeleteButton="True" />
                </Fields>
            </asp:DetailsView>

            <br />

            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
    </form>
</body>
</html>
