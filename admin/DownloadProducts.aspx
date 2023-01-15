<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="DownloadProducts.aspx.cs" Inherits="Sstorage.admin.DownloadProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title> הורדות מרזרבות לליקוט | Sstorage</title>
 <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
 <link rel="icon" type="image/png" href="/images/icon.png">
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
<asp:Literal ID="LiCertificateDitels" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <br /> <br />     
     <asp:Literal ID="b" runat="server" />                
    <br /><br /><br />
    <table style="width:1000px;" border="0">       
        <tr>
            <td style="width:125px;">                
                <center>                    
                תאריך פתיחה
                    </center>
            </td>
            <td style="width:110px;">
                <center>
                   <span style="color:#ff0000;">
                       <asp:Literal ID="LtlDate" runat="server" />
                   </span>
                    </center>

            </td>        
            <td style="width:125px;">
                <center>
                מחסן שולח
                    </center>
            </td>
            <td style="width:110px;">
                <center>
                    <span style="color:#ff0000;">
                        <asp:Literal ID="LtlStorageSender" runat="server" />
                    </span> 
                    </center>
            </td>        
            <td style="width:125px;">
                <center>
                מחסן מקבל
                    </center>
            </td>
            <td style="width:110px;">
                <center>               
                    <span style="color:#ff0000;">
                        <asp:Literal ID="LtlStorageGeter" runat="server" />
                    </span> 
                    </center>
            </td>        
            <td style="width:125px;">
                <center>
                סטטוס
                    </center>
            </td>
            <td style="width:110px;">
                <center>                 
                    <span style="color:#ff0000;">
                        <asp:Literal  ID="LtlStatus" runat="server" />
                    </span> 
                    </center>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="color:#4800ff;"><asp:Button ID="Open" runat="server" OnClick="Open_Click" Text="משיכת מוצר להורדה" /></td>            
            <td colspan="2">
                 <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnTextChanged="DdlActions_TextChanged1" >
                        <asp:ListItem Text="פעולות נוספות..."  Value="0"  Disabled="True" Selected="True" />                        
                        <asp:ListItem Text='משיכת מוצר לפי מק"ט '  Value="1" />
                        <asp:ListItem Text="עידכון איתור למשטח"  Value="2" />
                    </asp:DropDownList>
            </td>
        </tr>       
    </table>           
                      
