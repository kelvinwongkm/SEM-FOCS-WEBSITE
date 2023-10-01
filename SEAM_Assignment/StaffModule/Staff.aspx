<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="SEAM_Assignment.StaffModule.Staff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/css/style.css" rel="stylesheet" type="text/css" />
    <link href="/css/staff.css" rel="stylesheet" type="text/css" />
    <link href="/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <div class="title-img-bar">
        <div class="title">Our Team</div>
    </div>

    <!-- content section -->
    <div class="Staff-Content">
        <div class="staff_rdl_container">
            <div class="staff_division_container">
                <p class="staff_sort_title">Departments</p>
                <asp:RadioButtonList ID="rdl_staff_division" runat="server" CellPadding="5" CellSpacing="5" OnSelectedIndexChanged="rdl_staff_division_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Selected="True">All Staff</asp:ListItem>
                    <asp:ListItem>Department of Software Engineering And Technology</asp:ListItem>
                    <asp:ListItem>Department of Information Systems And Security</asp:ListItem>
                    <asp:ListItem>Department of Information And Communication Technology</asp:ListItem>
                    <asp:ListItem>Administrative Office</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="staff_alphabet_container">
                <p class="staff_sort_title">Sorting</p>
                <asp:RadioButtonList ID="rdl_alphabet" runat="server" CellPadding="5" CellSpacing="5"
                    OnSelectedIndexChanged="rdl_staff_sorting_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Selected="True">Default</asp:ListItem>
                    <asp:ListItem Value="Alphabetical">Alphabetical (A-Z)</asp:ListItem>
                </asp:RadioButtonList>

            </div>
        </div>

        <div class="staff_content_container" style="width: 86%;">

            <div class="staffsearch">
                <div style="width: 50%; font-weight: 700; font-size: 30px; line-height: 45px; padding: 10px; margin-left: 10px;">
                    <asp:Label ID="staffTitle" runat="server" Text=""></asp:Label>
                </div>
                <div class="searchDiv">
                    <asp:TextBox ID="txt_staff_search" CssClass="searchbar1" runat="server" oninput="enableSearchButton()" ClientIDMode="Static"></asp:TextBox>
                    <asp:Button ID="btn_staff_search" CssClass="button" runat="server" Text="Search" OnClick="btn_search_Click" disabled="disabled" ClientIDMode="Static" />
                </div>
            </div>

            <div class="grid-container">
                <asp:Repeater ID="rptImages" runat="server" OnItemDataBound="OnItemDataBound">
                    <ItemTemplate>
                        <div class="grid-item">
                            <a href="staff_details.aspx?staff_id=<%# Eval("staff_id") %>">
                                <div class="grid-item-img-container">
                                    <asp:Image ID="Image1" runat="server" CssClass="grid-item-img" />
                                </div>
                                <div class="grid-item-title">
                                    <%# Eval("staff_name") %>
                                </div>
                                <div class="grid-item-subtitle">
                                    <%# Eval("staff_position") %>
                                </div>
                            </a>
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <br>
            <br>
            <br>
        </div>
    </div>

    <script>
        function enableSearchButton() {
            var searchInput = document.getElementById('txt_staff_search'); // Use the client-side ID directly
            var searchButton = document.getElementById('btn_staff_search'); // Use the client-side ID directly

            // Enable the button if the search input has content, otherwise disable it
            if (searchInput.value.trim() !== '') {
                searchButton.removeAttribute('disabled');
            } else {
                searchButton.setAttribute('disabled', 'disabled');
            }
        }
    </script>


</asp:Content>
