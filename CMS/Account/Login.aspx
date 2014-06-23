<%@ Page Title="Выполнить вход" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CMS.Account.Login" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <%: Title %>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <section id="loginForm">
        <h3>Используйте для входа локальную учетную запись.</h3><br />
        <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <fieldset>
                    <legend>Форма входа</legend>
                    <ul>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">Имя пользователя</asp:Label><br />
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="Поле имени пользователя заполнять обязательно." />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Пароль</asp:Label><br />
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="Поле пароля заполнять обязательно." />
                        </li>
                        <li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Запомнить меня</asp:Label>
                        </li>
                    </ul>
                    <asp:Button runat="server" CommandName="Login" Text="Выполнить вход" />
                </fieldset>
            </LayoutTemplate>
        </asp:Login><br />
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Регистрация</asp:HyperLink>
            если у вас нет учетной записи.
        </p>
    </section>

    <%--<section id="socialLoginForm">
        <h2>Используйте для входа другую службу.</h2>
        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
    </section>--%>
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
