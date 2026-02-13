﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmp.aspx.cs" Inherits="WebForms.AddEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            

           Name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />


            Salary&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
            <br />
            <br />
            
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />

            

        </div>
    </form>
</body>
</html>