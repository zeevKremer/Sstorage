<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="Sstorage.admin.users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">	
<title> משתמשים | Sstorage</title>
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
  <div class="container-table100" >
    <div class="wrap-table100" >
        <center>
            <div style="padding:0px 220px 7px 0px;">
              <button type="button" class="btn btn-primary"  data-toggle="modal" data-target="#exampleModal">
                 הוספת משתמש חדש
              </button>
              <br />
                <div id="Hidden"></div>
                <div id="Hid"></div>
                <div id="Hid2"></div>
            </div>         
      <div class="table100" id="tab" >                   
        <table>
          <thead>
            <tr class="table100-head">
              <th class="column1" style="text-align:center;width:12.5%;">קוד משתמש</th>
              <th class="column2" style="text-align:center;width:12.5%;">שם</th>
              <th class="column3" style="text-align:center;width:12.5%;">סיסמה</th>
              <th class="column4" style="text-align:center;width:12.5%;">רמה</th>
              <th class="column5" style="text-align:center;width:12.5%;">תאריך הוספה</th>                          
              <th class="column5" style="text-align:center;width:12.5%;">עריכה</th>              
            </tr>
          </thead>  
              <asp:Repeater ID="RptTable" runat="server">                
                <ItemTemplate>
                    <tr>
              <td class="column1" style="text-align:center;width:12.5%;" ><%#Eval("UserId") %></td>
              <td class="column2" style="text-align:center;width:12.5%;" ><%#Eval("UserName") %></td>
              <td class="column3" style="text-align:center;width:12.5%;" ><%#Eval("UserPassword") %></td>
              <td class="column4" style="text-align:center;width:12.5%;" ><%#Eval("RatName") %></td>
              <td class="column5" style="text-align:center;width:12.5%;"><%#Eval("AddingDate") %></td>              
              <td class="column7"><i class='fa fa-edit' data-toggle="modal" data-target="#exampleModal2" onclick='y(<%#Eval("UserId") %>)' style="font-size:16px;color:#0026ff;"></i></td>
            </tr>                                                          
                </ItemTemplate>
            </asp:Repeater>                               
        </table>         
      </div>
            <br /><asp:Literal ID="LtlCheck" runat="server" />
    </center> 
        
       <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <center><h5 style="font-size: 18px;font-family: 'Perpetua';" class="modal-title" id="exampleModalLabel">הוספת משתמש חדש</h5></center>
              <button type="button"  class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true" >&times;</span>                  
              </button>
            </div>
            <div class="modal-body">              
                  <br />
                   <table style="width:570px;" border="0">       
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">
                              <center>
                                 רמה
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                  <asp:DropDownList ID="DdlRatings" CssClass="ddl" onchange="validationText()"  runat="server" />                                  
                              </center>
                          </td>   
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                שם משתמש
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtUserName" runat="server" onkeyup="validationUserName()" />                             
                               </span>
                              </center>
                          </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 סיסמה
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtPassword" runat="server" onkeyup="validationPassword()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>                                                                                              
                   </table>
                <br />                            
            </div>
            <div class="modal-footer" id="footer">
                  <asp:Button ID="BtnAdUs" disabled style="cursor: no-drop;"   CssClass="btn btn-primary" runat="server" Text="אישור" OnClick="BtnUsAdd_Click" />             
            </div>
          </div>
        </div>
      </div>



      <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <center><h5 style="font-size: 18px;font-family: 'Perpetua';" class="modal-title" id="exampleModalLabel2">עריכת פרטי משתמש</h5></center>
              <button type="button"  class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true" >&times;</span>                  
              </button>
            </div>
            <div class="modal-body">              
                  <br />
                   <table style="width:570px;" border="0">       
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">
                              <center>
                                 רמה
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                  <asp:DropDownList ID="DdlRatings2" CssClass="ddl" onchange="validationText2()"  runat="server" />                                  
                              </center>
                          </td>   
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                שם משתמש
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtUserName2" runat="server" onkeyup="validationUserName2()" />                             
                               </span>
                              </center>
                          </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 סיסמה
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtPassword2" runat="server" onkeyup="validationPassword2()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>                                                                                              
                   </table>
                <br />                            
            </div>
            <div class="modal-footer" id="footer">
                <asp:Button ID="BtnAddUs2"   CssClass="btn btn-primary" runat="server" Text="אישור" OnClick="BtnUsAdd2_Click" />             
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
<style>
    #tab{
            width:1000px;
            padding:0px 50px 6px 0px;
        }    
        .column7{
            text-align:center;vertical-align:middle;width:12.5%; color:#ff0000;cursor:pointer; 
        }
        .a{
            color:#0026ff;
            font-family: 'Perpetua';
            font-size: 22px;
            
        }
        .a:hover{           
            color:#ffffff;
        } 
        .at1{
            border:1px solid;
            border-color:#808080;
            width:50px;
            color:#000000;
            padding: 4px 4px 4px 4px;
        }
        #at2{
            border:1px solid;
            border-color:#808080;
            width:50px;
            color:#000000;
            padding: 4px 4px 4px 4px;
        }
        #at3{
            border:1px solid;
            border-color:#808080;
            width:50px;
            color:#000000;
            padding: 4px 4px 4px 4px;
        }    
        .ddl{
            width:150px;
            height:27px;
            font-family: 'Perpetua';
            font-size: 18px;
            color:#000000;
        }
    </style>
