<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="enquiryStaffReply.aspx.cs" Inherits="SEAM_Assignment.EnquiryModule.enquiryStaffReply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/enquiry_style.css" rel="stylesheet" />
    <link href="/css/style.css" rel="stylesheet" />

    <style type="text/css">
        .addEnquiry-button {
            margin-right: 10px;
            border-radius: 5px;
            padding: 10px 50px;
            border: 0;
            font-weight: bold;
        }

        .txt {
            width: 60%;
            border: 1px solid #000;
            border-radius: 10px;
            padding: 15px 0 25px 20px;
        }

        .input{
            width: 80%;
            height: 80px;
        }

        .ttl {
            font-size: 20px;
        }

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

        @media (max-width: 1200px) {
            .txt {
                width: 90%;
            }

            .input{
            width: 90%;
            height: 80px;
        }
        }
    </style>

    <script type="text/javascript">
        function showConfirmation(message) {
            var result = confirm(message);
            return result;
        }
    </script>

    <div class="title-img-bar">
        <div class="title">Enquiry - Reply Enquiry</div>
        <!--Change to ur page title-->
    </div>
    <div class="whole-content">
        <div style="display: inline-block; margin-right: 20px;">
            <img src="../image/backIcon.png" style="cursor: pointer;" onclick="javascript:history.go(-1);return false;" />&nbsp;
       
        </div>

        <div style="text-align: right;">
            Submitted on:
           
            <asp:Label ID="timeLbl" runat="server" Style="display: inline-block;"></asp:Label>
        </div>
        <div class="container" style="margin-top: 30px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Enquiry ID:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqIDlbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Enquiry Status:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqStatuslbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Enquiry Subject:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqSubjectlbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Description:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqDesclbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Reply:&nbsp;</strong></p>
                </div>
                <div style="flex-grow: 1;">
                    <asp:TextBox ID="enqReplyTxt" runat="server" TextMode="MultiLine" CssClass="input" placeholder="Enter your reply here."></asp:TextBox>
                </div>
            </div>
        </div>

        <p style="margin-top: 20px; text-align: right;">
            <asp:Button ID="enqReplyBtn" runat="server" Text="Reply" OnClientClick="return showConfirmation('Submit the reply?');" OnClick="enqReplyBtn_Click" class="addEnquiry-button" type="button" />
            <asp:Button ID="enqCancelBtn" runat="server" Text="Cancel" OnClientClick="return showConfirmation('Cancel the operation?');" OnClick="enqCancelBtn_Click" class="cancelEnquiry-button" />
        </p>
    </div>
</asp:Content>
