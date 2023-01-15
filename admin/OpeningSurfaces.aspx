<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="OpeningSurfaces.aspx.cs" Inherits="Sstorage.admin.OpeningSurfaces" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>פתיחת משטח חדש | Sstorage</title>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="limiter">
        <div class="container-table100" >
            <div class="wrap-table100" >
    
        <br />
        <br />
        <center>
            <h1 style="text-align:center; padding:0px 200px 0px 0px;">פתיחת משטח חדש</h1> 
            <div class="table100" id="tab" style="align-content:center; width:1000px; align-items:center; padding:0px 100px 0px 0px;" >                   
        <table>
          <thead>
            <tr class="table100-head">
              <th class="column1" style="text-align:center;width:25%;">שם מוצר</th>
              <th class="column2" style="text-align:center;width:25%;">כמות ביחידות</th>                                   
              <th class="column4" style="text-align:center;width:25%;">כמות בקרטונים</th>    
                <th class="column3" style="text-align:center;width:25%;">הערות</th>    
            </tr>
          </thead>
               <tr>
              <td class="column1" style="text-align:center;width:25%;" > <asp:DropDownList ID="DdlProdId"  runat="server"></asp:DropDownList></td>
              <td class="column2" style="text-align:center;width:25%;" ><asp:TextBox ID="TxtQytUnits" Width="100"  CssClass="t" runat="server"></asp:TextBox></td>
                   <td class="column2" style="text-align:center;width:25%;" ><asp:TextBox ID="TxtQytBaxs" Width="100"  CssClass="t" runat="server"></asp:TextBox></td>
                   <td class="column2" style="text-align:center;width:25%;" > <asp:TextBox ID="TxtRemarks" TextMode="MultiLine" Columns="40" Rows="2" runat="server" /></td>
              
            </tr>
            </table>
            <%--<table style="width:1005px;" border="1">                
                <tr>
                    <td style="width:50%;height:50px;font-size:30px;color:#0094ff;text-align:center;">
                        שם מוצר
                    </td>
                    <td style="width:50%;height:50px;font-size:30px;color:#da56fb;text-align:center;">
                        <asp:DropDownList ID="DdlProdId" Width="500" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%;height:50px;font-size:30px;color:#0094ff;text-align:center;">
                        כמות ביחידות
                    </td>
                    <td style="width:50%;height:50px;font-size:30px;color:#da56fb;text-align:center;">
                         <asp:TextBox ID="TxtQytUnits" Width="100" runat="server"></asp:TextBox>
                    </td>
                </tr>                
                <tr>
                    <td style="width:50%;height:50px;font-size:30px;color:#0094ff;text-align:center;">
                        כמות בקרטונים
                    </td>
                    <td style="width:50%;height:50px;font-size:30px;color:#da56fb;text-align:center;">
                        <asp:TextBox ID="TxtQytBaxs" Width="100" runat="server"></asp:TextBox>
                    </td>
                </tr>                
                <tr>
                    <td style="width:50%;height:50px;font-size:30px;color:#0094ff;text-align:center;">
                        הערות
                    </td>
                    <td style="width:50%;height:50px;font-size:30px;color:#da56fb;text-align:center;">
                        <asp:TextBox ID="TxtRemarks" TextMode="MultiLine" Columns="25" Rows="2" runat="server" />
                    </td>
                </tr>
            </table>--%>
            <br />
            <span style="font-size:18px;">
                <asp:Literal ID="LtlOpenSurface" runat="server" /><br />
                <asp:Literal ID="Literal1" runat="server" />
            </span>
            
            <br /><br />
            <asp:Button ID="BtnOk" class="btn btn-primary" Text="אישור" runat="server" OnClick="BtnOk_Click" />
            <br />
        </center>
    </div>
</div>
       </div>
    </div>
    <style>
        .t{
            border-width: 1px;
            border-color:#000000;
        }
    </style>
</asp:Content>
