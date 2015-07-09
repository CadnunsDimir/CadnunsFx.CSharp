<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SqlControl.ascx.cs" Inherits="CadnunsFx.WebDev.Ucs.SqlControl" %>
<article 
    style="width:300px;
           height:400px;
           padding:15px;
           margin:10px;
           display:inline-block;
           border:2px solid black">

    <h1 runat="server" id="title"></h1>
    <p runat="server" id="description"></p>
    <asp:TextBox ID="tboxCodCeden" runat="server" style="margin-top:15px; width:100%" placeholder="Número Cedente"></asp:TextBox>
    <asp:Button ID="btnVerifRegistro" runat="server" Text="Verificar Registro" style="margin-top:15px; width:100%" OnClick="btnVerifRegistro_Click"/>    
    <asp:Button ID="btnExecAction" runat="server" Enabled="false" Text="Executar Ação" style="margin-top:15px; width:100%" OnClick="btnExecAction_Click"/>
</article>