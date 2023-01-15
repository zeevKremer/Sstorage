<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="SurfacesLocatorUpdate.aspx.cs" Inherits="Sstorage.admin.SurfacesLocatorUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>עידכון איתור משטח | Sstorage</title>
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
            <h1 style="text-align:center; padding:0px 200px 0px 0px;">עידכון איתור משטח</h1> 
            <div class="table100" id="tab" style="align-content:center; width:1000px; align-items:center; padding:0px 100px 0px 0px;" >                   
        <table>
          <thead>
            <tr class="table100-head">
              <th class="column1" style="text-align:center;width:25%;">מספר משטח</th>
              <th class="column2" style="text-align:center;width:25%;">איתור חדש</th>                                                    
            </tr>
          </thead>
               <tr>
              <td class="column1" style="text-align:center;width:25%;" ><asp:TextBox ID="TxtSurfaceId" runat="server" />
                    </td>
              <td class="column2" style="text-align:center;width:25%;" ><asp:TextBox ID="TxtSurfaceLocator" runat="server" /></td>
                  
              
            </tr>
            </table>
                <br />
            <span style="font-size:18px;">
                <asp:Literal ID="LtlOK" runat="server" />
            </span>
            
            <br /><br />
           <asp:Button ID="BtnSubmit" class="btn btn-primary" Text="אישור" runat="server" OnClick="BtnSubmit_Click" />
            <br />
        </center>
    </div>
</div>
       </div>
    


<%--<div class="limiter">
        <div class="container-table100" >
<div>
        <br />
        <br />

        <center>
            <h1>עידכון איתור משטח  </h1>
            <table style="width:1005px;" border="1" >
                <tr>
                    <td style="width:50%;height:50px;font-size:30px;color:#0094ff;text-align:center;">
                        מספר משטח
                    </td>
                    <td style="width:50%;height:50px;font-size:30px;color:#da56fb;text-align:center;">
                        <asp:TextBox ID="TxtSurfaceId" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td style="width:50%;height:50px;font-size:30px;color:#0094ff;text-align:center;">
                        איתור חדש
                    </td>
                    <td style="width:50%;height:50px;font-size:30px;color:#da56fb;text-align:center;">
                        <asp:TextBox ID="TxtSurfaceLocator" runat="server" />
                    </td>
                </tr>
                </table>
            <br />
            <span style="font-size:18px;">
                <asp:Literal ID="LtlOK" runat="server" />
            </span>
            <br />
            <asp:Button ID="BtnSubmit" class="btn btn-primary" Text="אישור" runat="server" OnClick="BtnSubmit_Click" />
            <br /><br />
            </center>
    </div>
            </div>
    </div>--%>
</asp:Content>
