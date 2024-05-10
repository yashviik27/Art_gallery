<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="admin_login.aspx.cs" Inherits="Artgallery.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
    .auto-style3 {
        width: 100%;
        height: 184px;
    }
    .auto-style4 {
        text-align: center;
        font-size: xx-large;
    }
    .auto-style6 {
        font-size: xx-large;
        width: 436px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table class="auto-style3">
    <tr>
        <td class="auto-style4" colspan="2">LOGIN</td>
    </tr>
    <tr>
        <td class="auto-style6">Email :</td>
        <td class="text-center">
            <asp:TextBox ID="txtemail" runat="server" Height="46px" Width="197px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">Password :</td>
        <td class="text-center">
            <asp:TextBox ID="txtpassword" runat="server" Height="38px" Width="195px" TextMode="Password" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="2">
            <asp:Button ID="btnsubmit" runat="server" Text="SUBMIT" OnClick="btnsubmit_Click"  />
        </td>
    </tr>
</table>
</asp:Content>
