<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NWadmin.Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title></title>
    <style type="text/css">
    html,body{  
  height:97%;  
  margin:0px;  
}  
      input{ margin: 0px; padding: 0px; 
font-size: 12px; font-weight: normal; }
</style>
</head>
<body>
      <div id="web_bg" style="position:absolute; width:100%;margin:0px auto; height:100%; z-index:-1"> 
<img style="position:fixed;width:1366px;height:768px" src="images/背景.png"/> 
</div>
    <div style="text-align:center;">
        <img src="images/头部.png" style="width:1200px;height:150px;padding-top:30px"/>

    </div>
    <div style="background:url(images/背景1.png) no-repeat;background-size:1000px 230px;width:1000px;height:250px;margin-top:80px;margin-left:150px">
         <form name="form" runat="server"  method="get">
        <div style="padding-left:325px;padding-top:20px">
        <img src="images/头像.png" style="width:40px;height:40px" />
        <input runat="server" name="fname" id="zh" type="text" style="clear:both;overflow:hidden;position:absolute;background:url(images/输入框.png) no-repeat;width:300px;height:40px;border:0px;font-size:20px;color:rgba(0, 0, 0, 0.82)"/>
        </div>
        <div style="padding-left:325px;padding-top:30px">
        <img src="images/密码.png" style="width:40px;height:40px" />
        <input runat="server" name="lname" id="mm" type="password" style="clear:both;overflow:hidden;position:absolute;background:url(images/输入框.png) no-repeat;width:300px;height:40px;border:0px;font-size:20px;color:rgba(0, 0, 0, 0.82)"/>
        </div>
         <div style="padding-left:325px;padding-top:30px">
        <button  runat="server" id="zc" style="background:url(images/注册.png) ;background-size:90px 40px;width:90px;height:40px;cursor:pointer;border:0px"/>
        <button  runat="server" id="dl" style="background:url(images/登录.png) ;background-size:90px 40px;width:90px;height:40px;margin-left:155px;cursor:pointer;border:0px"/>
        </div>
             </form>
        </div>
        <%--<div style="position: relative; top: 390px; margin-left: 30%; margin-right: 30%; left: 7px;" align="center">
            <b class="b1"></b><b class="b2 d1"></b><b class="b3 d1"></b><b class="b4 d1"></b>
            <div class="b d1 k" style="padding-top: 15%;">
                <form runat="server"  method="get">
                    <input  runat="server" type="text" name="fname" id="zh" style="padding-left: 10px; font-style: 微软雅黑; color: #c3c3c3;" /></p>
                    <input runat="server" type="password" name="lname" id="mm" style="padding-left: 10px; font-style: 微软雅黑; color: #c3c3c3;" /></p>
                    <button runat="server" id="dl">登 陆</button>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <button runat="server" id="zc">注 册</button>
                </form>
            </div>
            <b class="b4b d1"></b><b class="b3b d1"></b><b class="b2b d1"></b><b class="b1b"></b>
        </div>--%>
    
   <div style="text-align:center;margin-top:95px">
       <img src="images/版权.png" style="width:1200px;height:40px" />
   </div>
</body>
</html>

