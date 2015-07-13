<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="CadnunsFx.WebDev.Ucs.Login" %>

<aside id="LoginForm">
    <h1 runat="server" id="title">Login</h1>
    <p runat="server" id="description">Para acessar os controles, favor digitar seu código de acesso abixo</p>
    <asp:TextBox ID="tboxCodAcesso" runat="server" style="width:100%" placeholder="Código Acesso"></asp:TextBox>
    <asp:Label ID="statusOp" runat="server" Text="Status"></asp:Label>
    <asp:Button ID="btnAuth" runat="server" Text="Autenticar" Style="margin-top: 15px; width: 100%" OnClick="btnAuth_Click" />    
</aside>
