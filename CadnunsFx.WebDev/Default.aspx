<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CadnunsFx.WebDev.Default" %>

<%@ Register Src="~/Ucs/SqlControl.ascx" TagPrefix="uc1" TagName="SqlControl" %>
<%@ Register Src="~/Ucs/Login.ascx" TagPrefix="uc1" TagName="Login" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Panel SQL Commands</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <style>
        body{
            font-family:sans-serif;
        }
        #rptItem{
            border:solid 2px black;
            border-radius: 5px;
            margin:10px;
            padding:20px;
            width:300px;
            height:100px;
            background-color:#93ef6c;
            box-shadow: 2px 5px 5px grey;
            display:inline-block;
        }
        #LoginForm{
            max-width: 500px;
            padding:15px;
            background-color: #7483dd;            
            border-radius: 5px;
            box-shadow: 2px 5px 5px grey;
        }
        #LoginForm input[type=text]{
            font-size: 20pt;
            text-align :center;
        }
        #LoginForm input[type=submit]{
            font-size: 17pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Login runat="server" id="Login" />
            <asp:GridView id="gvVerRegistro" runat="server"></asp:GridView>
            <uc1:SqlControl runat="server" id="SqlControl" Title="Controle Taxa"  Description="Usado para corrigir a taxa"/>
            <uc1:SqlControl runat="server" id="SqlControl1" Title="Controle Taxa"  Description="Usado para corrigir a taxa"/>
            
                        <h1 runat="server" id="rptName"></h1>
            <asp:Repeater ID="RptPessoas" runat="server" OnItemDataBound="RptPessoas_ItemDataBound">
                <ItemTemplate>
                    <article id="rptItem">
                        <h1 runat="server" id="rptName"></h1>
                        <p runat="server" id="rptJob"></p>
                    </article>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
