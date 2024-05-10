<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="Artgallery.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style3 {
            height: 51px;
            text-align: center;
        }
        .auto-style4 {
            height: 61px;
        }
        .auto-style5 {
            height: 61px;
            width: 383px;
        }
        .auto-style6 {
            margin-right: 0px;
        }
        .auto-style7 {
            width: 100%;
            border-color: #000000;
        }
        .auto-style8 {
            margin-bottom: 7px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--<table class="w-100">
     <tr>
         <td class="auto-style3" colspan="2">SEARCH ART NAME</td>
     </tr>
     <tr>
         <td class="auto-style5">ART NAME :</td>
         <td class="auto-style4">
             <asp:DropDownList ID="ddlart_type" runat="server" Height="71px" Width="195px" DataSourceID="SqlDataSource3" DataTextField="art_Name" DataValueField="art_Name" >
                 <asp:ListItem Selected="True">--select--</asp:ListItem>
                 <asp:ListItem>POP ART ARTIST</asp:ListItem>
                 <asp:ListItem>POTRAIT ART ARTIST</asp:ListItem>
                 <asp:ListItem>FRESCO ART ARTIST</asp:ListItem>
                 <asp:ListItem>ABSTRACT ART ARTIST</asp:ListItem>
                 <asp:ListItem>SPRAY ART ARTIST</asp:ListItem>
             </asp:DropDownList>
         &nbsp;&nbsp;&nbsp;
         </td>
     </tr>
     <tr>
         <td class="auto-style4" colspan="2">
             <asp:Button ID="btnsearch" runat="server"  Text="Search" OnClick="btnsearch_Click" />
             <asp:Label ID="lblemail" runat="server" ForeColor="AntiqueWhite"></asp:Label>
         </td>
     </tr>
     <tr>
         <td class="auto-style4" colspan="2">
             <asp:GridView ID="dgvuser" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="831px" CssClass="auto-style6">
                 <Columns>
                     <asp:BoundField DataField="art_Name" HeaderText="art_Name" SortExpression="art_Name" />
                     <asp:BoundField DataField="art_price" HeaderText="art_price" SortExpression="art_price" />
                     <asp:BoundField DataField="art_Description" HeaderText="art_Description" SortExpression="art_Description" />
                     <asp:TemplateField HeaderText="art_Image" SortExpression="art_Image">
                         <EditItemTemplate>
                             <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("art_Image") %>'></asp:TextBox>
                         </EditItemTemplate>
                         <ItemTemplate>
                             <asp:Image ID="Image1" runat="server" Height="183px" ImageUrl='<%# Eval("art_Image") %>' Width="179px" />
                         </ItemTemplate>
                     </asp:TemplateField>
                 </Columns>
             </asp:GridView>             
             <br />--%>
             <asp:DataList ID="DataList1" runat="server" CellPadding="4" CssClass="auto-style8" DataSourceID="SqlDataSource1" ForeColor="#333333" RepeatColumns="1" RepeatDirection="Horizontal" Width="728px" OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" >
                 <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                 <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                 <ItemTemplate>
                     <br />
                     <table class="auto-style7">
                         <tr>
                             <td class="text-center">ART NAME
                                 <asp:Label ID="label1" runat="server" Text='<%# Eval("art_Name") %>'></asp:Label>
                             </td>
                         </tr>
                         <tr>
                             <td class="text-center">ART PRICE
                                 <asp:Label ID="label2" runat="server" Text='<%# Eval("art_price") %>'></asp:Label>
                             </td>
                         </tr>
                         <tr>
                             <td class="text-center">ART DESCRIPTION
                                 <asp:Label ID="label3" runat="server" Text='<%# Eval("art_Description") %>'></asp:Label>
                             </td>
                         </tr>
                         <tr>
                             <td class="text-center">ART IMAGE
                                 <asp:Image ID="Image2" runat="server" Height="105px" ImageUrl='<%# Eval("art_Image") %>' Width="106px" />
                             </td>
                         </tr>
                         <tr>
                             <td class="text-end">
                                 <asp:ImageButton ID="ImageButton1" runat="server" Height="42px" ImageUrl="~/image/cart.jpg" Width="46px" OnClick="ImageButton1_Click" />
                             </td>
                         </tr>
                     </table>
                 </ItemTemplate>
                 <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
             </asp:DataList>
             <br /><%--
             
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [art_Name], [art_price], [art_Description], [art_Image] FROM [tbl_art]">
             </asp:SqlDataSource>
             <br />
             <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [art_Name] FROM [tbl_art] WHERE ([art_Name] = @art_Name)">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="ddlart_type" DefaultValue="--SELECT--" Name="art_Name" PropertyName="SelectedValue" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
             <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [art_Name] FROM [tbl_art] WHERE ([art_Name] = @art_Name)">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="ddlart_type" DefaultValue="--SELECT--" Name="art_Name" PropertyName="SelectedValue" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
         </td>
     </tr>
 </table>--%>


         <table class="w-100">
     <tr>
         <td class="auto-style3" colspan="2">SEARCH ART NAME</td>
     </tr>
     <tr>
         <td class="auto-style5">ART NAME :</td>
         <td class="auto-style4">
             <asp:DropDownList ID="ddlart_type" runat="server" Height="71px" Width="195px" DataSourceID="SqlDataSource2" DataTextField="art_Name" DataValueField="art_Name" >
                 <asp:ListItem Selected="True">--select--</asp:ListItem>
                 <asp:ListItem>POP ART ARTIST</asp:ListItem>
                 <asp:ListItem>POTRAIT ART ARTIST</asp:ListItem>
                 <asp:ListItem>FRESCO ART ARTIST</asp:ListItem>
                 <asp:ListItem>ABSTRACT ART ARTIST</asp:ListItem>
                 <asp:ListItem>SPRAY ART ARTIST</asp:ListItem>
             </asp:DropDownList>
         &nbsp;&nbsp;&nbsp;
         </td>
     </tr>
     <tr>
         <td class="auto-style4" colspan="2">
             <asp:Button ID="btnsearch" runat="server"  Text="Search" OnClick="btnsearch_Click" />
             <asp:Label ID="lblemail" runat="server" ForeColor="AntiqueWhite"></asp:Label>
             <br />
             Your total cart is
             <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:HyperLink ID="hlcart" runat="server">show cart</asp:HyperLink>
         </td>
     </tr>
     <tr>
         <td class="auto-style4" colspan="2">
             <asp:GridView ID="dgvuser" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="831px" CssClass="auto-style6">
                 <Columns>
                     <asp:BoundField DataField="art_Name" HeaderText="art_Name" SortExpression="art_Name" />
                     <asp:BoundField DataField="art_price" HeaderText="art_price" SortExpression="art_price" />
                     <asp:BoundField DataField="art_Description" HeaderText="art_Description" SortExpression="art_Description" />
                     <asp:TemplateField HeaderText="art_Image" SortExpression="art_Image">
                         <EditItemTemplate>
                             <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("art_Image") %>'></asp:TextBox>
                         </EditItemTemplate>
                         <ItemTemplate>
                             <asp:Image ID="Image1" runat="server" Height="183px" ImageUrl='<%# Eval("art_Image") %>' Width="179px" />
                         </ItemTemplate>
                     </asp:TemplateField>
                 </Columns>
             </asp:GridView>
             <br />
             <br />
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [art_Name], [art_price], [art_Description], [art_Image] FROM [tbl_art] WHERE ([art_Name] = @art_Name)">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="ddlart_type" Name="art_Name" PropertyName="SelectedValue" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
             <br />
             <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [art_Name] FROM [tbl_art]"></asp:SqlDataSource>
         </td>
     </tr>
 </table>


 <br />
 <br />


 <br />
 <br />
</asp:Content>
