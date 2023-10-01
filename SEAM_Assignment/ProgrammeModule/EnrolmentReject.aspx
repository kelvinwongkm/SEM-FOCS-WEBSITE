<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrolmentReject.aspx.cs" Inherits="SEAM_Assignment.ProgrammeModule.EnrolmentReject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="/css/enrolment.css">
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: flex; justify-content: center; align-items: center; height: 100vh; text-align: center; background-color: #eeeeee;">
            <section id="secMessage">
                <div>
                    <img src="/image/reject.png" alt="cover">
                </div>
                <div style="margin-top: 20px;">
                    <asp:Label ID="lblMessage" runat="server" Text="Your enrolment is rejected!"></asp:Label>
                </div>
                <div style="margin-top: 20px;">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </div>
                <div style="margin-top: 25px;">
                    <asp:Button ID="btnHome" runat="server" Text="Back to Homepage" CssClass="btnHome" OnClick="btnHome_Click" />
                </div>
            </section>
        </div>
    </form>
</body>
</html>