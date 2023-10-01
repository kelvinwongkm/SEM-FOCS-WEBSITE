<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="SEAM_Assignment.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="/css/profile.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <div class="title-img-bar">
        <div class="title">Profile</div>
    </div>

    <div class="whole-div">
        <div>
            <table class="tbl1">
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Name :" CssClass="lbl"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Enabled="false" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email :" CssClass="lbl"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Enabled="false" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblStatus" runat="server" Text="Enrolment Status :" CssClass="lbl"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtStatus" runat="server" Enabled="false" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLevel" runat="server" Text="Level :" CssClass="lbl"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtLevel" runat="server" Enabled="false" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblQua" runat="server" Text="Qualification :" CssClass="lbl"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtQua" runat="server" Enabled="false" CssClass="txt"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCGPA" runat="server" Text="CGPA :" CssClass="lbl" Visible="true"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtCGPA" runat="server" Enabled="false" CssClass="txt" Visible="true"></asp:TextBox></td>
                </tr>
            </table>
        </div>

        <div>
            <asp:Table ID="myTable" runat="server" Visible="true" Enabled="false" CssClass="tbl">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblSubject1" runat="server" Text="Subject" CssClass="lblTable"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblGrade1" runat="server" Text="Grade" CssClass="lblTable"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblSubject2" runat="server" Text="Subject" CssClass="lblTable"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblGrade2" runat="server" Text="Grade" CssClass="lblTable"></asp:Label>
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
        </div>

        <div>
            <asp:Button ID="btnEdit" runat="server" Text="Edit Qualification" CssClass="btnEdit" OnClick="btnEdit_Click" />
        </div>

    </div>
</asp:Content>
