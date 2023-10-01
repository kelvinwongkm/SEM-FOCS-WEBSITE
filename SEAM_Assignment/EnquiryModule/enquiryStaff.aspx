<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="enquiryStaff.aspx.cs" Inherits="SEAM_Assignment.EnquiryModule.enquiryStaff" %>

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
            padding: 10px 20px;
            border: 0;
            font-weight: bold;
            color: white;
            font-weight: bold;
            background-color: #D85C44;
        }

        .subject-cell {
            max-width: 400px;
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
        }
        /**/
        .gridview {
            border-collapse: separate;
            border-spacing: 0;
            width: 100%;
            border: none;
        }

            .gridview th {
                border: none;
                border-bottom: 2px solid black;
                padding: 10px;
            }

            .gridview td {
                border: none;
                border-bottom: 1px solid black;
                padding: 10px;
            }

        table {
            margin: auto;
        }

        .gvPagination td {
            /* Style the pagination container */
            border: none;
        }
    </style>


    <div class="title-img-bar">
        <div class="title">Enquiry (Staff)</div>
        <!--Change to ur page title-->
    </div>

    <div class="whole-content">
        <%--<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="USer" />--%>


        <%--        <p style="text-align: right; margin-right: 100px;">
            <asp:Button ID="deleteEnquiryBtn" class="addEnquiry-button" runat="server" Text="Delete Enquiry" />
        </p>--%>

        <div>
            <div style="width: 50%; float: left; height: 60px; display: flex; align-items: center; padding-bottom: 40px;">
                <asp:Label ID="lblEnq" runat="server" Text="Filter enquiry via status: " Style="margin-right: 10px;"></asp:Label>
                <asp:DropDownList ID="ddlEnquiryStatus" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEnquiryStatus_SelectedIndexChanged">
                    <asp:ListItem Text="All" Value="all" Selected="True" />
                    <asp:ListItem Text="Processing" Value="processing" />
                    <asp:ListItem Text="Completed" Value="completed" />
                </asp:DropDownList>
            </div>

            <%--            <asp:GridView ID="enquiryGV" CssClass="gridview" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" AllowPaging="True" EmptyDataText="No enquiries found" OnPageIndexChanging="enquiryGV_PageIndexChanging" PageSize="5" RowHeaderColumn="Id" AutoGenerateSelectButton="True" OnSelectedIndexChanged="enquiryGV_SelectedIndexChanged">--%>
            <asp:GridView ID="enquiryGV" CssClass="gridview" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" AllowPaging="True" EmptyDataText="No enquiries found" OnPageIndexChanging="enquiryGV_PageIndexChanging" PageSize="5" AutoGenerateSelectButton="True" OnSelectedIndexChanged="enquiryGV_SelectedIndexChanged" OnRowDataBound="enquiryGV_RowDataBound">
                <PagerStyle CssClass="gvPagination" HorizontalAlign="Center" Width="100%" />
                <Columns>
                    <asp:TemplateField HeaderText="No.">
                        <ItemTemplate>
                            <asp:Label ID="lblRowNumber" runat="server" Style="text-align: center;"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Subject" HeaderText="Subject" ItemStyle-Width="400px" ItemStyle-Wrap="False" ItemStyle-CssClass="subject-cell" />
                    <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0:MM/dd/yyyy HH:mm:ss}" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                </Columns>
            </asp:GridView>

            <asp:Label ID="numOfEnqlbl" runat="server"></asp:Label>
            <br />
            <asp:Label ID="numOfProcessinglbl" runat="server"></asp:Label>
        </div>

    </div>


</asp:Content>
