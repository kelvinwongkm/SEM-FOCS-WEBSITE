<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="Programmes.aspx.cs" Inherits="SEAM_Assignment.Programmes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

    <!-- Basic -->
    <meta charset="utf-8" />
    <!-- Mobile Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <!-- Site Metas -->
    <link rel="icon" href="../images/fevicon.png" type="images/logo.png" />

    <title>Tunku Abdul Rahman University of Management & Technology - Faculty of Computing and Information Technology</title>

    <!-- bootstrap core css -->


    <!-- fonts style -->
    <!-- <link href="https://fonts.googleapis.com/css?family=Poppins:400,600,700&display=swap" rel="stylesheet" /> -->
    <!-- Icon Font Stylesheet -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css" rel="stylesheet">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css" rel="stylesheet">
    <!-- Custom styles for this template -->
    <link href="/css/style.css" rel="stylesheet" />
    <link href="/css/program.css" rel="stylesheet" />
    <!-- responsive style -->
    <link href="/css/responsive.css" rel="stylesheet" />
    <link href="/css/bootstrap.css" rel="stylesheet" type="text/css" />
    </head>

    <body>

        <!-- title image bar-->
        <%--        <div class="title-img-bar ">
            <table style="width: 100%">
                <tr>
                    <td>
                        <div class="title">
                            Programmmes
                        </div>
                    </td>
                    <td>
                        <div style="text-align: right; float: right; padding-right: 10px;">
                            <asp:TextBox ID="TextBox1" CssClass="searchbar" runat="server" placeholder=" Search Programmes"></asp:TextBox>
                            <asp:Button ID="Button1" class="button" runat="server" Text="Search" OnClick="searchBtn_Click" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>--%>

        <div class="title-img-bar">
            <div class="title">PROGRAMMES</div>
        </div>



        <!-- content section -->
        <div class="allContentProgram" style="display: block;">

            <div class="Programmes-Content">

                <div>
                    <div class="contentNav">
                        <asp:LinkButton runat="server" CssClass="active" Style="border-right: solid black 0.5px" ID="AllProgramsLink" OnClick="AllProgramsLink_Click">All</asp:LinkButton>
                        <asp:LinkButton runat="server" Style="border-right: solid black 0.5px" ID="BachelorProgramsLink" OnClick="BachelorProgramsLink_Click">Bachelor</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="DiplomaProgramsLink" OnClick="DiplomaProgramsLink_Click">Diploma</asp:LinkButton>
                    </div>

                    <div class="searchBar">
                        <asp:TextBox ID="SearchTextBox" CssClass="searchbar" runat="server" placeholder=" Search Programmes"></asp:TextBox>
                        <asp:Button ID="searchBtn" class="button" runat="server" Text="Search" OnClick="searchBtn_Click" />
                    </div>
                </div>

                <br />
                <br />

                <div style="width: fit-content; padding-top: 40px;">
                    <h4>
                        <asp:Label ID="programLevel" runat="server" Text="Label"></asp:Label></h4>
                </div>

                <asp:Repeater ID="program" runat="server" OnItemDataBound="OnItemDataBound">
                    <ItemTemplate>
                        <div>
                            <a href="ProgramInfo.aspx?ID=<%# Eval("program_id") %>">
                                <div>
                                    <ul>
                                        <li>
                                            <%# Eval("program_title") %>
                                        </li>
                                    </ul>
                                </div>
                            </a>
                        </div>

                    </ItemTemplate>
                </asp:Repeater>


                <div class="progBtn">
                    <asp:Button ID="checkQbtn" runat="server" Text="Enrol Now" CssClass="progButton button" OnClick="checkQbtn_Click" />
                    <asp:Button ID="comparePbtn" runat="server" Text="Compare Programmes" CssClass="progButton button" OnClick="comparePbtn_Click" />
                </div>
            </div>

        </div>



    </body>
    </html>

</asp:Content>
