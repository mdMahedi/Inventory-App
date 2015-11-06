<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="InventoryApp.Product.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #productName {
        }
        #unitPrice {
        }
        #quantity {
        }
        .auto-style3 {
            width: 147px;
        }
        .auto-style4 {
            width: 233px;
        }
        .auto-style5 {
            width: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divInsert">
    <table>
        <tr>
            <td colspan="2" style="text-align: center">Input Products</td>
        </tr>
        <tr>
            <td class="auto-style3">Product Name</td>
            <td class="auto-style4"><asp:TextBox ID="productName" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style3">Unit Price</td>
            <td class="auto-style4"><asp:TextBox ID="unitPrice" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style3">Quantity</td>
            <td class="auto-style4"><asp:TextBox ID="quantity" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4"><asp:Button ID="saveButton" runat="server" Text="Save" Width="109px" OnClick="saveButton_Click" /></td>
        </tr>
    </table>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
        <div id="divSelect">
            <asp:Button ID="Button1" runat="server" Text="Show All Data" OnClick="Button1_Click" /><br/>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            
            <asp:Label ID="lblAllProducts" runat="server" Text=""></asp:Label>
        </div>
        <div id="divDelete">
            <table>
                <tr>
                    <td class="auto-style5">Product Name</td>
                    <td><asp:TextBox ID="NameTextbox" runat="server" Width="198px"></asp:TextBox></td>
                    <td><asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" Width="103px" /></td>
                </tr>
            </table>
            <asp:Label ID="msgDelete" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
