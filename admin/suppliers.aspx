<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="suppliers.aspx.cs" Inherits="Sstorage.admin.suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title> ספקים | Sstorage</title>
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
                 הוספת ספק חדש
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
              <th class="column1" style="text-align:center;width:12.5%;">קוד ספק</th>
              <th class="column2" style="text-align:center;width:12.5%;">שם</th>
              <th class="column3" style="text-align:center;width:12.5%;">טלפון</th>
              <th class="column4" style="text-align:center;width:12.5%;">אימייל</th>
              <th class="column5" style="text-align:center;width:12.5%;">קטגוריה</th>                          
              <th class="column5" style="text-align:center;width:12.5%;">עריכה</th>              
            </tr>
          </thead>  
              <asp:Repeater ID="RptTable" runat="server">                
                <ItemTemplate>
                    <tr>
              <td class="column1" style="text-align:center;width:12.5%;" ><%#Eval("SupplierId") %></td>
              <td class="column2" style="text-align:center;width:12.5%;" ><%#Eval("SupplierName") %></td>
              <td class="column3" style="text-align:center;width:12.5%;" ><%#Eval("SupplierPhone") %></td>
              <td class="column4" style="text-align:center;width:12.5%;" ><%#Eval("SupplierEmail") %></td>
              <td class="column5" style="text-align:center;width:12.5%;"><%#Eval("CatName") %></td>              
              <td class="column7"><i class='fa fa-edit' data-toggle="modal" data-target="#exampleModal2" onclick='y(<%#Eval("SupplierId") %>)' style="font-size:16px;color:#0026ff;"></i></td>
            </tr>                                                          
                </ItemTemplate>
            </asp:Repeater>                               
        </table>         
      </div>
    </center>              
      <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <center><h5 style="font-size: 18px;font-family: 'Perpetua';" class="modal-title" id="exampleModalLabel">הוספת ספק חדש</h5></center>
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
                                 קטגוריה
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                  <asp:DropDownList ID="DdlCategorys" CssClass="ddl" onchange="validationText()" runat="server" />                                  
                              </center>
                          </td>   
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                שם ספק
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                <span class="at1" >
                                    <asp:TextBox ID="TxtName" runat="server" onkeyup="validationName()" />                             
                               </span>
                              </center>
                          </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 טלפון
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtPhone" runat="server" onkeyup="validationPhone()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                דואר אלקטרוני
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                  <span class="at1">
                                   <asp:TextBox ID="TxtEmail" runat="server" onkeyup="validationEmail()" />                                                                        
                                  </span>
                              </center>
                          </td> 
                      </tr>                                                                        
                   </table>
                <br />                            
            </div>
            <div class="modal-footer" id="footer">                             
              <asp:Button ID="BtnAddSp" disabled style="cursor: no-drop;" CssClass="btn btn-primary" runat="server" CommandArgument=""  Text="אישור" OnClick="BtnAddSupp_Click"  />                                       
            </div>
          </div>
        </div>
      </div>



      <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <center><h5 style="font-size: 18px;font-family: 'Perpetua';" class="modal-title" id="exampleModalLabel2">עריכת פרטי ספק</h5></center>
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
                                 קטגוריה
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                  <asp:DropDownList ID="DdlCategorys2" CssClass="ddl" onchange="validationText2()"  runat="server" />                                  
                              </center>
                          </td>   
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                שם ספק
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtName2" runat="server" onkeyup="validationName2()" />                             
                               </span>
                              </center>
                          </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 טלפון
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtPhone2" runat="server" onkeyup="validationPhone2()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                דואר אלקטרוני
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                  <span class="at1">
                                   <asp:TextBox ID="TxtEmail2" runat="server" onkeyup="validationEmail2()" />                                                                        
                                  </span>
                              </center>
                          </td> 
                      </tr>                                                                        
                   </table>
                <br />                            
            </div>
            <div class="modal-footer" id="footer">                             
              <asp:Button ID="BtnAddSp2"  CssClass="btn btn-primary" runat="server" CommandArgument=""  Text="אישור" OnClick="BtnAddSp2_Click"  />                                        
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
    var name = '', phone = '', email = '', cat = '', name5 = '', cat5 = ''         
    var arr = [];
    function z(str) {
        console.log(str)
        for (let i = 0; i < str.length; i++)
            if (str[i] == '#')
                arr.push({});
        var size = 0;
        var SupId, SupName, SupPhone, SupEmail, CatId
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
                        SupId = str.substring(j, (j + k));
                        arr[size].SupId = SupId;
                    }
                    else if (str[j - 1] == '*' && num == 2) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        SupName = str.substring(j, (j + k));
                        arr[size].SupName = SupName;
                    }
                    else if (str[j - 1] == '*' && num == 3) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        SupPhone = str.substring(j, (j + k));
                        arr[size].SupPhone = SupPhone;
                    }
                    else if (str[j - 1] == '*' && num == 4) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        SupEmail = str.substring(j, (j + k));
                        arr[size].SupEmail = SupEmail;
                    }
                    else if (str[j - 1] == '*' && num == 5) {
                        let k = 0;
                        for (let a = j; str[a] != '#'; a++, k++) { }
                        CatId = str.substring(j, (j + k));
                        arr[size].CatId = CatId;
                    }
                }
                size++;
            }
        }               
    }
    function y(id) {   
        console.log(arr)
        for (var i = 0; i < arr.length; i++) {
            if (arr[i].SupId == id) {
                document.getElementById('<%= DdlCategorys2.ClientID %>').value = arr[i].CatId
                document.getElementById('<%= TxtName2.ClientID %>').value = arr[i].SupName
                document.getElementById('<%= TxtPhone2.ClientID %>').value = arr[i].SupPhone
                document.getElementById('<%= TxtEmail2.ClientID %>').value = arr[i].SupEmail
            }
        }                 
        str = '<asp:HiddenField ID="Hidden3" runat="server"  ></asp:HiddenField> '
        document.getElementById('Hid').innerHTML = str                
        document.getElementById('<%= Hidden3.ClientID %>').value = id
    }
    function validationText() { 
        cat = document.getElementById('<%= DdlCategorys.ClientID %>').value.trim();                
        if (name != '' && phone != '' && email != '' ) {                      
            var str1 = '<asp:Button ID="BtnAddSupp" CssClass="btn btn-primary" runat="server"  Text="אישור" OnClick="BtnAddSupp_Click"  />'
            var str2 = '<asp:HiddenField ID="Hidden1" runat="server"  ></asp:HiddenField> '
            document.getElementById('footer').innerHTML = str1
            document.getElementById('Hidden').innerHTML = str2
            document.getElementById('<%= Hidden1.ClientID %>').value = cat                      
        }        
        else {
            var str = '<asp:Button ID="BtnASupp" disabled style="cursor: no-drop;" CssClass="btn btn-primary" runat="server"  Text="אישור" OnClick="BtnAddSupp_Click"  />'
            document.getElementById('footer').innerHTML = str
        }

    }
    function validationText2() {
        cat = document.getElementById('<%= DdlCategorys2.ClientID %>').value.trim();
        console.log(cat)
            var str1 = '<asp:HiddenField ID="Hidden4" runat="server"  ></asp:HiddenField> '         
            document.getElementById('Hid2').innerHTML = str1
            document.getElementById('<%= Hidden4.ClientID %>').value = cat
        }   
    function validationName() {
        name = ''
        name = document.getElementById('<%= TxtName.ClientID %>').value.trim();        
        validationText()
    }
    function validationPhone() {
        phone = ''
        phone = document.getElementById('<%= TxtPhone.ClientID %>').value.trim();      
        validationText()
    }
    function validationEmail() {
        email = ''
        email = document.getElementById('<%= TxtEmail.ClientID %>').value.trim();                
        validationText()
    }
    function validationName2() {
        name = ''
        name = document.getElementById('<%= TxtName2.ClientID %>').value.trim();
        validationText2()
        name5 = document.getElementById('<%= TxtName2.ClientID %>').value.trim();
        cat5 = document.getElementById('<%= DdlCategorys2.ClientID %>').value.trim();
        for (var i = 0; i < arr.length; i++) {

            if (arr[i].SupId == cat5)
                arr[i].SupName = name5
        }
        console.log(arr)
    }
    function validationPhone2() {
        phone = ''
        phone = document.getElementById('<%= TxtPhone2.ClientID %>').value.trim();      
        validationText2()
    }
    function validationEmail2() {
        email = ''
        email = document.getElementById('<%= TxtEmail2.ClientID %>').value.trim();
        validationText2()
    }
	  window.dataLayer = window.dataLayer || [];
	  function gtag(){dataLayer.push(arguments);}
	  gtag('js', new Date());

	  gtag('config', 'UA-23581568-13');
</script>                   
</asp:Content>



