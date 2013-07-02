<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.2.min.js" type="text/javascript"></script>
    <title>bug</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="usercontrolContent">
            &nbsp;
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                contentType: "application/json; charset=utf-8",
                url: "WebService1.asmx/GetSideCart",
                data: "{ 'showButton' : true }",
                dataType: "json",
                success: function (msg) {
                    $("#usercontrolContent").html(msg.d);
                }
            });
        });
    </script>
</body>
</html>
