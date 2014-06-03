<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contents.aspx.cs" Inherits="CMS.Admin.Contents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="IsUpdateOk" runat="server"></asp:Label>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="EntityDataSourceContents">

        <ItemTemplate>
            <table class="content">
                <tr>
                    <th>ID</th>
                    <th>Заголовок</th>
                    <th>Опубликовано</th>
                    <th>Доступ</th>
                    <th>Показать заголовок</th>
                    <th>Позиция</th>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="Label1" Text='<%# Eval("ContentId")%>' />
                    </td>
                    <td>
                        <asp:HyperLink runat="server" NavigateUrl='<%# Eval("ContentId", "~/Admin/EditContent.aspx?id={0}")%>'><%# Eval("Title") %></asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="Label3" Text='<%# Convert.ToBoolean(Eval("Publish")) ? "Да" : "Нет" %>' />
                    </td>
                    <td>
                        <asp:Label runat="server" ID="Label4" Text='<%# Eval("AccessLevel") %>' />
                    </td>
                    <td>
                        <asp:Label runat="server" ID="Label5" Text='<%# Convert.ToBoolean(Eval("ShowTitle")) ? "Да" : "Нет" %>' />
                    </td>
                    <td>
                        <asp:Label runat="server" ID="Label6" Text='<%# Eval("Position") %>' />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
    <asp:EntityDataSource ID="EntityDataSourceContents" runat="server" ConnectionString="name=CMSEntities" DefaultContainerName="CMSEntities" EnableFlattening="False" EntitySetName="Contents">
    </asp:EntityDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SideBar" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
