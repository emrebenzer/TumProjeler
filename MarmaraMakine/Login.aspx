<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MarmaraMakine.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/960.css" rel="stylesheet" type="text/css" media="all" />
<link href="css/reset.css" rel="stylesheet" type="text/css" media="all" />
<link href="css/text.css" rel="stylesheet" type="text/css" media="all" />
<link href="css/login.css" rel="stylesheet" type="text/css" media="all" />

</head>
<body>
    <form id="form1" runat="server">
    <div class="container_16">
  <div class="grid_6 prefix_5 suffix_5">
   	  <h1>Marmara Makina Yönetim Paneli Girişi</h1>
    	<div id="login">
                
                    <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                        <tr>
                            <td>
                                <table cellpadding="0">

                                    <tr>
                                        
                                        <td>
                                            <label><strong>Kullanıcı Adı</strong></label>
                                            <asp:TextBox ID="UserName" runat="server" CssClass="inputText"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                                ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        
                                        <td>
                                        <label><strong>Şifre</strong></label>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="inputText"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                ControlToValidate="Password" ErrorMessage="Şifre girmelisiniz." 
                                                ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" style="color:Red;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Giriş" 
                                                ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
               



		  <br clear="all" />
    	</div>
        <div id="forgot">
        <a href="#" class="forgotlink"><span>Marmara Makina Kalıp - Silivri - 2013</span></a></div>
  </div>
</div>
<br clear="all" />
    </form>
</body>
</html>
