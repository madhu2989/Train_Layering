<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="bookticket.aspx.cs" Inherits="Train_UI.bookticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Lab1" runat="server" Text="Label"></asp:Label>
    <table>
        <tr>
            <td>
                Passenger Name
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="enter your name"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>
                Email
            </td>
            <td>
                 <asp:TextBox ID="TextBox2" runat="server" type="email"></asp:TextBox>
                

            </td>
        </tr>
         <tr>
            <td>
                Contact No
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="enter correct mobile no"></asp:RequiredFieldValidator>
            </td>
             
        </tr>
        <tr>
            <td>
                No Of Tickets
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"  AutoPostBack="true"  OnTextChanged="TextBox4_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" 
                    ErrorMessage="enter no of tickets"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Train Name
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1"></asp:DropDownList>
            </td>
        </tr>
        
         
        <tr>
            <td>
                Ticket Price
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"  ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Back to page" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Book" Width="61px" OnClick="Button1_Click" />
            </td>

        </tr>
    </table>
</asp:Content>
