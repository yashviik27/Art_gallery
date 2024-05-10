<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Artgallery.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
     .auto-style3 {
         width: 125%;
         height: 101px;
     }
     .auto-style5 {
         margin-top: 0;
         height: 62px;
     text-align: center;
     width: 1558px;
 }
      .auto-style11 {
     width: 364px;
     text-align: center;
 }
 .auto-style12 {
     width: 275px;
     text-align: center;
 }
 .auto-style13 {
     width: 237px;
     text-align: center;
 }
 
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Image ID="Imghome" runat="server" ImageUrl="~/image/gallery3.jpg" Height="547px" Width="1543px" />



    <br />
    <br />
    <br />
    <br />
    <div> 
    <h1 class="auto-style5"> WELCOME TO SRKI ART GALLERY.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
    </div>  

    <table class="auto-style3">
        <tr>
            <td class="auto-style13"><strong>Location</strong></td>
            <td class="auto-style12"><strong>Phone</strong></td>
            <td class="auto-style11"><strong>Opening Hours</strong></td>
            <td class="text-center"><strong>For More Information</strong></td>
        </tr>
       <tr>
            <td class="auto-style13">Srki Art Gallery,Athwalines</td>
            <td class="auto-style12">0261-2227088</td>
            <td class="auto-style11">12:00AM to 7:00PM</td>
            <td class="text-center">Artgallery@gmail.com</td>
      </tr>
    </table>
    <br />

</asp:Content>
