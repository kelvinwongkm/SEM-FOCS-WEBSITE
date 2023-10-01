<%@ Page Title="" Language="C#" MasterPageFile="~/UserHeaderFooter.Master" AutoEventWireup="true" CodeBehind="enquiryUser.aspx.cs" Inherits="SEAM_Assignment.EnquiryModule.enquiryUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css" />
    <link href="/css/enquiry_style.css" rel="stylesheet" />
    <link href="/css/style.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <style type="text/css">
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

        .addEnquiry-button {
            color: #ffffff;
            background-color: #22CB79;
            font-weight: bold;
            border: 1px solid;
            border-radius: 5px;
            padding: 10px 15px;
            display: flex;
            float: right;
        }

            .addEnquiry-button:hover {
                color: #22CB79;
                background-color: #ffffff;
            }
    </style>

    <div class="title-img-bar">
        <div class="title">Enquiry</div>
        <!--Change to ur page title-->
    </div>

    <div class="whole-content">
            <div style="width: 50%; float: left; height: 60px; display: flex; align-items: center; padding-bottom: 40px;">
                <asp:Label ID="lblEnq" runat="server" Text="Filter enquiry via status: " Style="margin-right: 10px;"></asp:Label>
                <asp:DropDownList ID="ddlEnquiryStatus" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEnquiryStatus_SelectedIndexChanged">
                    <asp:ListItem Text="All" Value="all" Selected="True" />
                    <asp:ListItem Text="Processing" Value="processing" />
                    <asp:ListItem Text="Completed" Value="completed" />
                </asp:DropDownList>
            </div>
            <div style="width: 50%; float: right; height: 60px; display: flex; align-items: center; padding-bottom: 40px; justify-content: flex-end;">
                    <asp:Button ID="addEnqBtn" class="addEnquiry-button" runat="server" Text="Add New Enquiry" OnClick="addEnqBtn_Click" />
            </div>

        <div>
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
        </div>
    </div>
</asp:Content>
