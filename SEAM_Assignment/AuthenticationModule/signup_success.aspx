<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup_success.aspx.cs" Inherits="SEAM_Assignment.AuthenticationModule.signup_succes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="/css/enrolment.css">
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: flex; justify-content: center; align-items: center; height: 100vh; text-align: center; background-color: #eeeeee;">
            <section id="secMessage">
                <div>
                    <img src="/image/accept.png" alt="cover">
                </div>
                <div style="margin-top: 20px;">
                    <asp:Label ID="lblMessage" runat="server" Text="You have registered successfully!"></asp:Label>
                </div>
                <div style="margin-top: 25px;">
                    <asp:Button ID="btnLogin" runat="server" Text="Back to login page" CssClass="btnHome" OnClick="btnLogin_Click" />
                </div>
            </section>
        </div>
    </form>
</body>
</html>
