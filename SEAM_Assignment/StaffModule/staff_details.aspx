<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="staff_details.aspx.cs" Inherits="SEAM_Assignment.StaffModule.staff_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/style.css" rel="stylesheet" type="text/css" />
    <link href="/css/staff.css" rel="stylesheet" type="text/css" />
    <link href="/css/bootstrap.css" rel="stylesheet" type="text/css" />

    <!-- title image bar-->
    <div class="title-img-bar">
        <div class="title">Our Team</div>
        <!--Change to our page title-->
    </div>

    <!-- content section -->
    <div class="Staff_Details-Content">
        <div class="staff_details_container">
            <div class="staff_image">
                <asp:Image ID="Image1" runat="server" CssClass="staff-image" />
            </div>

            <div class="staff_details">
                <div class="staffName">
                    <asp:Label ID="lblStaffName" runat="server" CssClass="staff-name" Text=""></asp:Label>
                </div>
                <br>
                <div class="staffPosition">
                    <asp:Label ID="lblStaffPosition" runat="server" CssClass="staff-position" Text=""></asp:Label>
                </div>
                <br>
                <div class="staffDivision">
                    <p class="staff-title"><b>Division</b></p>
                    <asp:Label ID="lblStaffDivision" runat="server" CssClass="staff-label" Text=""></asp:Label>
                </div>
                <br>
                <div class="staffEmail">
                    <p class="staff-title">
                        <img src="../image/icon_email.png" alt="Email Icon" style="vertical-align: middle; margin-right: 5px;" />
                        <b style="vertical-align: middle;">Email</b>
                    </p>
                    <asp:Label ID="lblStaffEmail" runat="server" CssClass="staff-label" Text=""></asp:Label>
                </div>
                <br>
                <div class="staffQualification">
                    <p class="staff-title"><b>Qualification</b></p>
                    <asp:Label ID="lblStaffQualification" runat="server" CssClass="staff-label" Text=""></asp:Label>
                </div>
                <br>
            </div>
        </div>
    </div>



</asp:Content>
