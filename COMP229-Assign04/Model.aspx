<%@ Page Title="Model" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Model.aspx.cs" Inherits="COMP229_Assign04.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Name
           </td>
            <td><asp:Label ID="name" runat="server"></asp:Label></td>          
        </tr>
            <tr>
            <td>Faction
           </td>
            <td><asp:Label ID="faction" runat="server"></asp:Label></td>
            
        </tr>
         <tr>
            <td>Rank
           </td>
            <td> <asp:Label ID="rank" runat="server" ></asp:Label></td>
           
        </tr>
        <tr>
            <td>Base
           </td>
            <td><asp:Label ID="Base" runat="server"></asp:Label></td>
            
        </tr>
        <tr>
            <td>Size
           </td>
            <td> <asp:Label ID="size" runat="server"></asp:Label></td>
           
        </tr>
        <tr>
            <td>DeploymentZone
           </td>
            <td> <asp:Label ID="deploymentZone" runat="server"></asp:Label></td>
           
        </tr>
        <tr>
            <td>Trait
           </td>
            <td> <asp:Label ID="trait" runat="server"></asp:Label></td>
           
        </tr>
        <tr>
            <td>Type
           </td>
            <td><asp:Label ID="Type" runat="server"></asp:Label></td>
            
        </tr>
        <tr>
            <td>Defensechart
           </td>
            <td><asp:Label ID="Defensechart" runat="server"></asp:Label></td>
            
        </tr>
         <tr>
            <td>Mobility
           </td>
            <td><asp:Label ID="mobility" runat="server"></asp:Label></td>
            
        </tr>
         <tr>
            <td>Willpower
           </td>
            <td><asp:Label ID="willpower" runat="server"></asp:Label></td>
            
        </tr>
         <tr>
            <td>Resiliance
           </td>
            <td><asp:Label ID="resiliance" runat="server"></asp:Label></td>
            
        </tr>
         <tr>
            <td>Wounds
           </td>
            <td><asp:Label ID="wound" runat="server"></asp:Label></td>
            
        </tr>
        <tr>
            <td>Action
           </td>
            <td>
            </td>
            
        </tr>
        <tr>
            <td>
           </td>
            <td>
                <asp:GridView ID="actionGrid" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField HeaderText="Name"  DataField="name"/>
                        <asp:BoundField HeaderText="Type" DataField="type" />
                        <asp:BoundField HeaderText="Rating" DataField="rating" />
                        <asp:BoundField HeaderText="Range" DataField="range" />
                    </Columns>
                </asp:GridView>
            </td>
            
        </tr>
        <tr>
            <td>SpecialAbilities
           </td>
            <td>
            </td>     
        </tr>
        <tr>
            <td>
           </td>
            <td>
                <asp:GridView ID="Grid_special" runat="server" AutoGenerateColumns="false">
                 <Columns>
                        <asp:BoundField HeaderText="Name"  DataField="name"/>
                        <asp:BoundField HeaderText="Description" DataField="description" />
                 </Columns>
                 </asp:GridView>
            </td>     
        </tr>
        <tr>
            <td>Image</td>
            <td>
                <asp:Image ID="model_image" Width="200" runat="server"/>
            </td>
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
