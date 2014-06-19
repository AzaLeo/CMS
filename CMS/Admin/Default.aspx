<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CMS.Admin.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AdminFeaturedContent" runat="server">
    <h2>Администраторский раздел</h2>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="AdminMainContent" runat="server">
    <h3>What We Do ?</h3>
    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing</p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="AdminSideBar" runat="server">
    <h3>Навигация</h3>
    <a href="Contents.aspx">Управление контентом</a>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="FooterContent" runat="server">
    FooterContent
</asp:Content>