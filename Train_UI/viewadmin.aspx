<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewadmin.aspx.cs" Inherits="Train_UI.viewadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="TrainId" HeaderText="Train Id" />
            <asp:BoundField DataField="TrainName" HeaderText="Train Name" />
            <asp:BoundField DataField="Source" HeaderText="Source" />
            <asp:BoundField DataField="Destination" HeaderText="Destination" />
            <asp:BoundField DataField="TicketFare" HeaderText="Ticket Fare" />
             <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEdit" runat="server" Text="edit" 
                            CommandArgument='<%#Eval("TrainId") %>' CommandName="cmdEdit"></asp:LinkButton>
                        <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandArgument='<%#Eval("TrainId") %>' 
                            CommandName="cmdDelete" OnClientClick='confirm("Are you sure you want to delete?")'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
</asp:Content>
