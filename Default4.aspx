<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>FormView CRUD Operations</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Employee Details</h3>

            <asp:FormView ID="FormView1" runat="server" DataKeyNames="Id" DefaultMode="ReadOnly"
                OnItemInserted="FormView1_ItemInserted" OnItemUpdated="FormView1_ItemUpdated"
                OnItemDeleted="FormView1_ItemDeleted" OnModeChanging="FormView1_ModeChanging">
                <InsertItemTemplate>
                    Name: <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>' /><br />
                    Age: <asp:TextBox ID="txtAge" runat="server" Text='<%# Bind("Age") %>' /><br />
                    Address: <asp:TextBox ID="txtAddress" runat="server" Text='<%# Bind("Address") %>' /><br />
                    Mobile No: <asp:TextBox ID="txtMobileNo" runat="server" Text='<%# Bind("MobileNo") %>' /><br />
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" CommandName="Insert" />
                    <asp:Button ID="btnCancelInsert" runat="server" Text="Cancel" CommandName="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    Id: <asp:Label ID="lblId" runat="server" Text='<%# Bind("Id") %>' /><br />
                    Name: <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>' /><br />
                    Age: <asp:Label ID="lblAge" runat="server" Text='<%# Bind("Age") %>' /><br />
                    Address: <asp:Label ID="lblAddress" runat="server" Text='<%# Bind("Address") %>' /><br />
                    Mobile No: <asp:Label ID="lblMobileNo" runat="server" Text='<%# Bind("MobileNo") %>' /><br />
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" />
                </ItemTemplate>
                <EditItemTemplate>
                    Id: <asp:Label ID="lblId" runat="server" Text='<%# Bind("Id") %>' /><br />
                    Name: <asp:TextBox ID="txtEditName" runat="server" Text='<%# Bind("Name") %>' /><br />
                    Age: <asp:TextBox ID="txtEditAge" runat="server" Text='<%# Bind("Age") %>' /><br />
                    Address: <asp:TextBox ID="txtEditAddress" runat="server" Text='<%# Bind("Address") %>' /><br />
                    Mobile No: <asp:TextBox ID="txtEditMobileNo" runat="server" Text='<%# Bind("MobileNo") %>' /><br />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="Update" />
                    <asp:Button ID="btnCancelEdit" runat="server" Text="Cancel" CommandName="Cancel" />
                </EditItemTemplate>
            </asp:FormView>

            <br />

            <asp:TextBox ID="txtSearch" runat="server" placeholder="Search by Name" />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
    </form>
</body>
</html>
