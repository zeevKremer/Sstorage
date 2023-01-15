<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="Surfaces.aspx.cs" Inherits="Sstorage.admin.Surfaces" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title> משטחים | Sstorage</title> 
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
     <div class="container-table100">
         <div>
    <a href="OpeningSurfaces.aspx" class="aaa" >פתיחת משטח חדש</a> <br /><br />
        <a href="SurfacesLocatorUpdate.aspx" class="aaa" >עידכון איתור משטח</a><br /><br />
             <a href="SurfacesMap.aspx" class="aaa" >מפת משטחים</a><br /> 
             </div>        
</div>   
    </div>
    <style>
        .aaa{
            color:#000000;
            font-size:20px;
        }
        .aaa:hover{
            font-size:25px;
        }         
         .modal-content {
    box-shadow: 0 0 0 5px red;
    border: none;
  }
         .u{
             display:none;
         }  
   .ro{
       color:black;
      
   }
   .column{
       width:148px;      
   }
    .TexBox{
            height:22px;
            width:140px;
            font-size:15px;
            color:#808080;
            border:solid 2px;
        }
    </style>   
<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<script src="vendor/bootstrap/js/popper.js"></script>
<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<script src="vendor/select2/select2.min.js"></script>
<script src="js/main.js"></script>
<script src="js/main1.js"></script>
<script>
    
	  window.dataLayer = window.dataLayer || [];
	  function gtag(){dataLayer.push(arguments);}
	  gtag('js', new Date());

	  gtag('config', 'UA-23581568-13');
</script>
</asp:Content>
