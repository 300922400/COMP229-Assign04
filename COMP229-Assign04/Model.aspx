<%@ Page Title="Model" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Model.aspx.cs" Inherits="COMP229_Assign04.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Mininame
           </td>
            <td></td>
            <asp:Label ID="name" runat="server"></asp:Label>
        </tr>
            <tr>
            <td>Faction
           </td>
            <td></td>
            <asp:Label ID="faction" runat="server"></asp:Label>
        </tr>
         <tr>
            <td>Rank
           </td>
            <td></td>
            <asp:Label ID="rank" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>Rank
           </td>
            <td></td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>Base
           </td>
            <td></td>
            <asp:Label ID="base" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>Size
           </td>
            <td></td>
            <asp:Label ID="size" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>DeploymentZone
           </td>
            <td></td>
            <asp:Label ID="deploymentZone" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>Trait
           </td>
            <td></td>
            <asp:Label ID="trait" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>Type
           </td>
            <td></td>
            <asp:Label ID="Type" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>Defensechart
           </td>
            <td></td>
            <asp:Label ID="Defensechart" runat="server"></asp:Label>
        </tr>
         <tr>
            <td>Mobility
           </td>
            <td></td>
            <asp:Label ID="mobility" runat="server"></asp:Label>
        </tr>
         <tr>
            <td>Willpower
           </td>
            <td></td>
            <asp:Label ID="willpower" runat="server"></asp:Label>
        </tr>
         <tr>
            <td>Resiliance
           </td>
            <td></td>
            <asp:Label ID="resiliance" runat="server"></asp:Label>
        </tr>
         <tr>
            <td>Wounds
           </td>
            <td></td>
            <asp:Label ID="wound" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>Action
           </td>
            <td></td>
            <asp:Label ID="action" runat="server"></asp:Label>
        </tr>
        <tr>
            <td>SpecialAbilities
           </td>
            <td></td>
            <asp:Label ID="specialAbilities" runat="server"></asp:Label>
        </tr>
        
    </table>
            
               
    <table runat="server" align="left" style="width: 117px">
        <tr>
            <td>
                <asp:LinkButton ID="UpdateModel" runat="server" OnClick="UpdateModel_Click">UPDATE</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="DeleteModel" runat="server" Text="DELETE" OnClick="DeleteModel_Click" style="height: 26px" />
            </td>
        </tr>
    </table>
</asp:Content>
