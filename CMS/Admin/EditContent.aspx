<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditContent.aspx.cs" Inherits="CMS.Admin.EditContent" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/packages/TinyMCE.4.1.0/content/scripts/tinymce/tinymce.min.js"></script>
    <script type="text/javascript">
        tinyMCE.init({
            language: "ru",
            plugins: "link image media emoticons code",
            toolbar: "bold italic underline link anchor image media code",
            menu: " ",
            mode: "textareas"
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    Редактирование контента
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="CreateEditContent">
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
                <asp:TextBox ID="TextBoxTitle" runat="server" />
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
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelText" runat="server" Text="Текст" />
            </td>
            <td>
                <asp:TextBox ID="TextBoxText" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Button ID="ButtonSaveContent" runat="server" Text="Сохранить" OnClick="ButtonSaveContent_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SideBar" runat="server">
</asp:Content>
