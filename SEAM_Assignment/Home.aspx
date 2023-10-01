<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SEAM_Assignment.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/style.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <!-- about section -->
    <div class="container-fluid p-0 pb-5 position-relative">
        <!-- Add the gray rectangle and content here -->
        <div class="position-relative top-0 start-0 w-100 h-100 d-flex align-items-center with-background">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-12 col-lg-11 text-center">
                        <!-- Gray Rectangle -->
                        <div class="gray-rectangle">
                            <h1 class="display-5 text-white mb-4 font-weight-bold">Welcome to Faculty of Computing and Information Technology (FOCS)</h1>
                            <p class="fs-5 fw-medium text-white mb-4 pb-2">The Faculty of Computing and Information Technology (FOCS) at Tunku Abdul Rahman University of Management and Technology (TAR UMT) is dedicated to consistently producing high-caliber computing graduates who are in high demand. Our impressive track record of producing successful digital tech graduates has earned us recognition from the Malaysia Digital Economy Corporation (MDEC) as the preferred digital tech education provider. </p>
                            <a href="/ProgrammeModule/Programmes.aspx" class="btn btn-light py-md-3 px-md-5">Apply Now</a>
                            <br />
                            <br />
                            <asp:Label runat="server" Text="Your IP Address: " ForeColor="white"></asp:Label>
                            <asp:Label ID="lblUserIP" runat="server" Text="Label" ForeColor="white"></asp:Label>
                        </div>
                        <!-- End Gray Rectangle -->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- end about section -->

    <script src="https://cdn.botpress.cloud/webchat/v1/inject.js"></script>
    <script src="https://mediafiles.botpress.cloud/6901f4c9-8bbb-4603-96b7-792dc0cec4ab/webchat/config.js" defer></script>

</asp:Content>


