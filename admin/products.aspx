<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="Sstorage.admin.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title> מוצרים | Sstorage</title>
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
                 הוספת מוצר חדש
              </button>
              <br />
                <div id="Hidden"></div>
                <div id="Hidden10"></div>
                <div id="Hid"></div>
                <div id="Hid2"></div>
                <div id="Hid12"></div>
            </div>
                <div class="table100" id="tab" >                   
                     <table>
                         <thead>
            <tr class="table100-head">
              <th class="column1" style="text-align:center;width:12.5%;">שם מוצר</th>
              <th class="column2" style="text-align:center;width:12.5%;">תאור</th>
              <th class="column2" style="text-align:center;width:12.5%;">קטגוריה</th>
              <th class="column2" style="text-align:center;width:12.5%;">ספק</th>
              <th class="column3" style="text-align:center;width:12.5%;">ברקוד</th>
              <th class="column4" style="text-align:center;width:12.5%;">מקט</th>                                        
              <th class="column5" style="text-align:center;width:12.5%;">מחיר</th>
                <th class="column5" style="text-align:center;width:12.5%;">עריכה</th>
            </tr>
          </thead>  
              <asp:Repeater ID="RptTable" runat="server">                
                <ItemTemplate>
                    <tr>
              <td class="column1" style="text-align:center;width:12.5%;" ><%#Eval("ProdName") %></td>
              <td class="column2" style="text-align:center;width:12.5%;" ><%#Eval("ProdDesc") %></td>
              <td class="column1" style="text-align:center;width:12.5%;" ><%#Eval("CatName") %></td>
              <td class="column2" style="text-align:center;width:12.5%;" ><%#Eval("SupplierName") %></td>
              <td class="column3" style="text-align:center;width:12.5%;" ><%#Eval("Barcode") %></td>
              <td class="column4" style="text-align:center;width:12.5%;" ><%#Eval("ShorBarcode") %></td>              
              <td class="column5" style="text-align:center;width:12.5%;"><%#Eval("Price") %> ש"ח</td>
              <td class="column7"><i class='fa fa-edit' data-toggle="modal" data-target="#exampleModal2" onclick='y(<%#Eval("ProdId") %>)' style="font-size:16px;color:#0026ff;"></i></td>
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
              <center><h5 style="font-size: 18px;font-family: 'Perpetua';" class="modal-title" id="exampleModalLabel">הוספת מוצר חדש</h5></center>
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
                                 שם מוצר
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                  <span class="at1">
                                    <asp:TextBox ID="TxtName" runat="server" onkeyup="validationName()" />                             
                               </span>                                  
                              </center>
                          </td>   
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                תאור
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtDesc" runat="server" onkeyup="validationDesc()" />                             
                               </span>
                              </center>
                          </td> 
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                קטגוריה
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>                                                                                                       
                                    <asp:DropDownList ID="DdlCat" CssClass="ddl" onchange="validationText()"  runat="server" />                               
                              </center>                              
                          </td> 
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                ספק
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>                                                                                                       
                                    <asp:DropDownList ID="DdlSup" CssClass="ddl" onchange="validationText()"  runat="server" />                               
                              </center> 
                          </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 ברקוד
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtBarcode" runat="server" onkeyup="validationBarcode()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 מקט
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtShorBarcode" runat="server" onkeyup="validationShorBarcode()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 מחיר
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtPrice" runat="server" onkeyup="validationPrice()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                   </table>
                <br />                            
            </div>
            <div class="modal-footer" id="footer">
                  <asp:Button ID="BtnAdPr" disabled style="cursor: no-drop;"   CssClass="btn btn-primary" runat="server" Text="אישור" OnClick="BtnProdAdd_Click" />             
            </div>
          </div>
        </div>
      </div>



      <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <center><h5 style="font-size: 18px;font-family: 'Perpetua';" class="modal-title" id="exampleModalLabel2">עריכת פרטי מוצר</h5></center>
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
                                 שם מוצר
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
                                תאור
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtDesc2" runat="server" onkeyup="validationDesc2()" />                             
                               </span>
                              </center>
                          </td> 
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                קטגוריה
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>                                                                                                       
                                    <asp:DropDownList ID="DdlCat2" CssClass="ddl" onchange="validationText2()"  runat="server" />                               
                              </center>
                          </td> 
                      </tr>
                      <tr>
                          <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                              <center>                    
                                ספק
                              </center>
                          </td>
                          <td style="width:50%;background-color:#ffffff;">
                              <center>                                                                                                       
                                    <asp:DropDownList ID="DdlSup2" CssClass="ddl" onchange="validationText2()"  runat="server" />                               
                              </center>
                          </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 ברקוד
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtBarcode2" runat="server" onkeyup="validationBarcode2()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 מקט
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtShorBarcode2" runat="server" onkeyup="validationShorBarcode2()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                      <tr>
                         <td style="width:50%;background-color:#ffffff;font-family: 'Perpetua';font-size: 18px;color:#000000;">                
                             <center>                    
                                 מחיר
                             </center>
                         </td>
                         <td style="width:50%;background-color:#ffffff;">
                             <center>
                                <span class="at1">
                                    <asp:TextBox ID="TxtPrice2" runat="server" onkeyup="validationPrice2()" />                                 
                                </span>
                             </center>
                         </td> 
                      </tr>
                   </table>
                <br />                            
            </div>
            <div class="modal-footer" id="footer">
                <asp:Button ID="BtnAddPr2"   CssClass="btn btn-primary" runat="server" Text="אישור" OnClick="BtnProdAdd2_Click" />             
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
    var name = '', desc = '', cat = '', sup = '', barcode = '', shorBarcode = '', price = ''
    var arr = [];    
    function z(str) {
        console.log(str)
        for (let i = 0; i < str.length; i++)
            if (str[i] == '#')
                arr.push({});
        var size = 0;
        var ProdId, Name, Desc, Barcode, ShorBarcode, Price, Cat, Sup
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
                        ProdId = str.substring(j, (j + k));
                        arr[size].ProdId = ProdId;
                    }
                    else if (str[j - 1] == '*' && num == 2) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        Barcode = str.substring(j, (j + k));
                        arr[size].Barcode = Barcode;
                    }
                    else if (str[j - 1] == '*' && num == 3) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        ShorBarcode = str.substring(j, (j + k));
                        arr[size].ShorBarcode = ShorBarcode;
                    }
                    else if (str[j - 1] == '*' && num == 4) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        Cat = str.substring(j, (j + k));
                        arr[size].Cat = Cat;
                    }
                    else if (str[j - 1] == '*' && num == 5) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        Sup = str.substring(j, (j + k));
                        arr[size].Sup = Sup;
                    }
                    else if (str[j - 1] == '*' && num == 6) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        Price = str.substring(j, (j + k));
                        arr[size].Price = Price;
                    }
                    else if (str[j - 1] == '*' && num == 7) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        Name = str.substring(j, (j + k));
                        arr[size].Name = Name;
                    }
                    else if (str[j - 1] == '*' && num == 8) {
                        let k = 0;
                        for (let a = j; str[a] != '#'; a++, k++) { }
                        Desc = str.substring(j, (j + k));
                        arr[size].Desc = Desc;
                    }
                }
                size++;
            }
        }
    }
    function y(id) {
        console.log(arr)
        for (var i = 0; i < arr.length; i++) {
            if (arr[i].ProdId == id) {           
                document.getElementById('<%= TxtName2.ClientID %>').value = arr[i].Name
                document.getElementById('<%= TxtDesc2.ClientID %>').value = arr[i].Desc
                document.getElementById('<%= DdlCat2.ClientID %>').value = arr[i].Cat
                document.getElementById('<%= DdlSup2.ClientID %>').value = arr[i].Sup
                document.getElementById('<%= TxtBarcode2.ClientID %>').value = arr[i].Barcode
                document.getElementById('<%= TxtShorBarcode2.ClientID %>').value = arr[i].ShorBarcode
                document.getElementById('<%= TxtPrice2.ClientID %>').value = arr[i].Price               
            }
        }
        str = '<asp:HiddenField ID="Hidden3" runat="server"  ></asp:HiddenField> '
        document.getElementById('Hid').innerHTML = str
        document.getElementById('<%= Hidden3.ClientID %>').value = id
    }
    function validationText() {
        cat = document.getElementById('<%= DdlCat.ClientID %>').value.trim();
        sup = document.getElementById('<%= DdlSup.ClientID %>').value.trim();
        if (name != '' && desc != '' && cat != '' && sup != '' && barcode != '' && shorBarcode != '' && price != '') {
            var str1 = '<asp:Button ID="BtnAddPr" CssClass="btn btn-primary" runat="server"  Text="אישור" OnClick="BtnProdAdd_Click"  />'                
            var str2 = '<asp:HiddenField ID="Hidden1" runat="server"  ></asp:HiddenField> '
            var str3 = '<asp:HiddenField ID="Hidden5" runat="server"  ></asp:HiddenField> '
            document.getElementById('footer').innerHTML = str1
            document.getElementById('Hidden').innerHTML = str2
            document.getElementById('<%= Hidden1.ClientID %>').value = cat 
            document.getElementById('Hidden10').innerHTML = str3
            document.getElementById('<%= Hidden5.ClientID %>').value = sup
        }        
        else {
            var str = '<asp:Button ID="BtnAPr" disabled style="cursor: no-drop;" CssClass="btn btn-primary" runat="server"  Text="אישור"   />'
            document.getElementById('footer').innerHTML = str
        }

    }       
    function validationName() {
        name = ''
        name = document.getElementById('<%= TxtName.ClientID %>').value.trim();
        validationText()
    }
    function validationDesc() {
        desc = ''
        desc = document.getElementById('<%= TxtDesc.ClientID %>').value.trim();
        validationText()
    }            
    function validationBarcode() {
        barcode = ''
        barcode = document.getElementById('<%= TxtBarcode.ClientID %>').value.trim();
        validationText()
    }
    function validationShorBarcode() {
        shorBarcode = ''
        shorBarcode = document.getElementById('<%= TxtShorBarcode.ClientID %>').value.trim();
        validationText()
    }
    function validationPrice() {
        price = ''
        price = document.getElementById('<%= TxtPrice.ClientID %>').value.trim();
        validationText()
    }
    
    
    function validationText2() {
        cat = document.getElementById('<%= DdlCat2.ClientID %>').value.trim();
        sup = document.getElementById('<%= DdlSup2.ClientID %>').value.trim();
        var str1 = '<asp:HiddenField ID="Hidden4" runat="server"  ></asp:HiddenField> '
        var str2 = '<asp:HiddenField ID="Hidden6" runat="server"  ></asp:HiddenField> '
        console.log(cat)
        console.log(sup)
        document.getElementById('Hid2').innerHTML = str1
        document.getElementById('<%= Hidden4.ClientID %>').value = cat
        document.getElementById('Hid12').innerHTML = str2
        document.getElementById('<%= Hidden6.ClientID %>').value = sup
    }
    function validationName2() {
        name = ''
        name = document.getElementById('<%= TxtName2.ClientID %>').value.trim();
        validationText2()
    }
    function validationDesc2() {
        desc = ''
        desc = document.getElementById('<%= TxtDesc2.ClientID %>').value.trim();
        validationText2()
    }       
    function validationBarcode2() {
        barcode = ''
        barcode = document.getElementById('<%= TxtBarcode2.ClientID %>').value.trim();
        validationText2()
    }
    function validationShorBarcode2() {
        shorBarcode = ''
        shorBarcode = document.getElementById('<%= TxtShorBarcode2.ClientID %>').value.trim();
        validationText2()
    }
    function validationPrice2() {
        price = ''
        price = document.getElementById('<%= TxtPrice2.ClientID %>').value.trim();
        validationText2()
    }
</script> 


</asp:Content>
