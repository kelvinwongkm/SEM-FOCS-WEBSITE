<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SEAM_Assignment.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/css/style.css" rel="stylesheet" />
    <link href="../css/login_style.css" rel="stylesheet" />
    <link href="/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body class="login_bg">
    <form id="form1" runat="server">

        <div class="login_container">
            <div class="login_logo">
                <a href="/Home.aspx">
                    <img src="/image/logo.png" alt="Email Icon" />
                </a>
            </div>

            <div class="user_login">
                <div class="login_title">
                    <p>Sign In</p>
                </div>

                <div>
                    <p >Email:</p>
                    <asp:TextBox ID="txt_login_email" runat="server" Style="width: 40%; height: 40px;" placeHolder="Enter your email"></asp:TextBox>
                </div>

                <div>
                    <p>Password:</p>
                    <asp:TextBox ID="txt_login_password" runat="server" Style="width: 40%; height: 40px;" TextMode="Password" placeHolder="Enter your password"></asp:TextBox>
                </div>

                <div>
                    <asp:Label class="lbl_error_msg" ID="lbl_error_msg" runat="server"></asp:Label>
                </div>

                <asp:Button ID="btn_login_sign_in" runat="server" Text="Sign In" OnClick="btn_login_sign_in_Click" CssClass="btnSign"></asp:Button>

                <div class="create_acc_container" style="width: 40%; margin-top: 40px; margin-left: 10px;">
                    <a style="color: #575757; text-decoration: underline; font-weight: 500" href="signup.aspx">Create Account</a>
                </div>

            </div>
        </div>
    </form>
</body>
</html>


