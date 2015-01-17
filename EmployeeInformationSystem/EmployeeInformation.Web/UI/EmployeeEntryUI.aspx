<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeEntryUI.aspx.cs" Inherits="EmployeeInformation.Web.UI.EmployeeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" Width="192px"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server" Height="21px" style="margin-top: 20px" Width="194px"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="address"></asp:Label>
            <asp:TextBox ID="addressTextBox" runat="server" Height="31px" style="margin-top: 2px" Width="185px"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Designation"></asp:Label>
        <asp:DropDownList ID="designationDropDownList" runat="server" Height="16px" Width="171px">
        </asp:DropDownList>
        <p>
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        </p>
    </form>
</body>
</html>
