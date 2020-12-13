<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="welcomeGuest.aspx.cs" Inherits="Train_UI.welcomeGuest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
    <table>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Book ticket" OnClick="Button1_Click" />
            </td>
        </tr>
          <tr>
            <td>
                <asp:Button ID="Button3" runat="server" Text="View trains" OnClick="Button3_Click" />
            </td>
           
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="logout" OnClick="Button2_Click" />
            </td>
           
        </tr>
    </table>
</asp:Content>
