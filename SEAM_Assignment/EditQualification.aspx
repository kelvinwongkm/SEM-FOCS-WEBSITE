<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="EditQualification.aspx.cs" Inherits="SEAM_Assignment.EditQualification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/editqua.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <div class="title-img-bar">
        <div class="title">Edit Qualification</div>
    </div>

    <div class="sign_up">
        <div class="div">
            <table class="tbl">
                <tr>
                    <td>
                        <asp:Label ID="lblLevel" runat="server" Text="Level:" CssClass="lbl"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblQua" runat="server" Text="Qualification:" CssClass="lbl"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlLevel" runat="server" CssClass="ddl" AutoPostBack="True" OnSelectedIndexChanged="ddlLevel_SelectedIndexChanged" >
                            <asp:ListItem>Select Level</asp:ListItem>
                            <asp:ListItem>Diploma</asp:ListItem>
                            <asp:ListItem>Bachelor</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblLevelError" runat="server" Text="*" CssClass="lblError" Visible="false"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlQua" runat="server" CssClass="ddl" AutoPostBack="True" OnSelectedIndexChanged="ddlQua_SelectedIndexChanged" >
                            <asp:ListItem>Select Qualification</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblQuaError" runat="server" Text="*" CssClass="lblError" Visible="false"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>

        <section class="div">
            <div>
                <asp:Label ID="lblCGPA" runat="server" Visible="false" Text="CGPA:" CssClass="lbl"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="txtCGPA" runat="server" Visible="false" Placeholder="Enter CGPA" CssClass="txt"></asp:TextBox>
                <asp:Label ID="lblCGPAError" runat="server" Text="Please enter your CGPA." CssClass="lblError" Visible="false"></asp:Label>
            </div>
        </section>

        <section class="div">
            <asp:Table ID="myTable" runat="server" Visible="false" CssClass="tbl">
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
                        <asp:DropDownList ID="ddlSub1" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>

                        <asp:DropDownList ID="ddlGra1" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub2" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra2" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub3" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra3" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub4" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra4" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub5" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra5" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub6" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra6" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub7" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra7" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub8" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra8" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub9" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra9" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub10" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra10" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub11" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra11" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSub12" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Subject</asp:ListItem>
                            <asp:ListItem>Bahasa Melayu</asp:ListItem>
                            <asp:ListItem>Bahasa Inggeris</asp:ListItem>
                            <asp:ListItem>Bahasa Cina</asp:ListItem>
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Matematik Tambahan</asp:ListItem>
                            <asp:ListItem>Kimia</asp:ListItem>
                            <asp:ListItem>Fizik</asp:ListItem>
                            <asp:ListItem>Biologi</asp:ListItem>
                            <asp:ListItem>Sejarah</asp:ListItem>
                            <asp:ListItem>Pendidikan Moral</asp:ListItem>
                            <asp:ListItem>Prinsip Perakaunan</asp:ListItem>
                            <asp:ListItem>Ekonomi</asp:ListItem>
                            <asp:ListItem>Sains</asp:ListItem>
                            <asp:ListItem>Perniagaan</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlGra12" runat="server" CssClass="ddlTable">
                            <asp:ListItem>Select Grade</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                            <asp:ListItem>X</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </section>

        <div>
            <asp:Label ID="lblError" runat="server" Visible="false" Text="lblError" CssClass="lblError"></asp:Label>
        </div>

        <div style="margin-top: 50px;">
        <table style="width: 20%;">
            <tr>
                <td><asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btnSave" OnClick="btnSave_Click" /></td>
                <td><asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btnCancel" OnClick="btnCancel_Click" /></td>
            </tr>
        </table>
            </div>
    </div>
</asp:Content>
