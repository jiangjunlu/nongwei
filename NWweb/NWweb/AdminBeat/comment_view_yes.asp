﻿<%@ LANGUAGE=VBScript CodePage=65001%>
<% response.charset="utf-8" %>
<% session.codepage=65001 %>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!--#include file="../inc/access.asp"  -->
<!-- #include file="inc/functions.asp" -->
<!-- #include file="../inc/x_to_html/article_to_html.asp" -->

	<%
Call header()
%>


	<table cellpadding='3' cellspacing='1' border='0' class='tableBorder' align=center>
	<tr>
	  <th width="100%" height=25 class='tableHeaderText'>审核评论</th>
	
	<tr><td height="400" valign="top"  class='forumRow'><br>
	    <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="25" bgcolor="#B1CFF8"><div align="center"></div></td>
          </tr>
          <tr>
            <td height="100">
			<%page=request.querystring("page")
			act=request.querystring("act")
			keywords=request.querystring("keywords")
			article_id=cint(request.querystring("id"))
			set rs=server.createobject("adodb.recordset")
sql="select id,view_yes,article_id from web_article_comment where id="&article_id&""
rs.open(sql),cn,1,3
a_id=rs("article_id")
if rs("view_yes")=0 then
rs("view_yes")=1
else
rs("view_yes")=0
end if
rs.update
rs.close
set rs=nothing
 '生成文章静态页
call article_to_html(a_id)
response.Write "<script language='javascript'>alert('修改成功！');location.href='comment_list.asp?page="&page&"&act="&act&"&keywords="&keywords&"';</script>"
			%></td>
          </tr>
        </table>
	    </td>
	</tr>
	</table>


<%
Call DbconnEnd()
 %>