<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewbookinglist.aspx.cs" Inherits="Train_UI.viewbookinglist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
           <%-- <asp:BoundField DataField="BookingId" HeaderText="Booking Id" />
            <asp:BoundField DataField="TrainId" HeaderText="Train Id" />
            <asp:BoundField DataField="UserName" HeaderText="Passenger name" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="contactNo" HeaderText="Contact No" />
        <asp:BoundField DataField="NoOfTicket" HeaderText="No of tickets" />
        <asp:BoundField DataField="TicketAmount" HeaderText="Ticket Amount" />--%>
             <asp:TemplateField>
                    <ItemTemplate>
                        
                        <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandArgument='<%#Eval("BookingId") %>' 
                            CommandName="cmdDelete"  OnClientClick='confirm("Are you sure you want to delete?")'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
</asp:Content>
