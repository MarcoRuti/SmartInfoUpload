<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SmartInfoUpload.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
	<link rel="stylesheet" type="text/css" href="stile1.css" />

</head>
<body>
    <form id="upload" runat="server">
        <div class="pre_contenitore">
			<p>Login</p>
		</div>
		<div class="contenitore">
			
				<br/>
				<p>Inserisci le tue credenziali</p>
					<br/>
					<p>
						<label>Username</label>
						<br/><br/>
						<asp:TextBox id="username" type="text" placeholder="Username..." runat="server" />
					</p>
					<br/>	
					<p>
						<label>Password</label>
						<br/><br/>
						<asp:TextBox id="password" type="password" placeholder="Password..." runat="server" />
					</p>
					<br/><br/>
					<p>
				        <asp:Button id ="submitButton" Text="Login" runat="server" OnClick="submitButton_Click" class="mybtn" />
					</p>			
		</div>
      </form>
</body>
</html>
