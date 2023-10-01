<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="ProgramInfo.aspx.cs" Inherits="SEAM_Assignment.ProgrammeModule.ProgramInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/style.css" rel="stylesheet" />
    <link href="/css/program.css" rel="stylesheet" />
    <link href="/css/responsive.css" rel="stylesheet" />
    <link href="/css/bootstrap.css" rel="stylesheet" type="text/css" />

    <!-- title image bar-->
    <div class="title-img-bar ">
        <table style="width: 100%">
            <tr>
                <td>
                    <div class="title">
                        Programmmes
     
                    </div>
                </td>
            </tr>
        </table>
    </div>

    <!-- content section -->
    <div class="Programmes-Content">
        <table style="width: 100%; margin-left: 30px; margin-right: 30px; margin: 10px;" class="progInfo">
            <tr>
                <th colspan="3">
                    <asp:Label ID="programTitle" runat="server" Text="" Font-Size="XX-Large"></asp:Label>
                    <br />
                    <br />
                </th>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="programOverviewLbl" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <th style="width: 30%;">Duration</th>
                <td style="width: 2%;vertical-align: top;">:</td>
                <td colspan="2" style="width: 70%;">
                    <asp:Label ID="programDurationLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <th style="width: 28%;">Campuses</th>
                <td style="width: 2%;vertical-align: top;">:</td>
                <td style="width: 70%;">
                    <asp:Label ID="programCampusesLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <th style="width: 30%;">Intake</th>
                 <td style="width: 2%; vertical-align: top;">:</td>
                <td style="width: 70%;">
                    <asp:Label ID="programIntakeLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <th style="width: 30%;">EstimatedFees</th>
                 <td style="width: 2%; vertical-align: top;">:</td>
                <td style="width: 70%;">
                    <asp:Label ID="estimatedFeesLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <th style="width: 30%; vertical-align: top;">Qualification</th>
                 <td style="width: 2%; vertical-align: top;">:</td>
                <td style="width: 70%; vertical-align: top;">
                        <asp:Image ID="qualificationImg" runat="server" Style="width: 90%" />
                    
                </td>
            </tr>
        </table>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Program]"></asp:SqlDataSource>

</asp:Content>