</center>





    <div class="limiter">
  <div class="container-table100">
    <div class="wrap-table100">      
      <div class="table100" >                   
        <table style="width:800px;">
          <thead>
            <tr class="table100-head">
              <th class="column5" style="text-align:center;">ברקוד</th>
              <th class="column5" style="text-align:center;">ברקוד מקוצר</th>
              <th class="column5" style="text-align:center;">שם מוצר</th>
              <th class="column5" style="text-align:center;">קוד משטח</th>
              <th class="column5" style="text-align:center;">כמות יחידות</th>              
              <th class="column5" style="text-align:center;">כמות במארזים</th>
              <th class="column5" style="text-align:center;">מיקום בליקוט</th>       
              <th class="column5" style="text-align:center;">אישור</th>              
            </tr>
          </thead>  
                       <tr id="ro" style="display:none;">
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TxtBarcode" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextShorBarcode" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextProdName" runat="server" ></asp:TextBox></td>
              <%--<td class="column5" style="text-align:center;"> <asp:DropDownList ID="DdlSurfaceId" runat="server" AutoPostBack="true" OnTextChanged="DdlSurfaceId_TextChanged" ><asp:ListItem Text="בחר משטח"  Value="0" Disabled="True" Selected="True" /></asp:DropDownList></td>--%> 
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TexQuantity" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextQuantityUnitsPeck" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextLocatorName" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:Button ID="Button1"  runat="server" Text="אישור ההורדה" OnClick="BtnDownloadOk_Click" /></td>          
            </tr>                
            <asp:Repeater ID="RptTable" runat="server">                
                <ItemTemplate>
                     <tr>
              <td class="column5" style="text-align:center;"><%#Eval("Barcode") %></td>
              <td class="column5" style="text-align:center;"><%#Eval("ShorBarcode") %></td>
              <td class="column5" style="text-align:center;"><%#Eval("ProdName") %></td>
              <td class="column5" style="text-align:center;"><%#Eval("ProdName") %></td>
              <%--<td class="column5" style="text-align:center;"> <asp:DropDownList ID="DdlSurfaceId" runat="server" AutoPostBack="true" OnTextChanged="DdlSurfaceId_TextChanged" ><asp:ListItem Text="בחר משטח"  Value="0" Disabled="True" Selected="True" /></asp:DropDownList></td> --%>
              <%--<td class="column5" style="text-align:center;"><asp:TextBox ID="TexQuantity" runat="server" Text="<%#Eval("Quantity") %>" ></asp:TextBox></td>--%>
                         <td class="column5" style="text-align:center;"><%#Eval("ProdName") %></td>
              <%--<td class="column5" style="text-align:center;"><asp:TextBox ID="TextQuantityUnitsPeck" runat="server" Text="<%#Eval("QuantityUnitsPeck") %>" ></asp:TextBox></td>--%>
                         <td class="column5" style="text-align:center;"><%#Eval("ProdName") %></td>
              <td class="column5" style="text-align:center;"><%#Eval("LocatorName") %></td>
              <td class="column5" style="text-align:center;"><asp:Button ID="Button1"  runat="server" Text="אישור ההורדה" OnClick="BtnDownloadOk_Click" /></td>          
            </tr>            
                   <%-- <tr>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TxtBarcode" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextShorBarcode" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextProdName" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"> <asp:DropDownList ID="DdlSurfaceId" runat="server" AutoPostBack="true" OnTextChanged="DdlSurfaceId_TextChanged" ><asp:ListItem Text="בחר משטח"  Value="0" Disabled="True" Selected="True" /></asp:DropDownList></td> 
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TexQuantity" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextQuantityUnitsPeck" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:TextBox ID="TextLocatorName" runat="server" ></asp:TextBox></td>
              <td class="column5" style="text-align:center;"><asp:Button ID="Button1"  runat="server" Text="אישור ההורדה" OnClick="BtnDownloadOk_Click" /></td>          
            </tr>            --%>                                                   
                </ItemTemplate>
            </asp:Repeater> 
            <tr><td><asp:DropDownList ID="DdlSurfaceId" runat="server" AutoPostBack="true" OnTextChanged="DdlSurfaceId_TextChanged" ><asp:ListItem Text="בחר משטח"  Value="0" Disabled="True" Selected="True" /></asp:DropDownList></td></tr>
        </table>
      </div>
    </div>
  </div>
</div>
    <style>
        .column7{
            text-align:center;vertical-align:middle;width:12.5%; color:#ff0000;cursor:pointer; 
        }
        #Button1{
            text-align:center;vertical-align:middle;width:11%; cursor:pointer; 
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
    function gtag() { dataLayer.push(arguments); }
    gtag('js', new Date());

    gtag('config', 'UA-23581568-13');
</script>
<style>
    .ttt{
        color:#ff0000;
    }
</style>

</asp:Content>


<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="limiter">
  <div class="container-table100">
    <div class="wrap-table100">
       <a href="addSupplier.aspx" >הוספת ספק חדש</a>
      <div class="table100" >                   
        <table>
          <thead>
            <tr class="table100-head">
              <th class="column1" style="text-align:center;width:12.5%;">קוד ספק</th>
              <th class="column2" style="text-align:center;width:12.5%;">שם</th>
              <th class="column3" style="text-align:center;width:12.5%;">טלפון</th>
              <th class="column4" style="text-align:center;width:12.5%;">אימייל</th>
              <th class="column5" style="text-align:center;width:12.5%;">קטגוריה</th>              
              <th class="column5" style="text-align:center;width:12.5%;">מחיקה</th>
              <th class="column5" style="text-align:center;width:12.5%;">עריכה</th>              
            </tr>
          </thead>  
              <asp:Repeater ID="RptTable" runat="server">                
                <ItemTemplate>
                    <tr>
              <td class="column1" style="text-align:center;width:12.5%;"></td>
              <td class="column2" style="text-align:center;width:12.5%;"></td>
              <td class="column3" style="text-align:center;width:12.5%;"></td>
              <td class="column4" style="text-align:center;width:12.5%;"></td>
              <td class="column5" style="text-align:center;width:12.5%;"></td>
              <td class="column7" ><a href="removSupplier.aspx" >מחיקה</a></td>
              <td class="column7" ><a href="addSupplier.aspx" >עריכה</a></td>              
            </tr>                                                          
                </ItemTemplate>
            </asp:Repeater>                               
        </table>
      </div>
    </div>
  </div>
</div>
    <style>
        .column7{
            text-align:center;vertical-align:middle;width:12.5%; color:#ff0000;cursor:pointer; 
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
</asp:Content>--%>

