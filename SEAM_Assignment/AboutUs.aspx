<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="SEAM_Assignment.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/aboutus.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <div class="body">
        <div class="title-img-bar">
            <div class="title">About Us</div>
        </div>

        <div class="divTop">
            <asp:Label ID="lblWelcome" runat="server" CssClass="lbl" Text="Welcome to the Faculty of Computing and Information Technology"></asp:Label>
            <p class="txt">“Pathway to a Rewarding Career in Computing and IT World”</p>
        </div>

        <div class="div">
            <div class="divLeft">
                <a href="/Home.aspx">
                    <img src="/image/logo.png" alt="Email Icon" />
                </a>
            </div>

            <div class="divRight">
                <asp:Label ID="lblAwards" runat="server" Text="Awards:" CssClass="lbl"></asp:Label>
                <ul class="point">
                    <li>Centre of Excellence for Big Data Analytics and Artificial Intelligence</li>
                    <li>Premier Digital Tech IHL status in 2017</li>
                    <li>IBM Centre of Excellence in Big Data Analytics in 2019</li>
                    <li>and many more...</li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
