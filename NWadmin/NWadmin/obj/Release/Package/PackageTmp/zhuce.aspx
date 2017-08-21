<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zhuce.aspx.cs" Inherits="NWadmin.zhuce" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/templatemo-style.css" rel="stylesheet">
    <link href="css/mode.css" rel="stylesheet" />
    <script src="Scripts/json2.js"></script>
    <script type="text/javascript" src="ckeditor/ckeditor.js"></script>
    <script>
        var s;
        function checkname()
        {
            var name = document.getElementById("name").value;
            var xmlhttp;
            if (window.XMLHttpRequest) { // code for IE7+, Firefox, Chrome, Opera, Safari
                xmlhttp = new XMLHttpRequest();
            } else { // code for IE6, IE5
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            xmlhttp.open("get", "user/check.aspx?time=" + Date.now.toString() + "&name=" + name, false);
            xmlhttp.send(null);
            s=xmlhttp.responseText;
            
            if (s=="0")
            {
                document.getElementById("checkUserName").style.color="green";
                document.getElementById("checkUserName").innerHTML = "用户名可用";
            }
            else{
                document.getElementById("checkUserName").style.color="red";
                document.getElementById("checkUserName").innerHTML = "该用户名已存在";
            }
        }
        function check()
        {
            if (document.getElementById("password").value == document.getElementById("repassword").value) {
                tijiao();
            }
            else {
                alert("两次输入的密码不一致！");
            }
        }
        function clear()
        {
            alert("请如实填写个人信息！");
            document.getElementById("name").value = "";
            document.getElementById("realname").value = "";
            document.getElementById("phone").value = "";
            document.getElementById("password").value = "";
            document.getElementById("repassword").value = "";
        }
        function c() {
            window.location = "Login.aspx";
        }
        function tijiao()
        {
            var name = document.getElementById("name").value;
            var realname = document.getElementById("realname").value;
            var phone = document.getElementById("phone").value;
            var pass = document.getElementById("password").value;
            var repassword = document.getElementById("repassword").value;
            var FileController = "user/insertuser.aspx";                    // 接收上传文件的后台地址
            var form = new FormData();
            form.append("name", name);
            form.append("realname", realname);
            form.append("phone", phone);
            form.append("pass", pass);// 可以增加表单数据
            // XMLHttpRequest 对象

            var xhr = new XMLHttpRequest();
            if (window.XMLHttpRequest) { // code for IE7+, Firefox, Chrome, Opera, Safari
                xhr = new XMLHttpRequest();
            }
            else { // code for IE6, IE5
                xhr = new ActiveXObject("Microsoft.XMLHTTP");
            }
            xhr.open("post", FileController, true);


            xhr.onload = function () {
                alert("注册成功!");
                window.location = "Login.aspx";
            };
            xhr.send(form);
        }
    </script>
</head>
<body onload="clear()">
    <div class="templatemo-content-container" id="update" style="display: block; height: 100%; position: absolute; top: 0px; left: 0px">
        <div class="templatemo-content-widget no-padding">
            <div class="panel panel-default table-responsive">
                <table class='tableBorder table table-striped table-bordered templatemo-user-table' align=center>
                    <img src="./images/close.png" onclick="c()" style="float:right;height:40px;width:40px" />
                    <tr>
                        <th class='tableHeaderText green-bg white-text' colspan=2 height=25>用户注册</th>
                        </tr>
                    <tr>
                        <td height=23 colspan="2" class='forumRow'>
                            <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                                </td>
                    </tr>
                    <tr>
                        <td height="10">&nbsp;</td>
                    </tr>
                </table>
                </td>
                </tr>
                <tr>
                    <td><div><p style="float:left;padding-left:225px;position:relative">用户名 (必填)</p><p style="float:right;" id="checkUserName"></p></div></td>
                    <td class='forumRow'>
                        <div class="form-group">
                            <input name='a_title' type='text' id='name' class="form-control" onblur="checkname()">
                        </div>
                    </td>
                </tr>
                 <tr>
                    <td>真实姓名 (必填) </td>
                    <td class='forumRow'>
                        <div class="form-group">
                            <input name='a_title' type='text' id='realname' class="form-control">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>联系电话 (必填) </td>
                    <td class='forumRow'>
                        <div class="form-group">
                            <input name='a_title' type='text' id='phone' class="form-control">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>密码 (必填) </td>
                    <td class='forumRow'>
                        <div class="form-group">
                            <input name='a_title' type='password' id='password' class="form-control">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>确认密码 (必填) </td>
                    <td class='forumRow'>
                        <div class="form-group">
                            <input name='a_title' type='password' id='repassword' class="form-control">
                        </div>
                    </td>
                </tr>
                
           <%-- <tr>
                <td class='forumRow' height=23>注册日期</td>
                <td class='forumRow'>
                    <div class="form-group">
                        <input type='text' name='a_key' class="form-control" id="a_keywords"readonly="readonly">
                    </div>
                </td>
            </tr>--%>
            <%--<tr>
                <td class='forumRow' height=23>用户描述 (必填) </td>
                <td class='forumRow'>
                    <div class="form-group">
                        <textarea name="a_content" id="a_content" style=" width:100%; height:100px; " class="ckeditor"></textarea>
                    </div>
                </td>
            </tr>--%>
            <%--<tr>
                <td class='forumRowHighLight' height=23>管理员</td>
                <td class='forumRowHighLight'>
                    <span class="forumRow">
                        <div class="form-group">
                            <input name='a_author' type='text' id='a_author' value="" size='40' class="form-control" readonly="true">
                        </div>
                </td>
            </tr>--%>
            <tr>
                <td height="50" colspan=2 class='forumRow'>
                    <div align="center">
                        <div class="form-group">
                            <button class="templatemo-blue-button" onclick="check()">提交</button>
                        </div>
                    </div>
                </td>
            </tr>
        </div>
    </div>
</body>
</html>
