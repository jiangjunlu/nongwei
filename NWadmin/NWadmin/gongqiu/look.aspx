<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="look.aspx.cs" Inherits="NWadmin.gongqiu.look" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <p style="text-align:center;"> 
          <span style="font-size:16px;"></span>
            <span style="font-size:16px;"></span>&nbsp;<asp:Label ID="title" runat="server"></asp:Label>
            <asp:Label ID="goods" runat="server"></asp:Label>
        </p>
        <p style="text-align:center;"> 
            联系人：<asp:Label ID="user" runat="server"></asp:Label>
&nbsp;&nbsp; 电话： 
            <asp:Label ID="phone" runat="server"></asp:Label>
        </p> 
       <%-- <div  style="text-align:center">
            <asp:Image ID="Image1" runat="server" Height="110px" Width="138px" />

        </div>--%>
        <p style="text-indent:2em;">  <asp:Label ID="content" runat="server"></asp:Label> </p> 
            <br />
        <br />
        <p style="float:right;position:relative;right:3%">
           审核状态： <asp:Label ID="state" runat="server" Text=""></asp:Label>
              <br />
              更改审核状态：  
            <asp:DropDownList ID="changestate" runat="server" >
                <asp:ListItem Value="0">不通过</asp:ListItem>
                <asp:ListItem Value="1">通过</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="QD"  runat="server" Text="确定" OnClick="QD_Click" />
        </p>   
    </form>
</body>
</html>

