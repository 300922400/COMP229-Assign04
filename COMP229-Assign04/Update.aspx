<%@ Page Title="Update" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="COMP229_Assign04.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <table runat="server">
         <tr>
            <td>Name
           </td>
            <td><asp:TextBox ID="nameDisplay" runat="server"></asp:TextBox></td>          
        </tr>
            <tr>
            <td>Faction
           </td>
            <td><asp:TextBox ID="factionDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
         <tr>
            <td>Rank
           </td>
            <td> <asp:TextBox ID="rankDisplay" runat="server" ></asp:TextBox></td>
           
        </tr>
        <tr>
            <td>Base
           </td>
            <td><asp:TextBox ID="BaseDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>Size
           </td>
            <td> <asp:TextBox ID="sizeDisplay" runat="server"></asp:TextBox></td>
           
        </tr>
        <tr>
            <td>DeploymentZone
           </td>
            <td> <asp:TextBox ID="deploymentZoneDisplay" runat="server"></asp:TextBox></td>
           
        </tr>
        <tr>
            <td>Trait
           </td>
            <td> <asp:TextBox ID="traitDisplay" runat="server"></asp:TextBox></td>
           
        </tr>
        <tr>
            <td>Type
           </td>
            <td><asp:TextBox ID="TypeDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>Defensechart
           </td>
            <td><asp:TextBox ID="DefensechartDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
         <tr>
            <td>Mobility
           </td>
            <td><asp:TextBox ID="mobilityDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
         <tr>
            <td>Willpower
           </td>
            <td><asp:TextBox ID="willpowerDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
         <tr>
            <td>Resiliance
           </td>
            <td><asp:TextBox ID="resilianceDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
         <tr>
            <td>Wounds
           </td>
            <td><asp:TextBox ID="woundDisplay" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Update" runat="server" Text="UPDATE" OnClick="Update_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
