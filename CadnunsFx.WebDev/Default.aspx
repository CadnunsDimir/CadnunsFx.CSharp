﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CadnunsFx.WebDev.Default" %>

<%@ Register Src="~/Ucs/SqlControl.ascx" TagPrefix="uc1" TagName="SqlControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:SqlControl runat="server" id="SqlControl" Title="Controle Taxa"  Description="Usado para corrigir a taxa"/>
        </div>
    </form>
</body>
</html>
