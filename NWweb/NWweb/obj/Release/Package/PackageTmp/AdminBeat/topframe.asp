﻿<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<!-- #include file="../inc/access.asp" -->
<!-- #include file="inc/functions.asp" -->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" href="css/common.css" type="text/css" />
<title>海纳企业网站管理系统</title>
<script language=JavaScript>
function logout(){
	if (confirm("您确定要退出后台管理系统吗？"))
	top.location = "logout.asp";
	return false;
}
</script>

</head>

<body>
<div class="header_content">
     <div class="logo"><a href="http://www.hitux.com/" target="_blank"><img src="/images/cms_logo.png" alt="海纳企业网站管理系统" width="150"/></a></div>
	 <div class="right_nav">
	    <div class="text_left"><ul class="nav_list"><li><a href="http://www.hitux.com/Themes" target="_blank">使用更多商业模板...<img src="images/hot.gif" /></a></li></ul>
	    </div>
		<div class="text_right"><ul class="nav_return"><li><img src="images/return.gif" width="13" height="21" />&nbsp; <a href="start.asp" target="manFrame">后台首页</a> | </li>
		<li> <a href="/" target="_blank">前台首页</a> | </li>
		<li> <a href="http://www.hitux.com/Themes" target="_blank">商业模板</a> | </li>
		<li> <a href="#" target="_self" onClick="logout();">退出登录</a>&nbsp;&nbsp;&nbsp;&nbsp;</li>
		</ul>
		</div>
	 </div>
</div>
</body>
</html>
