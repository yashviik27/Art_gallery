<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="artist_reg.aspx.cs" Inherits="Artgallery.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.auto-style1 {
    width: 100%;
    height: 334px;
    border-collapse:collapse;
    border: none;
}
.auto-style2 {
    text-align: center;
    font-size: medium;
    height: 27px;
}
.auto-style3 {
    height: 26px;
}
.auto-style4 {
            width: 740px;
        }
.auto-style7 {
    margin-left: 2px;
}
.auto-style8 {
            width: 740px;
            height: 32px;
        }
.auto-style9 {
    height: 32px;
}
.auto-style10 {
            width: 740px;
            height: 33px;
        }
.auto-style11 {
    height: 33px;
}
    .auto-style12 {
        width: 740px;
        text-align: center;
    }
.auto-style13 {
    text-align: center;
    font-size: xx-large;
    height: 77px;
    width: 132px;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="artist_form">
    <table class="auto-style1" >
        <tr>
            <td class="auto-style13" colspan="2" >ARTIST REGISTRATION FORM</td>
        </tr>
        <tr>
            <td class="auto-style4" ><strong> Name :</strong></td>
            <td >
                <asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong> Email :</strong></td>
            <td  class="auto-style9">
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Password<strong> :</strong></td>
            <td  class="auto-style9">
                <asp:TextBox ID="txtpass" runat="server"  TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" ><strong> Phone no :</strong></td>
            <td  class="auto-style11">
                <asp:TextBox ID="txtphoneno" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="enter  10 digits" MaximumValue="10" MinimumValue="0" ControlToValidate="txtphoneno"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" ><strong> Address :</strong></td>
            <td >
                <asp:TextBox ID="txtaddeess" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" ><strong> State: </strong> </td>
            <td class="auto-style11" >
                <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged"  >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" ><strong> City :</strong></td>
            <td  class="auto-style11">
                <asp:DropDownList ID="ddlcity" runat="server" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong> Gender :</strong></td>
            <td class="auto-style11" >
                <asp:RadioButtonList ID="rblgender" runat="server" RepeatDirection="Horizontal" >
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Artist Type :</td>
            <td class="auto-style11" >
                <asp:DropDownList ID="ddlartist_type" runat="server" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style12" >
                &nbsp;
                <a <%--href="App_Data/artgallery.mdf"--%>><asp:Button ID="btnsubmit" runat="server" Text="SUBMIT"  CssClass="auto-style7" OnClick="btnsubmit_Click"  />
                <asp:Button ID="btnreset" runat="server" Text="RESET" OnClick="btnreset_Click" />
                </a>
                <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="UPDATE" />
&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2" >
                &nbsp;</td>
        </tr>
    </table>
</form>
</asp:Content>
