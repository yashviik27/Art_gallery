<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Artgallery.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
.auto-style1 {
    border-style: none;
    border-color: inherit;
    border-width: medium;
    width: 100%;
  /*  border-style: solid;
    border-width: 2px;*/
    border-collapse:collapse;
    height: 264px;
}
.auto-style2 {
    text-align: center;
    font-size: xx-large;
    height: 69px;
    /*background-color: #E6F2FF;*/
}
.auto-style9 {
    height: 61px;
    text-align: center;
    /*background-color: #E6F2FF;*/
}
.auto-style10 {
    width: 193px;
    height: 66px;
    font-size: xx-large;
    /*background-color: #E6F2FF;*/
}
.auto-style11 {
    height: 66px;
    /*background-color: #E6F2FF;*/
}
.auto-style12 {
    height: 66px;
    font-size: xx-large;
    text-align: center;
    /*background-color: #E6F2FF;*/
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1">
    <div>
        <table border="0" class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2" ></td>
            </tr>
           
            <tr>
                <td class="auto-style10">Select Type:</td>
                <td class="auto-style11" >
                    <asp:DropDownList ID="ddladmintype" runat="server" Height="68px" Width="215px" >
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Artist</asp:ListItem>
                        <asp:ListItem>User</asp:ListItem>
                        <asp:ListItem>Art</asp:ListItem>
                        <asp:ListItem>Welcome</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="2" >
                    <asp:Button ID="btnenter" runat="server" Text="ENTER"  Width="251px" OnClick="btnenter_Click" />
                </td>
            </tr>
        </table>

    </div>
</form>
</asp:Content>
