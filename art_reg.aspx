<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="art_reg.aspx.cs" Inherits="Artgallery.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
    .auto-style1 {
        width: 100%;
        border-collapse:collapse;
        border: none;
    }
    .auto-style2 {
        font-size: x-large;
        color: #000099;
    }
    .auto-style3 {
        text-align: center;
        height: 54px;
    }
    .auto-style4 {
        width: 327px;
    }
    
    
    .auto-style8 {
        width: 327px;
        
        height: 39px;
    }
    .auto-style9 {
        
        height: 39px;
    }
    .auto-style10 {
        
        height: 67px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3" colspan="2"><strong><em>ART DETAILS&nbsp;</em></strong></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Artsit_name:</strong></td>
            <td class="auto-style6">
                <asp:DropDownList ID="ddlartistname" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Art_name :</strong></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtartname" runat="server" CssClass="auto-style5"></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Art_price :</strong></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtartprice" runat="server" CssClass="auto-style5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Art_description :</strong></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtartdesc" runat="server" CssClass="auto-style5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Art_image :</strong></td>
            <td class="auto-style9">
                <asp:FileUpload ID="artimgpath" runat="server" CssClass="auto-style5" />
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style10">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btsubmit" runat="server" Text="Submit" CssClass="auto-style5" OnClick="btsubmit_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="btreset" runat="server" Text="Reset" CssClass="auto-style5" />
                &nbsp;&nbsp;
                &nbsp;</td>
        </tr>
    </table>
</form>
</asp:Content>
