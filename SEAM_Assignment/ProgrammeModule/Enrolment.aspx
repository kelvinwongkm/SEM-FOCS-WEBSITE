<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="Enrolment.aspx.cs" Inherits="SEAM_Assignment.ProgrammeModule.Enrolment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/enrolment.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <%--        <div class="cover">
            <img src="image/enrolment.png" alt="cover" style="width: 100%;">
            <div class="cover-text">
                <h2>PROGRAMMES</h2>
            </div>
        </div>--%>

    <div class="title-img-bar">
        <div class="title">PROGRAMMES</div>
    </div>


    <section id="secMain">

        <h2><b>Programme Selection</b></h2>

        <section id="secIntake">
            <div>
                <asp:Label ID="lblIntake" runat="server" Text="Intake" CssClass="lbl"></asp:Label>
            </div>
            <div>
                <asp:DropDownList ID="ddlIntake" runat="server" CssClass="ddl" AutoPostBack="True" OnSelectedIndexChanged="ddlIntake_SelectedIndexChanged">
                    <asp:ListItem>Select Intake</asp:ListItem>
                    <asp:ListItem>Oct/Nov 2023</asp:ListItem>
                    <asp:ListItem>Feb 2024</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:Label ID="lblIntakeError" runat="server" Text="Please select an intake." CssClass="lblError" Visible="false"></asp:Label>

        </section>

        <section id="secProgramme">
            <table class="tbl">
                <tr>
                    <td><asp:Label ID="lblCampus" runat="server" Text="Campus" CssClass="lbl"></asp:Label></td>
                    <td><asp:Label ID="lblLevel" runat="server" Text="Level" CssClass="lbl"></asp:Label></td>
                    <td><asp:Label ID="lblProgramme" runat="server" Text="Programme" CssClass="lbl"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlCampus" runat="server" CssClass="ddlTable" AutoPostBack="True" OnSelectedIndexChanged="ddlCampus_SelectedIndexChanged">
                            <asp:ListItem>Select Campus</asp:ListItem>
                            <asp:ListItem>Kuala Lumpur Campus</asp:ListItem>
                            <asp:ListItem>Penang Branch</asp:ListItem>
                            <asp:ListItem>Perak Branch</asp:ListItem>
                            <asp:ListItem>Johor Branch</asp:ListItem>
                            <asp:ListItem>Pahang Branch</asp:ListItem>
                            <asp:ListItem>Sabah Branch</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLevel" runat="server" Enabled="false" CssClass="txtTable"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlProgramme" runat="server" CssClass="ddlTable" AutoPostBack="True" OnSelectedIndexChanged="ddlProgramme_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCampusError" runat="server" Text="Please select a campus." CssClass="lblError" Visible="false"></asp:Label></td>
                    <td></td>
                    <td>
                        <asp:Label ID="lblProgrammeError" runat="server" Text="Please select a programme." CssClass="lblError" Visible="false"></asp:Label></td>
                </tr>
            </table>
        </section>

        <h2 style="margin-top: 40px;"><b>Academic Qualification</b></h2>

        <section id="secQualification">
            <table class="tbl">
                <tr>
                    <td><asp:Label ID="lblQua" runat="server" Text="Qualification" CssClass="lbl"></asp:Label></td>
                    <td><asp:Label ID="lblCGPA" runat="server" Text="CGPA" CssClass="lbl" Visible="false"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtQua" runat="server" Enabled="false" CssClass="txt"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCGPA" runat="server" Visible="false" Enabled="false" Placeholder="Enter CGPA" CssClass="txt"></asp:TextBox></td>
            </table>
        </section>

        <section id="secSubjectGrade">
            <asp:Table ID="myTable" runat="server" Visible="false" Enabled="false" CssClass="tbl">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblSubject1" runat="server" Text="Subject" CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblGrade1" runat="server" Text="Grade" CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblSubject2" runat="server" Text="Subject" CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblGrade2" runat="server" Text="Grade" CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub1" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra1" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub2" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra2" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub3" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra3" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub4" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra4" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub5" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra5" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub6" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra6" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub7" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra7" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub8" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra8" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub9" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra9" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub10" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra10" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub11" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra11" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSub12" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtGra12" runat="server" CssClass="txtTable"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </section>

        <asp:Button ID="btnSubmit" runat="server" Text="Submit Enrolment" CssClass="btnSubmit" OnClick="btnSubmit_Click" />
    </section>
</asp:Content>

