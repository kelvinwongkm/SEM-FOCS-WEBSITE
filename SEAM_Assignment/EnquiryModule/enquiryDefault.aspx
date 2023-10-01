<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="enquiryDefault.aspx.cs" Inherits="SEAM_Assignment.EnquiryModule.enquiryDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">--%>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/enquiry_style.css" rel="stylesheet" />
    <link href="/css/style.css" rel="stylesheet" type="text/css" />
    <link href="/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="/css/enrolment.css" rel="stylesheet" type="text/css" />


    <style>
    </style>
    <div class="title-img-bar">
        <div class="title">Enquiry</div>
        <!--Change to ur page title-->
    </div>

    <div style="display: flex; padding: 80px 0; justify-content: center; align-items: center; text-align: center; background-color: #eeeeee;">
        <section id="secMessage">
            <div>
                <img src="/image/avatar.png" alt="cover" style="width: 50%;">
            </div>
            <div style="margin-top: 20px;">
                <asp:Label ID="lblMessage" runat="server" Text="Please login to your account to store and view your enquiry."></asp:Label>
            </div>
            <div style="margin-top: 25px;">
                <asp:Button ID="btnHome" runat="server" Text="Go to Login Page" CssClass="btnHome" OnClick="btnHome_Click" />
            </div>
        </section>
    </div>


</asp:Content>
