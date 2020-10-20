<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="SmartInfoUpload.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign - In</title>
	<link rel="stylesheet" type="text/css" href="stile1.css" />

</head>
<body>
    <form id="signIn" runat="server">
        <div class="pre_contenitore">
			<p>Registrazione</p>
		</div>
		<div class="contenitore">
			
				<br/>
				<p>Inserisci le tue credenziali</p>
					<br/>
					<p>
						<label>Username</label>
						<br/><br/>
						<asp:TextBox id="username" placeholder="Insert a Username..." runat="server" />
					</p>
					<br/>
					<p>
						<label>Password</label>
						<br/><br/>
						<asp:TextBox id="password" type="password" placeholder="Insert a Password..." runat="server" />
					</p>
					<br/><br/>
					<p>
				        <asp:Button id ="submitSignInButton" Text="Sign-In" runat="server" OnClick="submitSignInButton_Click" class="mybtn" />
					</p>
					
		</div>
    </form>
</body>
</html>
