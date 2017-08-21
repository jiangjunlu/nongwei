<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NWadmin.Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title></title>
    <style type="text/css">
    .b1,
    .b2,
    .b3,
    .b4,
    .b1b,
    .b2b,
    .b3b,
    .b4b,
    .b {
        display: block;
        overflow: hidden;
    }

    .b1,
    .b2,
    .b3,
    .b1b,
    .b2b,
    .b3b {
        height: 1px;
    }

    .b2,
    .b3,
    .b4,
    .b2b,
    .b3b,
    .b4b,
    .b {
        border-left: 1px solid #999;
        border-right: 1px solid #999;
    }

    .b1,
    .b1b {
        margin: 0 5px;
        background: #999;
    }

    .b2,
    .b2b {
        margin: 0 2px;
        border-width: 2px;
    }

    .b3,
    .b3b {
        margin: 0 2px;
    }

    .b4,
    .b4b {
        height: 2px;
        margin: 0 1px;
    }

    .d1 {
        background: #e3e4bd;
    }

    .k {
        height: 200px;
    }
</style>
</head>


<body>
        <div style="position: absolute;width: 100%;text-align:center ">

            <img src="images/19.jpg"  style="width: 100%; height: 100%;" />
        </div>
    <div>
        <div style="position: relative; top: 200px; margin-left: 30%; margin-right: 30%;" align="center">
            <b class="b1"></b><b class="b2 d1"></b><b class="b3 d1"></b><b class="b4 d1"></b>
            <div class="b d1 k" style="padding-top: 15%;">
                <form runat="server"  method="get">
                    <p  style="margin-right: 20px;padding-left: 10px; font-style: 微软雅黑; ">用户名<input  runat="server" type="text" name="fname" id="zh" style="padding-left: 10px; font-style: 微软雅黑; color: #c3c3c3;" /></p>
                    <p  style="margin-right: 20px;padding-left: 10px; font-style: 微软雅黑; ">密  码<input runat="server" type="password" name="lname" id="mm" style="padding-left: 10px; font-style: 微软雅黑; color: #c3c3c3;" /></p>
                    <button runat="server" id="dl">登 陆</button>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <button runat="server" id="zc">注 册</button>
                </form>
            </div>
            <b class="b4b d1"></b><b class="b3b d1"></b><b class="b2b d1"></b><b class="b1b"></b>
        </div>
    </div>
    </div>
</body>
</html>

