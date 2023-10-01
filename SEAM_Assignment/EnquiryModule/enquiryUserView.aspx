<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="enquiryUserView.aspx.cs" Inherits="SEAM_Assignment.EnquiryModule.enquiryUserView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/enquiry_style.css" rel="stylesheet" />
    <link href="/css/style.css" rel="stylesheet" />

    <style>
        /* Create a flex container for the labels */
        .label-container {
            display: flex;
            justify-content: space-between; /* Pushes the labels to each end of the container */
        }

        /* Style for the "Handled by" label */
        #handledbylbl {
            order: 1; /* Specify the order of this label within the flex container */
        }

        /* Style for the "Replied on" label */
        #replyTimelbl {
            order: 2; /* Specify the order of this label within the flex container */
        }

        .txt {
            width: 60%;
            border: 1px solid #000;
            border-radius: 10px;
            padding: 15px 0 25px 20px;
        }

        .ttl {
            font-size: 20px;
        }

        @media (max-width: 1000px) {
            .txt {
                width: 90%;
            }
        }
    </style>
    <div class="title-img-bar">
        <div class="title">Enquiry</div>
        <!--Change to ur page title-->
    </div>

    <div class="whole-content">
        <div style="display: inline-block;">
            <img src="../image/backIcon.png" style="cursor: pointer;" onclick="javascript:history.go(-1);return false;" />&nbsp;
       
        </div>

        <div style="text-align: right; margin-top: 20px;">
            Submitted on:
           
            <asp:Label ID="utimeLbl" runat="server" Style="display: inline-block;"></asp:Label>

        </div>
        <div class="container" style="margin-top: 30px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Enquiry ID:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqIDulbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Enquiry Status:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqStatusulbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Enquiry Subject:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqSubjectulbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Description:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqDesculbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="container" style="margin-top: 50px;">
            <div class="row">
                <div class="col-md-6 col-lg-3">
                    <p class="ttl"><strong>Reply:&nbsp;</strong></p>
                </div>
                <div class="txt">
                    <asp:Label ID="enqReplyulbl" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <br />
        <br />
        <div class="label-container">
            <asp:Label ID="handledbylbl" runat="server"></asp:Label>
            <asp:Label ID="replyTimelbl" runat="server"></asp:Label>

        </div>


    </div>
</asp:Content>
