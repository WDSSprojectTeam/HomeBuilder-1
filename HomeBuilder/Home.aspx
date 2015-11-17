<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
       WELCOME!
   </h1>

    <h3>Where would you like to start?</h3>
    
    <asp:Button ID="btnBuildHome" runat="server" Text="Build New Home" Height="50px" Width="300px" />
    &nbsp

    </asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="SecondContent" runat="server">
    &nbsp

  <section>
               
        <asp:DropDownList ID="ddlScenariosSaved" runat="server"></asp:DropDownList>
         <asp:Button ID="btnLoadScenario" runat="server" Text="Load Saved Home" />
      
      <asp:GridView ID="gvwScenarios" runat="server"></asp:GridView>
    <asp:Button ID="btnCompare" runat="server" Text="Compare Selected" /> 

       
               
        </section>
     &nbsp
    <section>
       
        <asp:DropDownList ID="ddlTemplates" runat="server"></asp:DropDownList>
         <asp:Button ID="btnLoadTemplate" runat="server" Text="Load Template" />
   
     <asp:GridView ID="gvwTemplates" runat="server"></asp:GridView>
    <asp:Button ID="btnEditTemplate" runat="server" Text="Start From Template" />
    
        
    </section>

     
 
 


</asp:Content>
