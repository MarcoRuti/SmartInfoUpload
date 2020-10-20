<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SmartInfoUpload.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>HomePage</title>
    <link rel="stylesheet" type="text/css" href="stile1.css" />
   
</head>
<body>

    <form id="Form1" method="post" enctype="multipart/form-data" runat="server">
        <div class="pre_contenitore">
			<p>Homepage</p>
		</div>
        <div class="contenitore">
            <br/><br/>
            <p>Scegli un file da caricare...</p>
            <br/>
			<p>
                <input type="file" id="File_UP" name="File_UP" runat="server"/>
            </p>

            <p>
                <asp:button type="submit" id="SubmitHome" text="Upload" onClick="SubmitHome_Click" runat="server"/>
                <br/><br/><br/><br/><br/>
                <br/><br/><br/><br/><br/>
                 
                <asp:button type="logout" id="Esc" text="Logout" onClick="LogoutHome_Click" runat="server"  class="mybtn"/>
            </p>	
		</div>
        <p>
            
        </p>
    </form>
</body>
</html>
