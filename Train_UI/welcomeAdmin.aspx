<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="welcomeAdmin.aspx.cs" Inherits="Train_UI.welcomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
       <table>
           <tr>
               <td>
                   <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" Width="116px" />
               </td>
           </tr>
            <tr>
               <td>
                   <asp:Button ID="Button2" runat="server" Text="view" OnClick="Button2_Click" Width="117px" />
               </td>
           </tr>
           
           <tr>
               <td>
                   <asp:Button ID="Button4" runat="server" Text="View booking list" OnClick="Button4_Click" Width="116px" />
               </td>
           </tr>
             <tr>
               <td>
                   <asp:Button ID="Button3" runat="server" Text="logout" OnClick="Button3_Click" />
               </td>
           </tr>
       </table>
    </div>
</asp:Content>
