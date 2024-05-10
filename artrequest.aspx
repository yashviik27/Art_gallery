<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="artrequest.aspx.cs" Inherits="Artgallery.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
            border: 2px solid #000000;
        }
        .auto-style5 {
            height: 64px;
            text-align: center;
            font-size: xx-large;
        }
        .auto-style6 {
            height: 64px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </br>
    <table class="auto-style3">
        <tr>
            <td class="auto-style5" colspan="2">REQUEST OF ART</td>
        </tr>

        <tr>
            <td class="auto-style6">
                <asp:Button ID="btnaccept" runat="server" OnClick="btnaccept_Click" Text="ACCEPT" Width="214px" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="btndecline" runat="server" OnClick="btndecline_Click" Text="DECLINE" Width="198px" />
            </td>
        </tr>

    </table>

    <br />
    <br />
    <br />
    <asp:GridView ID="dgvrequest" runat="server">
    </asp:GridView>

    </br>
</asp:Content>
