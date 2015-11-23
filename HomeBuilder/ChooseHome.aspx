<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ChooseHome.aspx.vb" Inherits="ChooseHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

   
<%--<html>
<%--<head runat="server">
    <title></title>
    <style type="text/css">
        .gvwDishes {}
        .dvwDishes {}
    </style>
</head>--%>
<%--<body>
    <form id="form1" runat="server">
    <div>
    --%>
        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Enter your Budget:"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Font-Size="Large" Text="$"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Font-Size="Large" Height="22px" Width="120px"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Would you like to included a pool with your home?"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="298px">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
            <asp:ListItem>Maybe</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Select your home:"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvwHome" runat="server" CellPadding="4" CssClass="gvwHome" ForeColor="#333333" GridLines="None" Height="182px" PageSize="5" RowStyle-Width="150px" Width="439px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                <asp:ButtonField CommandName="TheDetails" Text="Details" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:DetailsView ID="dvwDetails" runat="server" AutoGenerateRows="False" CellPadding="4" CssClass="gvwHome" ForeColor="#333333" GridLines="None" Height="194px" Width="53%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="ModelHomeID" HeaderText="Model Home ID" />
                <asp:BoundField DataField="# of Bedrooms" HeaderText="Bedrooms" />
                <asp:BoundField DataField="# of Bathrooms" HeaderText="Bathrooms" />
                <asp:BoundField DataField="Square Footage" HeaderText="Square Footage" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        <br />
        <asp:Button ID="btnNext" runat="server" Text="Next" Width="76px" Enabled="True" />
    
<%--    </div>
    </form>
</body>
</html>--%>



</asp:Content>

