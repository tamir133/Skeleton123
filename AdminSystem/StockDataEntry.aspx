<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" Text="StockID"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server" style="margin-left: 50px" Width="216px"></asp:TextBox>
        <br />
        <asp:Label ID="lblStockName" runat="server" Text="StockName" width="64px"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" style="margin-left: 50px" width="218px"></asp:TextBox>
        <br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="StockQuantity" width="64px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" style="margin-left: 50px" width="218px"></asp:TextBox>
        <br />
        <asp:Label ID="lblTotalSold" runat="server" Text="TotalSold" width="64px"></asp:Label>
        <asp:TextBox ID="txtTotalSold" runat="server" style="margin-left: 50px" width="218px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded" width="64px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 50px" width="218px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="64px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 50px" width="218px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkAvailable" runat="server" OnCheckedChanged="chkAvailable_CheckedChanged" Text="Available" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
