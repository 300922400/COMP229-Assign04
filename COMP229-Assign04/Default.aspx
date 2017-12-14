<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COMP229_Assign04._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
    </div>
    <asp:GridView ID="game" runat="server" AutoGenerateColumns="False" >
    <columns>
        <asp:BoundField DataField="Mininame"
            HeaderText=“Model” />
        </columns>
</asp:GridView>
    <h1>Please input new models here:</h1>
    <table runat="server">
        <tr>
            <td>Name</td>
            <td>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Fraction</td>
            <td>
            <asp:TextBox ID="fraction" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Rank</td>
            <td>
            <asp:TextBox ID="rank" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Base</td>
            <td>
            <asp:TextBox ID="Base" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Size</td>
            <td>
            <asp:TextBox ID="Size" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>Deploymentzone</td>
            <td>
            <asp:TextBox ID="deploymentzone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Wound</td>
            <td>
            <asp:TextBox ID="wound" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td>Mobility</td>
            <td>
            <asp:TextBox ID="Mobility" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Willpower</td>
            <td>
            <asp:TextBox ID="willpower" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td>Resilliance</td>
            <td>
            <asp:TextBox ID="resilliance" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>Wounds</td>
            <td>
            <asp:TextBox ID="wounds" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="addModel" runat="server" Text="ADD" OnClick="addModel_Click" />
            </td>
        </tr>
    </table>
   
</asp:Content>
