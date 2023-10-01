<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="addEnquiry.aspx.cs" Inherits="SEAM_Assignment.EnquiryModule.addEnquiry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/enquiry_style.css" rel="stylesheet" />
    <link href="/css/style.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />

    <style>
        .cancelEnquiry-button {
            margin-right: 10px;
            border-radius: 5px;
            padding: 10px 50px;
            border: 0;
            font-weight: bold;
        }

        .addEnquiry-button {
            color: #ffffff;
            background-color: #22CB79;
            font-weight: bold;
            border: 1px solid;
            border-radius: 5px;
            padding: 10px 50px;
            margin-right: 10px;
        }

            .addEnquiry-button:hover {
                color: #22CB79;
                background-color: #ffffff;
            }
    </style>

    <script type="text/javascript">
        function showConfirmation(message) {
            var result = confirm(message);
            return result;
        }
    </script>

    <div class="title-img-bar">
        <div class="title">Enquiry</div>
        <!--Change to ur page title-->
    </div>

    <div class="whole-content">
        <div style="display: inline-block; margin-right: 20px;">
            <img src="../image/backIcon.png" style="cursor: pointer;" onclick="javascript:history.go(-1);return false;" />&nbsp;
       
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p style="font-size: 20px;"><strong>Enquiry Subject:&nbsp;</strong></p>
                </div>
                <div class="col-md-6 col-lg-9" style="border: 1px;">
                    <asp:TextBox ID="enqSubjectTxt" runat="server" TextMode="MultiLine" class="border-1 border-dark" Style="width: 100%;" placeholder="Enter your enquiry subject here."></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 30px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p style="font-size: 20px;"><strong>Description:&nbsp;</strong></p>
                </div>
                <div class="col-md-6 col-lg-9">
                    <asp:TextBox ID="enqDescriptionTxt" runat="server" TextMode="MultiLine" class="border-1 border-primary" Style="width: 100%; height: 180px;" placeholder="Enter your enquiry description here."></asp:TextBox>
                </div>
            </div>
        </div>

        <p style="margin-top: 30px; margin-right: 45px; text-align: right;">
            <asp:Button ID="addEnquiryBtn" runat="server" Text="Add Enquiry" OnClick="addEnquiryBtn_Click" class="addEnquiry-button" type="button" />
            <asp:Button ID="cancelBtn" runat="server" Text="Cancel" OnClick="cancelBtn_Click" class="cancelEnquiry-button" />
        </p>

    </div>
</asp:Content>
