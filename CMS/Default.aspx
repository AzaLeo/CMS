<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CMS.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    Главная
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="RepeaterMainContent" runat="server">
        <ItemTemplate>
            <div class="content-block">
                <h2><%# Convert.ToBoolean(Eval("ShowTitle")) ? Eval("Title") : "" %></h2>
                <p><%# Eval("Text") %></p>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="SideBar" runat="server">
    <asp:Repeater ID="RepeaterSideBar" runat="server">
        <ItemTemplate>
            <div class="content-block">
                <h2><%# Convert.ToBoolean(Eval("ShowTitle")) ? Eval("Title") : "" %></h2>
                <p><%# Eval("Text") %></p>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
