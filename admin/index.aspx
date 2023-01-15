<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Sstorage.admin.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <title>דף הבית | Sstorage</title> 
 <link rel="icon" type="image/png" href="/images/icon.png">
 <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
 <link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
 <link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
 <link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
 <link rel="stylesheet" type="text/css" href="vendor/perfect-scrollbar/perfect-scrollbar.css">
 <link rel="stylesheet" type="text/css" href="css/util.css">
 <link rel="stylesheet" type="text/css" href="css/main.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
	<span style=" width:350px; padding:70px; direction:ltr;">
        <br />
         <asp:Literal ID="LtlUserDitels" runat="server" />
    </span>    	
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="limiter">
        <div class="container-table100" style="text-align:center;"">
            <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
            <span  style="padding:initial;text-align:center; color:#4800ff; display:contents; font-size:110px;font-family: Gabriola;">Welcome to the Sstorage</span>
        </div>
    </div>
</asp:Content>
