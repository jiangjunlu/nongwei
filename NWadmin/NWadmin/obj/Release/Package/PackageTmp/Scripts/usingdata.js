function deletedata(obj) {
    if (confirm("你确定删除吗？")) {
        var xmlhttp;
        if (window.XMLHttpRequest) { // code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        } else { // code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }

        xmlhttp.open("get", "deleteyaowen.aspx?id=" + obj.parentNode.parentNode.getElementsByTagName('td')[0].innerHTML, false);
        xmlhttp.send(null);
        alert("该条目已删除");
        location.replace(location.href);
    }
    else {
    }
}