<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<script src="vendor/bootstrap/js/popper.js"></script>
<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<script src="vendor/select2/select2.min.js"></script>
<script src="js/main.js"></script>
<script src="js/main1.js"></script>
<script>
    var name = '', Password = '', Adding = '', Rating = ''
    var arr = [];
    function z(str) {
        console.log(str)
        for (let i = 0; i < str.length; i++)
            if (str[i] == '#')
                arr.push({});
        var size = 0;
        var UserId, UserName, UserPassword, RaName
        for (var i = 1; i < str.length; i++) {
            if (str[i - 1] == '$' || str[i - 1] == '#') {
                for (var j = i, num = 0; str[j] != '#'; j++) {
                    if (str[j] == '*') {
                        num++;
                        j++;
                    }
                    if (str[j - 1] == '*' && num == 1) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        UserId = str.substring(j, (j + k));
                        arr[size].UserId = UserId;
                    }
                    else if (str[j - 1] == '*' && num == 2) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        UserName = str.substring(j, (j + k));
                        arr[size].UserName = UserName;
                    }
                    else if (str[j - 1] == '*' && num == 3) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        UserPassword = str.substring(j, (j + k));
                        arr[size].UserPassword = UserPassword;
                    }
                    else if (str[j - 1] == '*' && num == 4) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        RaName = str.substring(j, (j + k));
                        arr[size].RaName = RaName;
                    }
                    else if (str[j - 1] == '*' && num == 5) {
                        let k = 0;
                        for (let a = j; str[a] != '#'; a++, k++) { }
                        Adding = str.substring(j, (j + k));
                        arr[size].Adding = Adding;
                    }
                }
                size++;
            }
        }
    }
    function y(id) {
        console.log(arr)
        for (var i = 0; i < arr.length; i++) {
            if (arr[i].UserId == id) {
                document.getElementById('<%= DdlRatings2.ClientID %>').value = arr[i].RaName
                    document.getElementById('<%= TxtUserName2.ClientID %>').value = arr[i].UserName
                    document.getElementById('<%= TxtPassword2.ClientID %>').value = arr[i].UserPassword
            }
        }
        str = '<asp:HiddenField ID="Hidden3" runat="server"  ></asp:HiddenField> '
        document.getElementById('Hid').innerHTML = str
        document.getElementById('<%= Hidden3.ClientID %>').value = id
    }
    function validationText() {
        Rating = document.getElementById('<%= DdlRatings.ClientID %>').value.trim();
            if (name != '' && Password != '') {
                var str1 = '<asp:Button ID="BtnAddUs" CssClass="btn btn-primary" runat="server"  Text="אישור" OnClick="BtnUsAdd_Click"  />'
                var str2 = '<asp:HiddenField ID="Hidden1" runat="server"  ></asp:HiddenField> '                        
                document.getElementById('footer').innerHTML = str1
                document.getElementById('Hidden').innerHTML = str2
                document.getElementById('<%= Hidden1.ClientID %>').value = Rating                      
        }        
        else {
            var str = '<asp:Button ID="BtnAUs" disabled style="cursor: no-drop;" CssClass="btn btn-primary" runat="server"  Text="אישור"   />'
            document.getElementById('footer').innerHTML = str
        }

    }
    function validationText2() {    
        Rating = document.getElementById('<%= DdlRatings2.ClientID %>').value.trim();                                                    
        var str1 = '<asp:HiddenField ID="Hidden4" runat="server"  ></asp:HiddenField> '
        console.log(Rating)
            document.getElementById('Hid2').innerHTML = str1
        document.getElementById('<%= Hidden4.ClientID %>').value = Rating
        }   
    function validationUserName() {
        name = ''
        name = document.getElementById('<%= TxtUserName.ClientID %>').value.trim();        
        validationText()
    }
    function validationPassword() {
        Password = ''
        Password = document.getElementById('<%= TxtPassword.ClientID %>').value.trim();      
        validationText()
    }    
    function validationUserName2() {
        name = ''
        name = document.getElementById('<%= TxtUserName2.ClientID %>').value.trim();        
        validationText2()
    }
    function validationPassword2() {
        Password = ''
        Password = document.getElementById('<%= TxtPassword2.ClientID %>').value.trim();
        validationText2()
    }    
</script> 
<script>
    
	  window.dataLayer = window.dataLayer || [];
	  function gtag(){dataLayer.push(arguments);}
	  gtag('js', new Date());

    gtag('config', 'UA-23581568-13');          
</script>
</asp:Content>
