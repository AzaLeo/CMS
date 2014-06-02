<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditContent.aspx.cs" Inherits="CMS.Admin.EditContent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="content">
        <tr>
            <td>
                <asp:Label ID="LabelId" runat="server" Text="ID" />
            </td>
            <td>
                <asp:Label runat="server" ID="LabelIdResult" />
            </td>
        </tr>
                <tr>
            <td>
                <asp:Label ID="LabelTitle" runat="server" Text="Заголовок" />
            </td>
            <td>
                <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelPublish" runat="server" Text="Опубликовано" />
            </td>
            <td>
                <asp:CheckBox ID="CheckBoxPublish" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAccessLevel" runat="server" Text="Уровень доступа" />
            </td>
            <td>
                <asp:DropDownList ID="DropDownListAccessLevel" runat="server">
                    <asp:ListItem>Guest</asp:ListItem>
                    <asp:ListItem>User</asp:ListItem>
                    <asp:ListItem>Admin</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelShowTitle" runat="server" Text="Показать заголовок" />
            </td>
            <td>
                <asp:CheckBox ID="CheckBoxShowTitle" runat="server" />
            </td>
        </tr>
        <tr>
                        <td>
                <asp:Label ID="LabelPosition" runat="server" Text="Позиция" />
            </td>
            <td>
                <asp:DropDownList ID="DropDownListPosition" runat="server">
                    <asp:ListItem>MainContent</asp:ListItem>
                    <asp:ListItem>SideBar</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SideBar" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
