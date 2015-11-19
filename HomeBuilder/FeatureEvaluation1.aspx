<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FeatureEvaluation1.aspx.vb" Inherits="FeatureEvaluation1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style7 {
            width: 129px;
        }
        .auto-style21 {
            width: 242px;
        }
        .auto-style22 {
            width: 90px;
            height: 23px;
        }
        .auto-style23 {
            width: 140px;
            height: 23px;
        }
        .auto-style30 {
            width: 146px;
        }
        .auto-style32 {
            width: 128px;
            height: 23px;
        }
        .auto-style33 {
            width: 128px;
        }
        .auto-style42 {
            width: 102px;
        }
        .auto-style24 {
            width: 529px;
        }
        .auto-style43 {
            width: 529px;
            height: 30px;
        }
        .auto-style44 {
            width: 242px;
            height: 30px;
        }
        .auto-style45 {
            width: 102px;
            height: 30px;
        }
        .auto-style46 {
            width: 146px;
            height: 30px;
        }
        .auto-style47 {
            width: 128px;
            height: 30px;
        }
        .auto-style48 {
            width: 102px;
            height: 31px;
        }
        .auto-style49 {
            width: 146px;
            height: 31px;
        }
        .auto-style50 {
            width: 129px;
            height: 31px;
        }
        .auto-style51 {
            width: 102px;
            height: 42px;
        }
        .auto-style52 {
            width: 146px;
            height: 42px;
        }
        .auto-style53 {
            width: 129px;
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Floors</h2>
                </td>
                <td class="auto-style21">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlFloors" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlCarpet" runat="server">
            <table>
                <tr>
                    <td class="auto-style48">Carpet</td>
                    <td class="auto-style49"><asp:CheckBox ID="cbxCarpet" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style50">
                        <asp:RadioButtonList ID="rltCarpet" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlTile" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Tile</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxTile" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltTile" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlHardwood" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Hardwood</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxHardwood" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltHardwood" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlTileShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Tile Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxTileShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style33">
                        <asp:RadioButtonList ID="rltTileShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                   
                    
                </tr>
            </table>
        </asp:Panel>
    
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Roof Type</h2>
                </td>
                <td class="auto-style21">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlRoofType" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlAsphaltShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Asphalt Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxAsphaltShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltAsphaltShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlWoodShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Wood Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxWoodShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltWoodShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlMetalShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Metal Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxMetalShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltMetalShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlSlateShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style45">Slate Shingle</td>
                    <td class="auto-style46"><asp:CheckBox ID="cbxSlateShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style47">
                        <asp:RadioButtonList ID="rltSlateShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                   
                    
                </tr>
            </table>
        </asp:Panel>
    
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Appliances</h2>
                </td>
                <td class="auto-style21">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlAppliances" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlStandardBeige" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Standard Beige</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxStandardBeige" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltStandardBeige" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlBlack" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Black</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxBlack" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltBlack" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlStainlessSteel" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Stainless Steel</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxStainlessSteel" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltStainlessSteel" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlProfessional" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Professional Grade</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxProfessional" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style33">
                        <asp:RadioButtonList ID="rltProfessional" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                   
                    
                </tr>
            </table>
        </asp:Panel>
    
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Garage</h2>
                </td>
                <td class="auto-style21">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlGarage" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlOneCar" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">One Car</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxOneCar" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltOneCar" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlTwoCar" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Two Car</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxTwoCar" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltTwoCar" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlThreeCar" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Three Car</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxThreeCar" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltThreeCar" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Countertops</h2>
                </td>
                <td class="auto-style21">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlCountertops3" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlQuartz" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Quartz</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxQuartz" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltQuartz" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="PanelGranite" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Granite</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxGranite" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltGranite" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="PanelLaminate" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Laminate</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxLaminate" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltLaminate" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="PanelWood" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Wood</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxWood" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltWood" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="PanelMarble" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Marble</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxMarble" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style33">
                        <asp:RadioButtonList ID="rltMarble" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                   
                    
                </tr>
            </table>
        </asp:Panel>
    
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Bath</h2>
                </td>
                <td class="auto-style21">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlBath" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlBathShower" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Bath/Shower Combination</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxBathShower" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltBathShower" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlWalkinShower" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Walk-in-shower</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxWalkinShower" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltWalkinShower" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlRainfall" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Luxry rainfall shower</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxRainfall" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltRainfall" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <br />
    
        <table>
            <tr>
                <td class="auto-style43">
                    <h2>Closets</h2>
                </td>
                <td class="auto-style44">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlClosets" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlWardrobe" runat="server">
            <table>
                <tr>
                    <td class="auto-style51">Wardrobe Closet</td>
                    <td class="auto-style52"><asp:CheckBox ID="cbxWardrobe" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style53">
                        <asp:RadioButtonList ID="rltWardrobe" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlWalkinCloset" runat="server">
            <table>
                <tr>
                    <td class="auto-style48">Walk-in-closet</td>
                    <td class="auto-style49"><asp:CheckBox ID="cbxWalkinCloset" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style50">
                        <asp:RadioButtonList ID="rltWalkinCloset" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Fireplace</h2>
                </td>
                <td class="auto-style21">Rate Importance:&nbsp;
                    <asp:DropDownList ID="ddlFireplace" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="3">Very Important</asp:ListItem>
                        <asp:ListItem Value="2">Important</asp:ListItem>
                        <asp:ListItem Value="1">Not Important</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
            </tr>
        </table>
        <asp:Panel ID="pnlBrick" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Brick Fireplace</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxBrick" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltBrick" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlManufactured" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Manufactured Stone Fireplace</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxManufactured" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltManufactured" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlNatural" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Natural Stone Fireplace</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxNatural" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltNatural" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
    
    </div>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOptomize" runat="server" Font-Size="Large" Text="Optomize You Home" />
    </form>
</body>
</html>
