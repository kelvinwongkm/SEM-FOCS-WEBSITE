<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="compareProgrammes.aspx.cs" Inherits="SEAM_Assignment.compareProgrammes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html>

    <head>

        <!-- Basic -->
        <meta charset="utf-8" />
        <!-- Mobile Metas -->
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <!-- Site Metas -->
        <link rel="icon" href="images/fevicon.png" type="images/logo.png" />

        <title>Tunku Abdul Rahman University of Management & Technology - Faculty of Computing and Information Technology</title>

        <!-- bootstrap core css -->
        <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />

        <!-- fonts style -->
        <!-- <link href="https://fonts.googleapis.com/css?family=Poppins:400,600,700&display=swap" rel="stylesheet" /> -->
        <!-- Icon Font Stylesheet -->
        <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css" rel="stylesheet">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css" rel="stylesheet">
        <!-- Custom styles for this template -->
        <link href="/css/style.css" rel="stylesheet" />
        <link href="/css/program.css" rel="stylesheet" />

        <meta name="viewport" content="width=device-width, initial-scale=1">
    </head>

    <body>
        <!-- title image bar-->
        <div class="title-img-bar ">
            <table style="width: 100%">
                <tr>
                    <td>
                        <div class="title" style="padding: 20px;">
                            Programmmes
           
                        </div>
                    </td>
                </tr>
            </table>


        </div>

        <!-- content section -->
        <div class="Programmes-Content">
            <table style="width: 100%;">
                <tr>
                    <td colspan="2" style="padding-top: 30px;">
                        <h2>Compare Programmes</h2>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="padding-top: 30px;">
                        <p>Choose Programmes Level: </p>

                        <asp:DropDownList ID="ddlLevel" runat="server" CssClass="ddl" AutoPostBack="True" OnSelectedIndexChanged="ddlLevel_SelectedIndexChanged">
                            <asp:ListItem>Select Level</asp:ListItem>
                            <asp:ListItem>Diploma</asp:ListItem>
                            <asp:ListItem>Bachelor</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="padding-top: 30px;">
                        <p>Choose Programmes to be Compared: </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="column" style="float: left;">
                            <asp:DropDownList CssClass="compareDdl" ID="ddlCompare1" runat="server">
                                <asp:ListItem>Select Programme</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                        </div>
                        <div class="column" style="float: right;">
                            <asp:DropDownList CssClass="compareDdl" ID="ddlCompare2" runat="server">
                                <asp:ListItem>Select Programme</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="width: 50%; padding-top: 30px;">
                        <table style="width: 100%;" class="compareT">
                            <tr style="vertical-align: top;">
                                <th style="width: 20%;">PROGRAM
                                </th>
                                <th style="width: 40%;">
                                    <asp:Label ID="programlbl1" runat="server" Text="" Style="margin-left: 5px;"></asp:Label>
                                </th>
                                <th style="width: 40%;">
                                    <asp:Label ID="programlbl2" runat="server" Text="" Style="margin-left: 5px;"></asp:Label>
                                </th>
                            </tr>
                            <tr style="vertical-align: top;">
                                <th style="width: 20%;">DURATION</th>
                                <td style="width: 40%;">
                                    <asp:Label ID="duration1" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                                <td style="width: 40%;">
                                    <asp:Label ID="duration2" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                            </tr>
                            <tr style="vertical-align: top;">
                                <th style="width: 20%;">CAMPUSES</th>
                                <td style="width: 40%;">
                                    <asp:Label ID="campuses1" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                                <td style="width: 40%;">
                                    <asp:Label ID="campuses2" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                            </tr>
                            <tr style="vertical-align: top;">
                                <th style="width: 20%;">INTAKE</th>
                                <td style="width: 40%;">
                                    <asp:Label ID="intake1" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                                <td style="width: 40%;">
                                    <asp:Label ID="intake2" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                            </tr>
                            <tr style="vertical-align: top;">
                                <th style="width: 20%;">ESTIMATED FEES</th>
                                <td style="width: 40%;">
                                    <asp:Label ID="estimatedFees1" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                                <td style="width: 40%;">
                                    <asp:Label ID="estimatedFees2" runat="server" Text="" Style="margin-left: 5px;"></asp:Label></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>

            <div style="text-align: center; width: 100%;">
                <asp:Button CssClass="compareBtn" ID="btnCompare" runat="server" Text="Compare Programmes" OnClick="btnCompare_Click" />
            </div>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Program]"></asp:SqlDataSource>
        </div>



    </body>
    </html>

</asp:Content>
