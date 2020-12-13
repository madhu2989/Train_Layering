<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewbookguest.aspx.cs" Inherits="Train_UI.viewbookguest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView5" runat="server"></asp:GridView>
    <table>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
