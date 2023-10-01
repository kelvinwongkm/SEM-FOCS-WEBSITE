<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="SEAM_Assignment.signup" %>

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
                    <p>Sign Up</p>
                </div>

                <div>
                    <p>Name:</p>
                    <asp:TextBox ID="txt_signup_name" runat="server" Style="width: 40%; height: 40px;" placeHolder="Enter your name"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_signup_name" ErrorMessage="User name is required" ForeColor="#FF3300" Font-Size="10px"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <p>Email:</p>
                    <asp:TextBox ID="txt_signup_email" runat="server" Style="width: 40%; height: 40px;" placeHolder="Enter your email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_signup_email" ErrorMessage="Email is required" ForeColor="#FF3300" Font-Size="10px"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_signup_email" ErrorMessage="You must enter the valid email format" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Size="10px"></asp:RegularExpressionValidator>

                </div>

                <div>
                    <p>Password:</p>
                    <asp:TextBox ID="txt_signup_password" runat="server" Style="width: 40%; height: 40px;" TextMode="Password" placeHolder="Enter your password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_signup_password" ErrorMessage="Password is required" ForeColor="#FF3300" Font-Size="10px"></asp:RequiredFieldValidator>

                </div>

                <div>
                    <asp:Label ID="lbl_error_msg" runat="server"></asp:Label>
                </div>

                <asp:Button ID="btn_login_sign_up" runat="server" Text="Sign Up" OnClick="btn_login_sign_in_Click" CssClass="btnSign" />
            </div>
        </div>
    </form>
</body>
</html>
