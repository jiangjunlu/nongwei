﻿<%@ LANGUAGE=VBScript CodePage=65001%>
<% response.charset="utf-8" %>
<% session.codepage=65001 %><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="X-UA-Compatible" content="IE=7">
<meta http-equiv="Content-Type" content="text/html; charset=uft-8" />
<!-- #include file="../../inc/AntiAttack.asp" -->
<!-- #include file="../../inc/conn.asp" -->
<!-- #include file="../../inc/en_web_config.asp" -->
<!-- #include file="../../inc/html_clear.asp" -->
<%
search_q=request.querystring("q")
%>
<title>Search<%=search_q%>_HituxCMS V2.1 English 0020</title>
<link href="/css/HituxCMSBigRed/en_inner.css" rel="stylesheet" type="text/css" />
<link href="/css/HituxCMSBigRed/en_common.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/en_functions.js"></script>
<script type="text/javascript" src="/images/iepng/iepngfix_tilebg.js"></script>
<script type="text/javascript">
window.onerror=function(){return true;}
</script>
</head>

<body>
<%
keywords=split(search_q," ")
c=ubound(keywords)
for i=0 to c
if i=0 then
search_sql1=search_sql1&"where  ( [title] like '%"&keywords(i)&"%'"
keywords_all=keywords(i)
else
search_sql1=search_sql1&" or   [title] like '%"&keywords(i)&"%'"
keywords_all=keywords_all&"+"&keywords(i)
end if
next

s_sql="select [title],[content],[file_path],[time],ArticleType from [en_article] "&search_sql1&" )  and view_yes=1 order by [time] desc"
%>
<div id="wrapper">

<!--head start-->
<div id="head">

<!--top start -->
<div class="top">
<div class="TopInfo"><div class="link">Language Selection: <a  href="/">Chinese</a> | <a href="/English">English</a></div>
</div>
<div class="clearfix"></div>
<div class="TopLogo">
<div class="logo"><a href="/"><img src="/images/up_images/logo.png" alt="HituxCMS V2.1 English 0020"></a></div>
<div class="tel">
<p class="telW">HOTLINE</p>
<p class="telN">086-400-800-888</p>
</div>
</div>

</div>
<!--top end-->

<!--nav start-->
<div id="NavLink">
<div class="NavBG">
<!--Head Menu Start-->
<ul id='sddm'><li class='CurrentLi'><a href='/English'>Home</a></li> <li><a href='/English/About/' onmouseover=mopen('m2') onmouseout='mclosetime()'>About</a> <div id='m2' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'><a href='/English/About/'>Introduction</a> <a href='/English/About/Team'>Company Team</a> <a href='/English/About/Culture'>Company Culture</a> <a href='/English/About/Business'>Company Business</a> <a href='/English/About/Environment'>Enviroenment</a> </div></li> <li><a href='/English/Honor/' onmouseover=mopen('m3') onmouseout='mclosetime()'>Honor</a> <div id='m3' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'><a href='/English/Honor/2011/'>2011 Year</a> <a href='/English/Honor/2012/'>2012 Year</a> <a href='/English/Honor/2013/'>2013 Year</a> </div></li> <li><a href='/English/Product/' onmouseover=mopen('m4') onmouseout='mclosetime()'>Product</a> <div id='m4' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'><a href='/English/Product/Players'>Digital Players</a> <a href='/English/Product/NoteBook'>NoteBook</a> <a href='/English/Product/EReader'>E-Reader</a> <a href='/English/Product/Audio'>Home Audio</a> <a href='/English/Product/Navigation'>Navigation</a> <a href='/English/Product/UltraBook'>UltraBook</a> <a href='/English/Product/Tablet'>Tablet Computer</a> <a href='/English/Product/Camera'>Digital Camera</a> <a href='/English/Product/Phone'>Cell Phones</a> </div></li> <li><a href='/English/news/' onmouseover=mopen('m5') onmouseout='mclosetime()'>News</a> <div id='m5' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'><a href='/English/news/CompanyNews'>Company News</a> <a href='/English/news/IndustryNews'>Industry News</a> </div></li> <li><a href='/English/Case/' onmouseover=mopen('m6') onmouseout='mclosetime()'>Case</a> <div id='m6' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'><a href='/English/Case/Case1/'>Case 1</a> <a href='/English/Case/Case2/'>Case 2</a> </div></li> <li><a href='/English/Recruit/' onmouseover=mopen('m7') onmouseout='mclosetime()'>Recruit</a> <div id='m7' onmouseover='mcancelclosetime()' onmouseout='mclosetime()'><a href='/English/Recruit/HRInfo'>HR Information</a> <a href='/English/Recruit/Policy'>HR Policy</a> <a href='/English/Recruit/Jobs'>Jobs</a> </div></li> <li><a href='/English/contact/'>Contact</a></li> <li><a href='/English/Feedback/'>FeedBack</a></li> </ul>
<!--Head Menu End-->
</div>
<div class="clearfix"></div>
</div>
<!--nav end-->

</div>
<!--head end-->
<!--body start-->
<div id="body">
<!--focus start-->
<div id="InnerBanner">
<script src='/English/ADs/5.js' type='text/javascript'></script>
</div>
<!--foncus end-->
<div class="HeightTab clearfix"></div>
<!--inner start -->
<div class="inner">
<!--left start-->
<div class="left">
<div class="Sbox">
<div class="topic">Contact Us   </div>
<div class="txt ColorLink">
<p>Add: Zikawei District Shanghai CHINA</p>
<p>Tel: 086-021-88888888</p>
<p>Fax: 086-021-33232323</p>
<p>Website: <a href='http://www.hitux.com' target='_blank'>http://www.hitux.com</a> </p>
<p>Email: admin@company.com</p>
<p align='center'><a target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=2216935501&Site=HituxCMS&Menu=yes"><img border="0" SRC=http://wpa.qq.com/pa?p=1:2216935501:1 alt="点击这里给我发消息" align="absmiddle"></a>

