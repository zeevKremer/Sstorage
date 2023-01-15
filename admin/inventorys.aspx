<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="inventorys.aspx.cs" Inherits="Sstorage.admin.inventorys" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <title> מלאים  | Sstorage</title> 
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
        <center>
            <div style="padding:0px 290px 7px 0px;">
              חיפוש מוצר                
                 <asp:DropDownList ID="DdlSerch" runat="server" OnTextChanged="DdlSerch_TextChanged" AutoPostBack="true"  Width="200" >                 
                 </asp:DropDownList>
            </div>                     
      <div class="table100"  id="tab" >                   
        <table>
          <thead>
            <tr class="table100-head">
              <th class="column1" style="text-align:center;width:12.5%;">קוד סניף</th>
              <th class="column2" style="text-align:center;width:12.5%;">שם</th>
              <th class="column3" style="text-align:center;width:12.5%;">כמות ביחידות</th>
              <%--<th class="column4" style="text-align:center;width:12.5%;">מיקומים</th>--%>                      
            </tr>
          </thead>
              <asp:Repeater ID="RptTable" runat="server">                
                <ItemTemplate>
                    <tr>
              <td class="column1" style="text-align:center;width:12.5%;" ><%#Eval("StoragesLocatorId") %></td>
              <td class="column2" style="text-align:center;width:12.5%;" ><%#Eval("StorageName") %></td>
              <td class="column3" style="text-align:center;width:12.5%;" ><%#Eval("Quantity") %></td>
              <%--<td class="column4" style="text-align:center;width:12.5%;" id="<%#Eval("StoragesLocatorId") %>"><%#Eval("LocatorName") %></td>              --%>
            </tr>                                                          
                </ItemTemplate>
            </asp:Repeater>                               
        </table>  
          <br />
          <br />
          
      </div>
    </center>                   
    </div>
  </div>
</div>




<style>
        #tab{
            width:1000px;
            padding:0px 150px 6px 0px;
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
        var arrLocators  = []
        var arrSurfaces = []
        var index
        function slieder(id) {
            document.getElementById("" + id).classList.toggle('closed');
        }
        function func1(str) {
            console.log(str)            
            for (let i = 0; i < str.length; i++)
                if (str[i] == '#')
                    arrLocators.push({});
            var size = 0;
            var StorageId, LocatorName, Quantity, num;
            for (var i = 1;  str[i+1] != '$'; i++) {
                console.log("נכנסתי 1")
                if (str[i - 1] == '$' || str[i - 1] == '#') {
                    for (var j = i, num = 0; str[j] != '#'; j++) {
                        if (str[j] == '*') {
                            num++;
                            j++;
                        }
                        if (str[j - 1] == '*' && num == 1) {
                            let k = 0;
                            for (let a = j; str[a] != '*'; a++, k++) { }
                            StorageId = str.substring(j, (j + k));
                            arrLocators[size].StorageId = StorageId;
                        }
                        else if (str[j - 1] == '*' && num == 2) {
                            let k = 0;
                            for (let a = j; str[a] != '*'; a++, k++) { }
                            LocatorName = str.substring(j, (j + k));
                            arrLocators[size].LocatorName = LocatorName;
                        }
                        else if (str[j - 1] == '*' && num == 3) {
                            let k = 0;
                            for (let a = j; str[a] != '#'; a++, k++) { }
                            Quantity = str.substring(j, (j + k));
                            arrLocators[size].Quantity = Quantity;
                        }
                    }
                    size++;
                }
            }
            var html = `<i class="fa fa-angle-down" onclick=func2(${arrLocators[0].StorageId}) style="cursor:pointer;font-size:24px;color:#0026ff;"></i>`
            document.getElementById('' + arrLocators[0].StorageId).innerHTML = html
            for (index = 1; str[index] != '$'; index++) { }
            str = str.substring(index, str.length)
            if (str.length > 2) {
                console.log("נכנסתי 2")
                for (let i = 0; i < str.length; i++)
                    if (str[i] == '#')
                        arrSurfaces.push({});
                var size = 0;             
                var StorageId, SurfaceId, LocatorName, Quantity, num;
                for (var i = 1; i < str[i] != '$'; i++) {
                    if (str[i - 1] == '$' || str[i - 1] == '#') {
                        for (var j = i, num = 0; str[j] != '#'; j++) {
                            if (str[j] == '*') {
                                num++;
                                j++;
                            }
                            if (str[j - 1] == '*' && num == 1) {
                                let k = 0;
                                for (let a = j; str[a] != '*'; a++, k++) { }
                                StorageId = str.substring(j, (j + k));
                                arrSurfaces[size].StorageId = StorageId;
                            }
                            else if (str[j - 1] == '*' && num == 2) {
                                let k = 0;
                                for (let a = j; str[a] != '*'; a++, k++) { }
                                SurfaceId = str.substring(j, (j + k));
                                arrSurfaces[size].SurfaceId = SurfaceId;
                            }
                            else if (str[j - 1] == '*' && num == 3) {
                                let k = 0;
                                for (let a = j; str[a] != '*'; a++, k++) { }
                                LocatorName = str.substring(j, (j + k));
                                arrSurfaces[size].LocatorName = LocatorName;
                            }
                            else if (str[j - 1] == '*' && num == 4) {
                                let k = 0;
                                for (let a = j; str[a] != '#'; a++, k++) { }
                                Quantity = str.substring(j, (j + k));
                                arrSurfaces[size].Quantity = Quantity;
                            }
                        }
                        size++;
                    }
                }
            }  
            console.log(arrLocators)
            console.log(arrSurfaces)
        }
        function func2(id) {
            console.log(id)
            var html = '<button style="width:48px;color:black; background-color:red;" onclick="p1(' + id + ');">סגירה</button><br/>';
            html += '<table ><tr class="ro"><td>מיקום</td>';
            html += '<td class="column">כמות</td></tr>';                                
            for (var i = 0; i < arrLocators.length; i++) {
                html += '<tr><td>' + arrLocators[i].LocatorName;
                html += '</td><td>' + arrLocators[i].Quantity;                
                html += '</td></tr>';
            }
            html += '</table>'; 
            document.getElementById("" + id).innerHTML = (html);
            //setTimeout('slieder(' + id + ');return false;', 20);
            setTimeout('p1(' + id + ');', 20);
        }
        function aaa() {
            console.log("aaa");
        }
        function bbb() {
            console.log("bbb");
        }
        function ccc() {
            console.log("ccc");
        }
    </script>
</asp:Content>
