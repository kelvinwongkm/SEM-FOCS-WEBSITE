<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="ProfileDefault.aspx.cs" Inherits="SEAM_Assignment.ProfileDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/profile.css" rel="stylesheet" type="text/css" />

    <div class="title-img-bar">
        <div class="title">Profile</div>
    </div>

    <div style="display: flex; padding: 80px 0; justify-content: center; align-items: center; text-align: center; background-color: #eeeeee;">
        <section id="secMessage">
            <div>
                <img src="/image/avatar.png" alt="cover" style="width: 50%;">
            </div>
            <div style="margin-top: 20px;">
                <asp:Label ID="lblMessage" runat="server" Text="Please login to your account."></asp:Label>
            </div>
            <div style="margin-top: 25px;">
                <asp:Button ID="btnHome" runat="server" Text="Go to Login Page" CssClass="btnHome" OnClick="btnHome_Click" />
            </div>
        </section>
    </div>
</asp:Content>