<a target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=2216935501&Site=HituxCMS&Menu=yes"><img border="0" SRC=http://wpa.qq.com/pa?p=1:2216935501:1 alt="点击这里给我发消息" align="absmiddle"></a>
 </p></div>
</div>
<div class="HeightTab clearfix"></div>

<div class="Sbox">
<div class="topic">Search   </div>
<div class="SearchBar">
<form method="get" action="/English/Search/index.asp">
				<input type="text" name="q" id="search-text" size="15" onBlur="if(this.value=='') this.value='Input Keywords...';" 
onfocus="if(this.value=='Input Keywords...') this.value='';" value="Input Keywords..." /><input type="submit" id="search-submit" value=" GO " />
			</form>
</div>
</div>

</div>
<!--left end-->
<!--right start-->
<div class="right">
<div class="Position"><span>Your Position: <a href="/English">Home</a> > Search</span></div>
<div class="HeightTab clearfix"></div>
<!--main start-->
<div class="main">

<!--search content start-->
<div id="search_content" class="clearfix">

<%
if search_q<>"" then 

set rs=server.createobject("adodb.recordset")
rs.open(s_sql),cn,1,1
%>

<%'=============分页定义开始，要放在数据库打开之后
if err.number<>0 then '错误处理
response.write "数据库操作失败：" & err.description
err.clear
else
if not (rs.eof and rs.bof) then '检测记录集是否为空
r=cint(rs.RecordCount) '记录总数
rowcount = 10 '设置每一页的数据记录数，可根据实际自定义
rs.pagesize = rowcount '分页记录集每页显示记录数
maxpagecount=rs.pagecount '分页页数
page=request.querystring("page")
  if page="" then
  page=1
  end if
rs.absolutepage = page 
rcount1=0
pagestart=page-5
pageend=page+5
if pagestart<1 then
pagestart=1
end if
if pageend>maxpagecount then
pageend=maxpagecount
end if
rcount=rs.RecordCount
'=============分页定义结束%>

<!--position start-->
<div class="searchtip">Your are search '<span class="FontRed"><%=search_q%></span>',found results <span class="font_brown"><%=rcount%></span> </div>
<!--position end-->
<!--list start-->
<div class="result_list">
<div class="gray">Tips: Use space in keyowrds for more results, for example:'new product'.</div>
<dl>

<%'===========循环体开始
do while not rs.eof and rowcount%>
<%
select case rs("ArticleType")
case 1
Content_FolderName=Article_FolderName
case 2
Content_FolderName=Product_FolderName
case 3
Content_FolderName=Case_FolderName
end select
title1=left(rs("title"),30)
for i=0 to c
title1=Replace(title1, keywords(i), "<span class='FontRed'>" & keywords(i)& "</span>")
next

content1=left(nohtml(rs("content")),110)
for i=0 to c
content1=Replace(content1,keywords(i), "<span class='FontRed'>" & keywords(i)& "</span>")
next
%>
<dt ><a href='<%="/English/"&Content_FolderName&"/"&rs("file_path")%>' target='_blank' title='<%=rs("title")%>'><%=title1%></a></dt>
<dd><%=content1%>...</dd>
<dd class="font12 arial font_green line"><a href='<%="/English/"&Content_FolderName&"/"&rs("file_path")%>' target='_blank'><span class="font_green"><%=web_url&"/"&Content_FolderName&"/"&rs("file_path")%></span></a><%=year(rs("time"))%>-<%=month(rs("time"))%>-<%=day(rs("time"))%></dd>
<%
rowcount=rowcount-1 
rs.movenext
loop
 '===========循环体结束%>

</dl>
</div>
<!--list end-->

<!--page start-->
<div class="result_page clearfix">
<!--#include file="../../inc/en_page_list.asp"-->
</div>
<!--page end-->

<%
else
response.write "<div class='search_welcome'>Sorry,no results for <span class='FontRed'>"&search_q&"</span> !<p >Tips: Use space in keyowrds for more results, for example:'new product'.</p></div>"
end if
end if
end if%>
</div>
<!--search content end-->	

</div>
<!--main end-->
</div>
<!--right end-->
</div>
<!--inner end-->
</div>
<!--body end-->
<div class="HeightTab clearfix"></div>
<!--footer start-->
<div id="footer">
<div class="inner">
<div class='BottomNav'><a href="/English">HOME</a> | <a href="/English/About">ABOUT</a> | <a href="/English/Recruit">JOIN US</a>  | <a href="/English/Sitemap">SITEMAP</a> | <a href="/English/RSS">RSS</a></div>
<div class='HeightTab'></div>
<p>Copyright 2013 <a href='http://www.hitux.com' target='_blank'>www.hitux.com</a> Hitux Network Studio All Rights Reserved </p>
<p>Address: Zikawei District Shanghai CHINA Tel:086-021-88888888 Email:admin@company.com</p>
<p>Built By <a href="http://www.hitux.com/" target="_blank">HituxCMS V2.1</a> <a href="/English/rss" target="_blank"><img src="/images/rss_icon.gif"></a> <a href="/English/rss/feed.xml" target="_blank"><img src="/images/xml_icon.gif"></a></p>
</div>
</div>
<!--footer end -->


</div>
<script type="text/javascript" src="/js/ServiceCenter.js"></script>

</body>
</html>
<!--
Powered By HituxCMS ASP V2.1 
-->
