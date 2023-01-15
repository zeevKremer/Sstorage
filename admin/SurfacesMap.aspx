<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="SurfacesMap.aspx.cs" Inherits="Sstorage.admin.SurfacesMap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>מפת משטחים | Sstorage</title>
<link rel="icon" type="image/png" href="/images/icon.png">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
<span style=" width:350px; padding:70px; direction:ltr;">
        <br />
         <asp:Literal ID="LtlUserDitels" runat="server" />
    </span> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <style>
    /* body{
         background-color: #6fc0f1;
     }*/
     
    .block{
	position:absolute;
	left:50%;
	top:21%;
	width:200px;
	height:200px;
	margin:-100px 0 0 -100px;
    
}
    .t{
        padding:5px;
        width:20px;
        height:20px;
    }
    .tt{
        padding:4px;
        width:4px;
        height:4px;  
        
        
    }
    .ttt2{
         background-color:#f84343;
         width:16px;
         height:16px;
         color:#f84343;       
         cursor: pointer;
    }
    .ttt1{
         background-color:#4cff00;
         width:16px;
         height:16px;
         color:#4cff00;         
         cursor: pointer;
    }
    .tttt{
        padding:6px;
    }
</style>
<script>
    var arr = []     
    const arr1 = ['','A1H1-1', 'A1H1-2', 'A1H1-3', 'A1H2-1', 'A1H2-2', 'A1H2-3', 'A1H3-1', 'A1H3-2', 'A1H3-3',
                     'A2H1-1', 'A2H1-2', 'A2H1-3', 'A2H2-1', 'A2H2-2', 'A2H2-3', 'A2H3-1', 'A2H3-2', 'A2H3-3',
                     'A3H1-1', 'A3H1-2', 'A3H1-3', 'A3H2-1', 'A3H2-2', 'A3H2-3', 'A3H3-1', 'A3H3-2', 'A3H3-3',
                     'A4H1-1', 'A4H1-2', 'A4H1-3', 'A4H2-1', 'A4H2-2', 'A4H2-3', 'A4H3-1', 'A4H3-2', 'A4H3-3',
                     'A5H1-1', 'A5H1-2', 'A5H1-3', 'A5H2-1', 'A5H2-2', 'A5H2-3', 'A5H3-1', 'A5H3-2', 'A5H3-3',
                     'A6H1-1', 'A6H1-2', 'A6H1-3', 'A6H2-1', 'A6H2-2', 'A6H2-3', 'A6H3-1', 'A6H3-2', 'A6H3-3',
                     'A7H1-1', 'A7H1-2', 'A7H1-3', 'A7H2-1', 'A7H2-2', 'A7H2-3', 'A7H3-1', 'A7H3-2', 'A7H3-3',
                     'A8H1-1', 'A8H1-2', 'A8H1-3', 'A8H2-1', 'A8H2-2', 'A8H2-3', 'A8H3-1', 'A8H3-2', 'A8H3-3',
                     'A9H1-1', 'A9H1-2', 'A9H1-3', 'A9H2-1', 'A9H2-2', 'A9H2-3', 'A9H3-1', 'A9H3-2', 'A9H3-3',
                     'A10H1-1', 'A10H1-2', 'A10H1-3', 'A10H2-1', 'A10H2-2', 'A10H2-3', 'A10H3-1', 'A10H3-2', 'A10H3-3',
                     'B1H1-1', 'B1H1-2', 'B1H1-3', 'B1H2-1', 'B1H2-2', 'B1H2-3', 'B1H3-1', 'B1H3-2', 'B1H3-3',
                     'B2H1-1', 'B2H1-2', 'B2H1-3', 'B2H2-1', 'B2H2-2', 'B2H2-3', 'B2H3-1', 'B2H3-2', 'B2H3-3',
                     'B3H1-1', 'B3H1-2', 'B3H1-3', 'B3H2-1', 'B3H2-2', 'B3H2-3', 'B3H3-1', 'B3H3-2', 'B3H3-3',
                     'B4H1-1', 'B4H1-2', 'B4H1-3', 'B4H2-1', 'B4H2-2', 'B4H2-3', 'B4H3-1', 'B4H3-2', 'B4H3-3',
                     'B5H1-1', 'B5H1-2', 'B5H1-3', 'B5H2-1', 'B5H2-2', 'B5H2-3', 'B5H3-1', 'B5H3-2', 'B5H3-3',
                     'B6H1-1', 'B6H1-2', 'B6H1-3', 'B6H2-1', 'B6H2-2', 'B6H2-3', 'B6H3-1', 'B6H3-2', 'B6H3-3',
                     'B7H1-1', 'B7H1-2', 'B7H1-3', 'B7H2-1', 'B7H2-2', 'B7H2-3', 'B7H3-1', 'B7H3-2', 'B7H3-3',
                     'B8H1-1', 'B8H1-2', 'B8H1-3', 'B8H2-1', 'B8H2-2', 'B8H2-3', 'B8H3-1', 'B8H3-2', 'B8H3-3',
                     'B9H1-1', 'B9H1-2', 'B9H1-3', 'B9H2-1', 'B9H2-2', 'B9H2-3', 'B9H3-1', 'B9H3-2', 'B9H3-3',
                     'B10H1-1', 'B10H1-2', 'B10H1-3', 'B10H2-1', 'B10H2-2', 'B10H2-3', 'B10H3-1', 'B10H3-2', 'B10H3-3',
                     'C1H1-1', 'C1H1-2', 'C1H1-3', 'C1H2-1', 'C1H2-2', 'C1H2-3', 'C1H3-1', 'C1H3-2', 'C1H3-3',
                     'C2H1-1', 'C2H1-2', 'C2H1-3', 'C2H2-1', 'C2H2-2', 'C2H2-3', 'C2H3-1', 'C2H3-2', 'C2H3-3',
                     'C3H1-1', 'C3H1-2', 'C3H1-3', 'C3H2-1', 'C3H2-2', 'C3H2-3', 'C3H3-1', 'C3H3-2', 'C3H3-3',
                     'C4H1-1', 'C4H1-2', 'C4H1-3', 'C4H2-1', 'C4H2-2', 'C4H2-3', 'C4H3-1', 'C4H3-2', 'C4H3-3',
                     'C5H1-1', 'C5H1-2', 'C5H1-3', 'C5H2-1', 'C5H2-2', 'C5H2-3', 'C5H3-1', 'C5H3-2', 'C5H3-3',
                     'C6H1-1', 'C6H1-2', 'C6H1-3', 'C6H2-1', 'C6H2-2', 'C6H2-3', 'C6H3-1', 'C6H3-2', 'C6H3-3',
                     'C7H1-1', 'C7H1-2', 'C7H1-3', 'C7H2-1', 'C7H2-2', 'C7H2-3', 'C7H3-1', 'C7H3-2', 'C7H3-3',
                     'C8H1-1', 'C8H1-2', 'C8H1-3', 'C8H2-1', 'C8H2-2', 'C8H2-3', 'C8H3-1', 'C8H3-2', 'C8H3-3',
                     'C9H1-1', 'C9H1-2', 'C9H1-3', 'C9H2-1', 'C9H2-2', 'C9H2-3', 'C9H3-1', 'C9H3-2', 'C9H3-3',
                     'C10H1-1', 'C10H1-2', 'C10H1-3', 'C10H2-1', 'C10H2-2', 'C10H2-3', 'C10H3-1', 'C10H3-2', 'C10H3-3',
                     'D1H1-1', 'D1H1-2', 'D1H1-3', 'D1H2-1', 'D1H2-2', 'D1H2-3', 'D1H3-1', 'D1H3-2', 'D1H3-3',
                     'D2H1-1', 'D2H1-2', 'D2H1-3', 'D2H2-1', 'D2H2-2', 'D2H2-3', 'D2H3-1', 'D2H3-2', 'D2H3-3',
                     'D3H1-1', 'D3H1-2', 'D3H1-3', 'D3H2-1', 'D3H2-2', 'D3H2-3', 'D3H3-1', 'D3H3-2', 'D3H3-3',
                     'D4H1-1', 'D4H1-2', 'D4H1-3', 'D4H2-1', 'D4H2-2', 'D4H2-3', 'D4H3-1', 'D4H3-2', 'D4H3-3',
                     'D5H1-1', 'D5H1-2', 'D5H1-3', 'D5H2-1', 'D5H2-2', 'D5H2-3', 'D5H3-1', 'D5H3-2', 'D5H3-3',
                     'D6H1-1', 'D6H1-2', 'D6H1-3', 'D6H2-1', 'D6H2-2', 'D6H2-3', 'D6H3-1', 'D6H3-2', 'D6H3-3',
                     'D7H1-1', 'D7H1-2', 'D7H1-3', 'D7H2-1', 'D7H2-2', 'D7H2-3', 'D7H3-1', 'D7H3-2', 'D7H3-3',
                     'D8H1-1', 'D8H1-2', 'D8H1-3', 'D8H2-1', 'D8H2-2', 'D8H2-3', 'D8H3-1', 'D8H3-2', 'D8H3-3',
                     'D9H1-1', 'D9H1-2', 'D9H1-3', 'D9H2-1', 'D9H2-2', 'D9H2-3', 'D9H3-1', 'D9H3-2', 'D9H3-3',
                     'D10H1-1', 'D10H1-2', 'D10H1-3', 'D10H2-1', 'D10H2-2', 'D10H2-3', 'D10H3-1', 'D10H3-2', 'D10H3-3',
                     'E1H1-1', 'E1H1-2', 'E1H1-3', 'E1H2-1', 'E1H2-2', 'E1H2-3', 'E1H3-1', 'E1H3-2', 'E1H3-3',
                     'E2H1-1', 'E2H1-2', 'E2H1-3', 'E2H2-1', 'E2H2-2', 'E2H2-3', 'E2H3-1', 'E2H3-2', 'E2H3-3',
                     'E3H1-1', 'E3H1-2', 'E3H1-3', 'E3H2-1', 'E3H2-2', 'E3H2-3', 'E3H3-1', 'E3H3-2', 'E3H3-3',
                     'E4H1-1', 'E4H1-2', 'E4H1-3', 'E4H2-1', 'E4H2-2', 'E4H2-3', 'E4H3-1', 'E4H3-2', 'E4H3-3',
                     'E5H1-1', 'E5H1-2', 'E5H1-3', 'E5H2-1', 'E5H2-2', 'E5H2-3', 'E5H3-1', 'E5H3-2', 'E5H3-3',
                     'E6H1-1', 'E6H1-2', 'E6H1-3', 'E6H2-1', 'E6H2-2', 'E6H2-3', 'E6H3-1', 'E6H3-2', 'E6H3-3',
                     'E7H1-1', 'E7H1-2', 'E7H1-3', 'E7H2-1', 'E7H2-2', 'E7H2-3', 'E7H3-1', 'E7H3-2', 'E7H3-3',
                     'E8H1-1', 'E8H1-2', 'E8H1-3', 'E8H2-1', 'E8H2-2', 'E8H2-3', 'E8H3-1', 'E8H3-2', 'E8H3-3',
                     'E9H1-1', 'E9H1-2', 'E9H1-3', 'E9H2-1', 'E9H2-2', 'E9H2-3', 'E9H3-1', 'E9H3-2', 'E9H3-3',
                     'E10H1-1', 'E10H1-2', 'E10H1-3', 'E10H2-1', 'E10H2-2', 'E10H2-3', 'E10H3-1', 'E10H3-2', 'E10H3-3',
                     'F1H1-1', 'F1H1-2', 'F1H1-3', 'F1H2-1', 'F1H2-2', 'F1H2-3', 'F1H3-1', 'F1H3-2', 'F1H3-3',
                     'F2H1-1', 'F2H1-2', 'F2H1-3', 'F2H2-1', 'F2H2-2', 'F2H2-3', 'F2H3-1', 'F2H3-2', 'F2H3-3',
                     'F3H1-1', 'F3H1-2', 'F3H1-3', 'F3H2-1', 'F3H2-2', 'F3H2-3', 'F3H3-1', 'F3H3-2', 'F3H3-3',
                     'F4H1-1', 'F4H1-2', 'F4H1-3', 'F4H2-1', 'F4H2-2', 'F4H2-3', 'F4H3-1', 'F4H3-2', 'F4H3-3',
                     'F5H1-1', 'F5H1-2', 'F5H1-3', 'F5H2-1', 'F5H2-2', 'F5H2-3', 'F5H3-1', 'F5H3-2', 'F5H3-3',
                     'F6H1-1', 'F6H1-2', 'F6H1-3', 'F6H2-1', 'F6H2-2', 'F6H2-3', 'F6H3-1', 'F6H3-2', 'F6H3-3',
                     'F7H1-1', 'F7H1-2', 'F7H1-3', 'F7H2-1', 'F7H2-2', 'F7H2-3', 'F7H3-1', 'F7H3-2', 'F7H3-3',
                     'F8H1-1', 'F8H1-2', 'F8H1-3', 'F8H2-1', 'F8H2-2', 'F8H2-3', 'F8H3-1', 'F8H3-2', 'F8H3-3',
                     'F9H1-1', 'F9H1-2', 'F9H1-3', 'F9H2-1', 'F9H2-2', 'F9H2-3', 'F9H3-1', 'F9H3-2', 'F9H3-3',
                     'F10H1-1', 'F10H1-2', 'F10H1-3', 'F10H2-1', 'F10H2-2', 'F10H2-3', 'F10H3-1', 'F10H3-2', 'F10H3-3']                                          
    function func1(str) {       
        document.getElementById('aaa').style.display = "block"
        let Str = '<table ><tr><td class="tttt">'
        for (let i = 0; i < arr.length; i++) {
            if (arr[i].LocatorName == str) {
                Str += 'שם איתור : ' + arr[i].LocatorName + '</td><td class="tttt">מספר משטח : '
                Str += '' + arr[i].SurfaceId + '</td></tr><tr><td class="tttt">שם מוצר : '
                Str += '' + arr[i].ProdName + '</td><td class="tttt">כמות : '
                Str += '' + arr[i].Quantity + ' יחידות</td></tr></table>'
            }
        }             
        document.getElementById('aaa').innerHTML = ' ' + Str

    }
    function func2() {
        document.getElementById('aaa').style.display = "none"
    }
    function func3(str) {
        console.log(str)
        for (let i = 0; i < str.length; i++)
            if (str[i] == '#')
                arr.push({});       
        var size = 0;
        var LocatorName, SurfaceId, ProdName, Quantity, num;       
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
                        LocatorName = str.substring(j, (j + k));                       
                        arr[size].LocatorName = LocatorName;
                    }
                    else if (str[j - 1] == '*' && num == 2) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        SurfaceId = str.substring(j, (j + k));                       
                        arr[size].SurfaceId = SurfaceId;
                    }
                    else if (str[j - 1] == '*' && num == 3) {
                        let k = 0;
                        for (let a = j; str[a] != '*'; a++, k++) { }
                        ProdName = str.substring(j, (j + k));                       
                        arr[size].ProdName = ProdName;
                    }
                    else if (str[j - 1] == '*' && num == 4) {
                        let k = 0;
                        for (let a = j; str[a] != '#'; a++, k++) { }
                        Quantity = str.substring(j, (j + k));                        
                        arr[size].Quantity = Quantity;
                    }                   
                }
                size++;
            }
        }
        
        for (let i = 0; i < arr.length; i++) {
            for (let j = 0; j < arr1.length; j++) {               
                if (arr[i].LocatorName == arr1[j]) 
                    document.getElementById('' + j).className = 'ttt2'                                 
            }
        }
    }
    function func4(str) {
        var sid = 'p'
        for (let i = 0; i < arr.length; i++) {
            if (arr[i].LocatorName == str) {               
                 sid = arr[i].SurfaceId 
            }
        }        
        if(sid != 'p')
            window.location.href = "SurfacesLocatorUpdate.aspx?Sid=" + sid +"&SLN=" +str;
    }
</script>
    <div class="limiter">
        <div class="container-table100" >
            <table style="width:1200px;margin-right:30px;" border="1">
            <tr>
                <td>
                    <table >
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="502" class="ttt1" onmouseover="func1('F6H3-3')" onmouseout="func2()" onclick="func4('F6H3-3')" >7</span></td>
                                         <td class="tt"><span id="499" class="ttt1" onmouseover="func1('F6H2-3')" onmouseout="func2()" onclick="func4('F6H2-3')" >4</span></td>
                                         <td class="tt"><span id="496" class="ttt1" onmouseover="func1('F6H1-3')" onmouseout="func2()" onclick="func4('F6H1-3')" >1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="503" class="ttt1" onmouseover="func1('F6H3-2')" onmouseout="func2()" onclick="func4('F6H3-2')" >8</span></td>
                                         <td class="tt"><span id="500" class="ttt1" onmouseover="func1('F6H2-2')" onmouseout="func2()" onclick="func4('F6H2-2')" >5</span></td>
                                         <td class="tt"><span id="497" class="ttt1" onmouseover="func1('F6H1-2')" onmouseout="func2()" onclick="func4('F6H1-2')" >2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="504" class="ttt1" onmouseover="func1('F6H3-1')" onmouseout="func2()" onclick="func4('F6H3-1')" >9</span></td>
                                         <td class="tt"><span id="501" class="ttt1" onmouseover="func1('F6H2-1')" onmouseout="func2()" onclick="func4('F6H2-1')" >6</span></td>
                                         <td class="tt"><span id="498" class="ttt1" onmouseover="func1('F6H1-1')" onmouseout="func2()" onclick="func4('F6H1-1')" >3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">6</td>
                            <td style="padding:10px;">5</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="489" class="ttt1" onmouseover="func1('F5H1-3')" onmouseout="func2()" onclick="func4('F5H1-3')" >3</span></td>
                                         <td class="tt"><span id="492" class="ttt1" onmouseover="func1('F5H2-3')" onmouseout="func2()" onclick="func4('F5H2-3')" >6</span></td>
                                         <td class="tt"><span id="495" class="ttt1" onmouseover="func1('F5H3-3')" onmouseout="func2()" onclick="func4('F5H3-3')" >9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="488" class="ttt1" onmouseover="func1('F5H1-2')" onmouseout="func2()" onclick="func4('F5H1-2')" >2</span></td>
                                         <td class="tt"><span id="491" class="ttt1" onmouseover="func1('F5H2-2')" onmouseout="func2()" onclick="func4('F5H2-2')" >5</span></td>
                                         <td class="tt"><span id="494" class="ttt1" onmouseover="func1('F5H3-2')" onmouseout="func2()" onclick="func4('F5H3-2')" >8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="487" class="ttt1" onmouseover="func1('F5H1-1')" onmouseout="func2()" onclick="func4('F5H1-1')" >1</span></td>
                                         <td class="tt"><span id="490" class="ttt1" onmouseover="func1('F5H2-1')" onmouseout="func2()" onclick="func4('F5H2-1')" >4</span></td>
                                         <td class="tt"><span id="493" class="ttt1" onmouseover="func1('F5H3-1')" onmouseout="func2()" onclick="func4('F5H3-1')" >7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="511" class="ttt1" onmouseover="func1('F7H3-3')" onmouseout="func2()" onclick="func4('F7H3-3')" >7</span></td>
                                         <td class="tt"><span id="508" class="ttt1" onmouseover="func1('F7H2-3')" onmouseout="func2()" onclick="func4('F7H2-3')" >4</span></td>
                                         <td class="tt"><span id="505" class="ttt1" onmouseover="func1('F7H1-3')" onmouseout="func2()" onclick="func4('F7H1-3')" >1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="512" class="ttt1" onmouseover="func1('F7H3-2')" onmouseout="func2()" onclick="func4('F7H3-2')" >8</span></td>
                                         <td class="tt"><span id="509" class="ttt1" onmouseover="func1('F7H2-2')" onmouseout="func2()" onclick="func4('F7H2-2')" >5</span></td>
                                         <td class="tt"><span id="506" class="ttt1" onmouseover="func1('F7H1-2')" onmouseout="func2()" onclick="func4('F7H1-2')" >2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="513" class="ttt1" onmouseover="func1('F7H3-1')" onmouseout="func2()" onclick="func4('F7H3-1')" >9</span></td>
                                         <td class="tt"><span id="510" class="ttt1" onmouseover="func1('F7H2-1')" onmouseout="func2()" onclick="func4('F7H2-1')" >6</span></td>
                                         <td class="tt"><span id="507" class="ttt1" onmouseover="func1('F7H1-1')" onmouseout="func2()" onclick="func4('F7H1-1')" >3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">7</td>
                            <td style="padding:10px;">4</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="480" class="ttt1" onmouseover="func1('F4H1-3')" onmouseout="func2()" onclick="func4('F4H1-3')">3</span></td>
                                         <td class="tt"><span id="483" class="ttt1" onmouseover="func1('F4H2-3')" onmouseout="func2()" onclick="func4('F4H2-3')">6</span></td>
                                         <td class="tt"><span id="486" class="ttt1" onmouseover="func1('F4H3-3')" onmouseout="func2()" onclick="func4('F4H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="479" class="ttt1" onmouseover="func1('F4H1-2')" onmouseout="func2()" onclick="func4('F4H1-2')">2</span></td>
                                         <td class="tt"><span id="482" class="ttt1" onmouseover="func1('F4H2-2')" onmouseout="func2()" onclick="func4('F4H2-2')">5</span></td>
                                         <td class="tt"><span id="485" class="ttt1" onmouseover="func1('F4H3-2')" onmouseout="func2()" onclick="func4('F4H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="478" class="ttt1" onmouseover="func1('F4H1-1')" onmouseout="func2()" onclick="func4('F4H1-1')">1</span></td>
                                         <td class="tt"><span id="481" class="ttt1" onmouseover="func1('F4H2-1')" onmouseout="func2()" onclick="func4('F4H2-1')">4</span></td>
                                         <td class="tt"><span id="484" class="ttt1" onmouseover="func1('F4H3-1')" onmouseout="func2()" onclick="func4('F4H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="520" class="ttt1" onmouseover="func1('F8H3-3')" onmouseout="func2()" onclick="func4('F8H3-3')">7</span></td>
                                         <td class="tt"><span id="517" class="ttt1" onmouseover="func1('F8H2-3')" onmouseout="func2()" onclick="func4('F8H2-3')">4</span></td>
                                         <td class="tt"><span id="514" class="ttt1" onmouseover="func1('F8H1-3')" onmouseout="func2()" onclick="func4('F8H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="521" class="ttt1" onmouseover="func1('F8H3-2')" onmouseout="func2()" onclick="func4('F8H3-2')">8</span></td>
                                         <td class="tt"><span id="518" class="ttt1" onmouseover="func1('F8H2-2')" onmouseout="func2()" onclick="func4('F8H2-2')">5</span></td>
                                         <td class="tt"><span id="515" class="ttt1" onmouseover="func1('F8H1-2')" onmouseout="func2()" onclick="func4('F8H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="522" class="ttt1" onmouseover="func1('F8H3-1')" onmouseout="func2()" onclick="func4('F8H3-1')">9</span></td>
                                         <td class="tt"><span id="519" class="ttt1" onmouseover="func1('F8H2-1')" onmouseout="func2()" onclick="func4('F8H2-1')">6</span></td>
                                         <td class="tt"><span id="516" class="ttt1" onmouseover="func1('F8H1-1')" onmouseout="func2()" onclick="func4('F8H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">8</td>
                            <td style="padding:10px;">3</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="471" class="ttt1" onmouseover="func1('F3H1-3')" onmouseout="func2()" onclick="func4('F3H1-3')">3</span></td>
                                         <td class="tt"><span id="474" class="ttt1" onmouseover="func1('F3H2-3')" onmouseout="func2()" onclick="func4('F3H2-3')">6</span></td>
                                         <td class="tt"><span id="477" class="ttt1" onmouseover="func1('F3H3-3')" onmouseout="func2()" onclick="func4('F3H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="470" class="ttt1" onmouseover="func1('F3H1-2')" onmouseout="func2()" onclick="func4('F3H1-2')">2</span></td>
                                         <td class="tt"><span id="473" class="ttt1" onmouseover="func1('F3H2-2')" onmouseout="func2()" onclick="func4('F3H2-2')">5</span></td>
                                         <td class="tt"><span id="476" class="ttt1" onmouseover="func1('F3H3-2')" onmouseout="func2()" onclick="func4('F3H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="469" class="ttt1" onmouseover="func1('F3H1-1')" onmouseout="func2()" onclick="func4('F3H1-1')">1</span></td>
                                         <td class="tt"><span id="472" class="ttt1" onmouseover="func1('F3H2-1')" onmouseout="func2()" onclick="func4('F3H2-1')">4</span></td>
                                         <td class="tt"><span id="475" class="ttt1" onmouseover="func1('F3H3-1')" onmouseout="func2()" onclick="func4('F3H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="529" class="ttt1" onmouseover="func1('F9H3-3')" onmouseout="func2()" onclick="func4('F9H3-3')">7</span></td>
                                         <td class="tt"><span id="526" class="ttt1" onmouseover="func1('F9H2-3')" onmouseout="func2()" onclick="func4('F9H2-3')">4</span></td>
                                         <td class="tt"><span id="523" class="ttt1" onmouseover="func1('F9H1-3')" onmouseout="func2()" onclick="func4('F9H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="530" class="ttt1" onmouseover="func1('F9H3-2')" onmouseout="func2()" onclick="func4('F9H3-2')">8</span></td>
                                         <td class="tt"><span id="527" class="ttt1" onmouseover="func1('F9H2-2')" onmouseout="func2()" onclick="func4('F9H2-2')">5</span></td>
                                         <td class="tt"><span id="524" class="ttt1" onmouseover="func1('F9H1-2')" onmouseout="func2()" onclick="func4('F9H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="531" class="ttt1" onmouseover="func1('F9H3-1')" onmouseout="func2()" onclick="func4('F9H3-1')">9</span></td>
                                         <td class="tt"><span id="528" class="ttt1" onmouseover="func1('F9H2-1')" onmouseout="func2()" onclick="func4('F9H2-1')">6</span></td>
                                         <td class="tt"><span id="525" class="ttt1" onmouseover="func1('F9H1-1')" onmouseout="func2()" onclick="func4('F9H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">9</td>
                            <td style="padding:10px;">2</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="462" class="ttt1" onmouseover="func1('F2H1-3')" onmouseout="func2()" onclick="func4('F2H1-3')">3</span></td>
                                         <td class="tt"><span id="465" class="ttt1" onmouseover="func1('F2H2-3')" onmouseout="func2()" onclick="func4('F2H2-3')">6</span></td>
                                         <td class="tt"><span id="468" class="ttt1" onmouseover="func1('F2H3-3')" onmouseout="func2()" onclick="func4('F2H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="461" class="ttt1" onmouseover="func1('F2H1-2')" onmouseout="func2()" onclick="func4('F2H1-2')">2</span></td>
                                         <td class="tt"><span id="464" class="ttt1" onmouseover="func1('F2H2-2')" onmouseout="func2()" onclick="func4('F2H2-2')">5</span></td>
                                         <td class="tt"><span id="467" class="ttt1" onmouseover="func1('F2H3-2')" onmouseout="func2()" onclick="func4('F2H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="460" class="ttt1" onmouseover="func1('F2H1-1')" onmouseout="func2()" onclick="func4('F2H1-1')">1</span></td>
                                         <td class="tt"><span id="463" class="ttt1" onmouseover="func1('F2H2-1')" onmouseout="func2()" onclick="func4('F2H2-1')">4</span></td>
                                         <td class="tt"><span id="466" class="ttt1" onmouseover="func1('F2H3-1')" onmouseout="func2()" onclick="func4('F2H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="538" class="ttt1" onmouseover="func1('F10H3-3')" onmouseout="func2()" onclick="func4('F10H3-3')">7</span></td>
                                         <td class="tt"><span id="535" class="ttt1" onmouseover="func1('F10H2-3')" onmouseout="func2()" onclick="func4('F10H2-3')">4</span></td>
                                         <td class="tt"><span id="532" class="ttt1" onmouseover="func1('F10H1-3')" onmouseout="func2()" onclick="func4('F10H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="539" class="ttt1" onmouseover="func1('F10H3-2')" onmouseout="func2()" onclick="func4('F10H3-2')">8</span></td>
                                         <td class="tt"><span id="536" class="ttt1" onmouseover="func1('F10H2-2')" onmouseout="func2()" onclick="func4('F10H2-2')">5</span></td>
                                         <td class="tt"><span id="533" class="ttt1" onmouseover="func1('F10H1-2')" onmouseout="func2()" onclick="func4('F10H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="540" class="ttt1" onmouseover="func1('F10H3-1')" onmouseout="func2()" onclick="func4('F10H3-1')">9</span></td>
                                         <td class="tt"><span id="537" class="ttt1" onmouseover="func1('F10H2-1')" onmouseout="func2()" onclick="func4('F10H2-1')">6</span></td>
                                         <td class="tt"><span id="534" class="ttt1" onmouseover="func1('F10H1-1')" onmouseout="func2()" onclick="func4('F10H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">10</td>
                            <td style="padding:10px;">1</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="453" class="ttt1" onmouseover="func1('F1H1-3')" onmouseout="func2()" onclick="func4('F1H1-3')">3</span></td>
                                         <td class="tt"><span id="456" class="ttt1" onmouseover="func1('F1H2-3')" onmouseout="func2()" onclick="func4('F1H2-3')">6</span></td>
                                         <td class="tt"><span id="459" class="ttt1" onmouseover="func1('F1H3-3')" onmouseout="func2()" onclick="func4('F1H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="452" class="ttt1" onmouseover="func1('F1H1-2')" onmouseout="func2()" onclick="func4('F1H1-2')">2</span></td>
                                         <td class="tt"><span id="455" class="ttt1" onmouseover="func1('F1H2-2')" onmouseout="func2()" onclick="func4('F1H2-2')">5</span></td>
                                         <td class="tt"><span id="458" class="ttt1" onmouseover="func1('F1H3-2')" onmouseout="func2()" onclick="func4('F1H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="451" class="ttt1" onmouseover="func1('F1H1-1')" onmouseout="func2()" onclick="func4('F1H1-1')">1</span></td>
                                         <td class="tt"><span id="454" class="ttt1" onmouseover="func1('F1H2-1')" onmouseout="func2()" onclick="func4('F1H2-1')">4</span></td>
                                         <td class="tt"><span id="457" class="ttt1" onmouseover="func1('F1H3-1')" onmouseout="func2()" onclick="func4('F1H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                        <tr><td colspan="4" style="text-align:center;">F</td></tr>
                    </table>
                </td>
                <td>
                    <table >
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="412" class="ttt1" onmouseover="func1('E6H3-3')" onmouseout="func2()" onclick="func4('E6H3-3')">7</span></td>
                                         <td class="tt"><span id="409" class="ttt1" onmouseover="func1('E6H2-3')" onmouseout="func2()" onclick="func4('E6H2-3')">4</span></td>
                                         <td class="tt"><span id="406" class="ttt1" onmouseover="func1('E6H1-3')" onmouseout="func2()" onclick="func4('E6H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="413" class="ttt1" onmouseover="func1('E6H3-2')" onmouseout="func2()" onclick="func4('E6H3-2')">8</span></td>
                                         <td class="tt"><span id="410" class="ttt1" onmouseover="func1('E6H2-2')" onmouseout="func2()" onclick="func4('E6H2-2')">5</span></td>
                                         <td class="tt"><span id="407" class="ttt1" onmouseover="func1('E6H1-2')" onmouseout="func2()" onclick="func4('E6H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="414" class="ttt1" onmouseover="func1('E6H3-1')" onmouseout="func2()" onclick="func4('E6H3-1')">9</span></td>
                                         <td class="tt"><span id="411" class="ttt1" onmouseover="func1('E6H2-1')" onmouseout="func2()" onclick="func4('E6H2-1')">6</span></td>
                                         <td class="tt"><span id="408" class="ttt1" onmouseover="func1('E6H1-1')" onmouseout="func2()" onclick="func4('E6H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">6</td>
                            <td style="padding:10px;">5</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="399" class="ttt1" onmouseover="func1('E5H1-3')" onmouseout="func2()" onclick="func4('E5H1-3')">3</span></td>
                                         <td class="tt"><span id="402" class="ttt1" onmouseover="func1('E5H2-3')" onmouseout="func2()" onclick="func4('E5H2-3')">6</span></td>
                                         <td class="tt"><span id="405" class="ttt1" onmouseover="func1('E5H3-3')" onmouseout="func2()" onclick="func4('E5H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="398" class="ttt1" onmouseover="func1('E5H1-2')" onmouseout="func2()" onclick="func4('E5H1-2')">2</span></td>
                                         <td class="tt"><span id="401" class="ttt1" onmouseover="func1('E5H2-2')" onmouseout="func2()" onclick="func4('E5H2-2')">5</span></td>
                                         <td class="tt"><span id="404" class="ttt1" onmouseover="func1('E5H3-2')" onmouseout="func2()" onclick="func4('E5H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="397" class="ttt1" onmouseover="func1('E5H1-1')" onmouseout="func2()" onclick="func4('E5H1-1')">1</span></td>
                                         <td class="tt"><span id="400" class="ttt1" onmouseover="func1('E5H2-1')" onmouseout="func2()" onclick="func4('E5H2-1')">4</span></td>
                                         <td class="tt"><span id="403" class="ttt1" onmouseover="func1('E5H3-1')" onmouseout="func2()" onclick="func4('E5H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="421" class="ttt1" onmouseover="func1('E7H3-3')" onmouseout="func2()" onclick="func4('E7H3-3')">7</span></td>
                                         <td class="tt"><span id="418" class="ttt1" onmouseover="func1('E7H2-3')" onmouseout="func2()" onclick="func4('E7H2-3')">4</span></td>
                                         <td class="tt"><span id="415" class="ttt1" onmouseover="func1('E7H1-3')" onmouseout="func2()" onclick="func4('E7H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="422" class="ttt1" onmouseover="func1('E7H3-2')" onmouseout="func2()" onclick="func4('E7H3-2')">8</span></td>
                                         <td class="tt"><span id="419" class="ttt1" onmouseover="func1('E7H2-2')" onmouseout="func2()" onclick="func4('E7H2-2')">5</span></td>
                                         <td class="tt"><span id="416" class="ttt1" onmouseover="func1('E7H1-2')" onmouseout="func2()" onclick="func4('E7H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="423" class="ttt1" onmouseover="func1('E7H3-1')" onmouseout="func2()" onclick="func4('E7H3-1')">9</span></td>
                                         <td class="tt"><span id="420" class="ttt1" onmouseover="func1('E7H2-1')" onmouseout="func2()" onclick="func4('E7H2-1')">6</span></td>
                                         <td class="tt"><span id="417" class="ttt1" onmouseover="func1('E7H1-1')" onmouseout="func2()" onclick="func4('E7H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">7</td>
                            <td style="padding:10px;">4</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="390" class="ttt1" onmouseover="func1('E4H1-3')" onmouseout="func2()" onclick="func4('E4H1-3')">3</span></td>
                                         <td class="tt"><span id="393" class="ttt1" onmouseover="func1('E4H2-3')" onmouseout="func2()" onclick="func4('E4H2-3')">6</span></td>
                                         <td class="tt"><span id="396" class="ttt1" onmouseover="func1('E4H3-3')" onmouseout="func2()" onclick="func4('E4H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="389" class="ttt1" onmouseover="func1('E4H1-2')" onmouseout="func2()" onclick="func4('E4H1-2')">2</span></td>
                                         <td class="tt"><span id="392" class="ttt1" onmouseover="func1('E4H2-2')" onmouseout="func2()" onclick="func4('E4H2-2')">5</span></td>
                                         <td class="tt"><span id="395" class="ttt1" onmouseover="func1('E4H3-2')" onmouseout="func2()" onclick="func4('E4H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="388" class="ttt1" onmouseover="func1('E4H1-1')" onmouseout="func2()" onclick="func4('E4H1-1')">1</span></td>
                                         <td class="tt"><span id="391" class="ttt1" onmouseover="func1('E4H2-1')" onmouseout="func2()" onclick="func4('E4H2-1')">4</span></td>
                                         <td class="tt"><span id="394" class="ttt1" onmouseover="func1('E4H3-1')" onmouseout="func2()" onclick="func4('E4H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="430" class="ttt1" onmouseover="func1('E8H3-3')" onmouseout="func2()" onclick="func4('E8H3-3'')">7</span></td>
                                         <td class="tt"><span id="427" class="ttt1" onmouseover="func1('E8H2-3')" onmouseout="func2()" onclick="func4('E8H2-3')">4</span></td>
                                         <td class="tt"><span id="424" class="ttt1" onmouseover="func1('E8H1-3')" onmouseout="func2()" onclick="func4('E8H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="431" class="ttt1" onmouseover="func1('E8H3-2')" onmouseout="func2()" onclick="func4('E8H3-2')">8</span></td>
                                         <td class="tt"><span id="428" class="ttt1" onmouseover="func1('E8H2-2')" onmouseout="func2()" onclick="func4('E8H2-2')">5</span></td>
                                         <td class="tt"><span id="425" class="ttt1" onmouseover="func1('E8H1-2')" onmouseout="func2()" onclick="func4('E8H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="432" class="ttt1" onmouseover="func1('E8H3-1')" onmouseout="func2()" onclick="func4('E8H3-1')">9</span></td>
                                         <td class="tt"><span id="429" class="ttt1" onmouseover="func1('E8H2-1')" onmouseout="func2()" onclick="func4('E8H2-1')">6</span></td>
                                         <td class="tt"><span id="426" class="ttt1" onmouseover="func1('E8H1-1')" onmouseout="func2()" onclick="func4('E8H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">8</td>
                            <td style="padding:10px;">3</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="381" class="ttt1" onmouseover="func1('E3H1-3')" onmouseout="func2()" onclick="func4('E3H1-3')">3</span></td>
                                         <td class="tt"><span id="384" class="ttt1" onmouseover="func1('E3H2-3')" onmouseout="func2()" onclick="func4('E3H2-3')">6</span></td>
                                         <td class="tt"><span id="387" class="ttt1" onmouseover="func1('E3H3-3')" onmouseout="func2()" onclick="func4('E3H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="380" class="ttt1" onmouseover="func1('E3H1-2')" onmouseout="func2()" onclick="func4('E3H1-2')">2</span></td>
                                         <td class="tt"><span id="383" class="ttt1" onmouseover="func1('E3H2-2')" onmouseout="func2()" onclick="func4('E3H2-2')">5</span></td>
                                         <td class="tt"><span id="386" class="ttt1" onmouseover="func1('E3H3-2')" onmouseout="func2()" onclick="func4('E3H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="379" class="ttt1" onmouseover="func1('E3H1-1')" onmouseout="func2()" onclick="func4('E3H2-1')">1</span></td>
                                         <td class="tt"><span id="382" class="ttt1" onmouseover="func1('E3H2-1')" onmouseout="func2()" onclick="func4('E3H2-1')">4</span></td>
                                         <td class="tt"><span id="385" class="ttt1" onmouseover="func1('E3H3-1')" onmouseout="func2()" onclick="func4('E3H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="439" class="ttt1" onmouseover="func1('E9H3-3')" onmouseout="func2()" onclick="func4('E9H3-3')">7</span></td>
                                         <td class="tt"><span id="436" class="ttt1" onmouseover="func1('E9H2-3')" onmouseout="func2()" onclick="func4('E9H2-3')">4</span></td>
                                         <td class="tt"><span id="433" class="ttt1" onmouseover="func1('E9H1-3')" onmouseout="func2()" onclick="func4('E9H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="440" class="ttt1" onmouseover="func1('E9H3-2')" onmouseout="func2()" onclick="func4('E9H3-2')">8</span></td>
                                         <td class="tt"><span id="437" class="ttt1" onmouseover="func1('E9H2-2')" onmouseout="func2()" onclick="func4('E9H2-2')">5</span></td>
                                         <td class="tt"><span id="434" class="ttt1" onmouseover="func1('E9H1-2')" onmouseout="func2()" onclick="func4('E9H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="441" class="ttt1" onmouseover="func1('E9H3-1')" onmouseout="func2()" onclick="func4('E9H3-1')">9</span></td>
                                         <td class="tt"><span id="438" class="ttt1" onmouseover="func1('E9H2-1')" onmouseout="func2()" onclick="func4('E9H2-1')">6</span></td>
                                         <td class="tt"><span id="435" class="ttt1" onmouseover="func1('E9H1-1')" onmouseout="func2()" onclick="func4('E9H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">9</td>
                            <td style="padding:10px;">2</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="372" class="ttt1" onmouseover="func1('E2H1-3')" onmouseout="func2()" onclick="func4('E2H1-3')">3</span></td>
                                         <td class="tt"><span id="375" class="ttt1" onmouseover="func1('E2H2-3')" onmouseout="func2()" onclick="func4('E2H2-3')">6</span></td>
                                         <td class="tt"><span id="378" class="ttt1" onmouseover="func1('E2H3-3')" onmouseout="func2()" onclick="func4('E2H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="371" class="ttt1" onmouseover="func1('E2H1-2')" onmouseout="func2()" onclick="func4('E2H1-2')">2</span></td>
                                         <td class="tt"><span id="374" class="ttt1" onmouseover="func1('E2H2-2')" onmouseout="func2()" onclick="func4('E2H2-2')">5</span></td>
                                         <td class="tt"><span id="377" class="ttt1" onmouseover="func1('E2H3-2')" onmouseout="func2()" onclick="func4('E2H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="370" class="ttt1" onmouseover="func1('E2H1-1')" onmouseout="func2()" onclick="func4('E2H1-1')">1</span></td>
                                         <td class="tt"><span id="373" class="ttt1" onmouseover="func1('E2H2-1')" onmouseout="func2()" onclick="func4('E2H2-1')">4</span></td>
                                         <td class="tt"><span id="376" class="ttt1" onmouseover="func1('E2H3-1')" onmouseout="func2()" onclick="func4('E2H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="448" class="ttt1" onmouseover="func1('E10H3-3')" onmouseout="func2()" onclick="func4('E10H3-3')">7</span></td>
                                         <td class="tt"><span id="445" class="ttt1" onmouseover="func1('E10H2-3')" onmouseout="func2()" onclick="func4('E10H2-3')">4</span></td>
                                         <td class="tt"><span id="442" class="ttt1" onmouseover="func1('E10H1-3')" onmouseout="func2()" onclick="func4('E10H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="449" class="ttt1" onmouseover="func1('E10H3-2')" onmouseout="func2()" onclick="func4('E10H3-2')">8</span></td>
                                         <td class="tt"><span id="446" class="ttt1" onmouseover="func1('E10H2-2')" onmouseout="func2()" onclick="func4('E10H2-2')">5</span></td>
                                         <td class="tt"><span id="443" class="ttt1" onmouseover="func1('E10H1-2')" onmouseout="func2()" onclick="func4('E10H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="450" class="ttt1" onmouseover="func1('E10H3-1')" onmouseout="func2()" onclick="func4('E10H3-1')">9</span></td>
                                         <td class="tt"><span id="447" class="ttt1" onmouseover="func1('E10H2-1')" onmouseout="func2()" onclick="func4('E10H2-1')">6</span></td>
                                         <td class="tt"><span id="444" class="ttt1" onmouseover="func1('E10H1-1')" onmouseout="func2()" onclick="func4('E10H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">10</td>
                            <td style="padding:10px;">1</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="363" class="ttt1" onmouseover="func1('E1H1-3')" onmouseout="func2()" onclick="func4('E1H1-3')">3</span></td>
                                         <td class="tt"><span id="366" class="ttt1" onmouseover="func1('E1H2-3')" onmouseout="func2()" onclick="func4('E1H2-3')">6</span></td>
                                         <td class="tt"><span id="369" class="ttt1" onmouseover="func1('E1H3-3')" onmouseout="func2()" onclick="func4('E1H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="362" class="ttt1" onmouseover="func1('E1H1-2')" onmouseout="func2()" onclick="func4('E1H1-2')">2</span></td>
                                         <td class="tt"><span id="365" class="ttt1" onmouseover="func1('E1H2-2')" onmouseout="func2()" onclick="func4('E1H2-2')">5</span></td>
                                         <td class="tt"><span id="368" class="ttt1" onmouseover="func1('E1H3-2')" onmouseout="func2()" onclick="func4('E1H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="361" class="ttt1" onmouseover="func1('E1H1-1')" onmouseout="func2()" onclick="func4('E1H1-1')">1</span></td>
                                         <td class="tt"><span id="364" class="ttt1" onmouseover="func1('E1H2-1')" onmouseout="func2()" onclick="func4('E1H2-1')">4</span></td>
                                         <td class="tt"><span id="367" class="ttt1" onmouseover="func1('E1H3-1')" onmouseout="func2()" onclick="func4('E1H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                        <tr><td colspan="4" style="text-align:center;">E</td></tr>
                    </table>
                </td>
                <td>
                    <table >
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="322" class="ttt1" onmouseover="func1('D6H3-3')" onmouseout="func2()" onclick="func4('D6H3-3')">7</span></td>
                                         <td class="tt"><span id="319" class="ttt1" onmouseover="func1('D6H2-3')" onmouseout="func2()" onclick="func4('D6H2-3')">4</span></td>
                                         <td class="tt"><span id="316" class="ttt1" onmouseover="func1('D6H1-3')" onmouseout="func2()" onclick="func4('D6H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="323" class="ttt1" onmouseover="func1('D6H3-2')" onmouseout="func2()" onclick="func4('D6H3-2')">8</span></td>
                                         <td class="tt"><span id="320" class="ttt1" onmouseover="func1('D6H2-2')" onmouseout="func2()" onclick="func4('D6H2-2')">5</span></td>
                                         <td class="tt"><span id="317" class="ttt1" onmouseover="func1('D6H1-2')" onmouseout="func2()" onclick="func4('D6H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="324" class="ttt1" onmouseover="func1('D6H3-1')" onmouseout="func2()" onclick="func4('D6H3-1')">9</span></td>
                                         <td class="tt"><span id="321" class="ttt1" onmouseover="func1('D6H2-1')" onmouseout="func2()" onclick="func4('D6H2-1')">6</span></td>
                                         <td class="tt"><span id="318" class="ttt1" onmouseover="func1('D6H1-1')" onmouseout="func2()" onclick="func4('D6H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">6</td>
                            <td style="padding:10px;">5</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="309" class="ttt1" onmouseover="func1('D5H1-3')" onmouseout="func2()" onclick="func4('D5H1-3')">3</span></td>
                                         <td class="tt"><span id="312" class="ttt1" onmouseover="func1('D5H2-3')" onmouseout="func2()" onclick="func4('D5H2-3')">6</span></td>
                                         <td class="tt"><span id="315" class="ttt1" onmouseover="func1('D5H3-3')" onmouseout="func2()" onclick="func4('D5H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="308" class="ttt1" onmouseover="func1('D5H1-2')" onmouseout="func2()" onclick="func4('D5H1-2')">2</span></td>
                                         <td class="tt"><span id="311" class="ttt1" onmouseover="func1('D5H2-2')" onmouseout="func2()" onclick="func4('D5H2-2')">5</span></td>
                                         <td class="tt"><span id="314" class="ttt1" onmouseover="func1('D5H3-2')" onmouseout="func2()" onclick="func4('D5H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="307" class="ttt1" onmouseover="func1('D5H1-1')" onmouseout="func2()" onclick="func4('D5H1-1')">1</span></td>
                                         <td class="tt"><span id="310" class="ttt1" onmouseover="func1('D5H2-1')" onmouseout="func2()" onclick="func4('D5H2-1')">4</span></td>
                                         <td class="tt"><span id="313" class="ttt1" onmouseover="func1('D5H3-1')" onmouseout="func2()" onclick="func4('D5H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="331" class="ttt1" onmouseover="func1('D7H3-3')" onmouseout="func2()" onclick="func4('D7H3-3')">7</span></td>
                                         <td class="tt"><span id="328" class="ttt1" onmouseover="func1('D7H2-3')" onmouseout="func2()" onclick="func4('D7H2-3')">4</span></td>
                                         <td class="tt"><span id="325" class="ttt1" onmouseover="func1('D7H1-3')" onmouseout="func2()" onclick="func4('D7H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="332" class="ttt1" onmouseover="func1('D7H3-2')" onmouseout="func2()" onclick="func4('D7H3-2')">8</span></td>
                                         <td class="tt"><span id="329" class="ttt1" onmouseover="func1('D7H2-2')" onmouseout="func2()" onclick="func4('D7H2-2')">5</span></td>
                                         <td class="tt"><span id="326" class="ttt1" onmouseover="func1('D7H1-2')" onmouseout="func2()" onclick="func4('D7H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="333" class="ttt1" onmouseover="func1('D7H3-1')" onmouseout="func2()" onclick="func4('D7H3-1')">9</span></td>
                                         <td class="tt"><span id="330" class="ttt1" onmouseover="func1('D7H2-1')" onmouseout="func2()" onclick="func4('D7H2-1')">6</span></td>
                                         <td class="tt"><span id="327" class="ttt1" onmouseover="func1('D7H1-1')" onmouseout="func2()" onclick="func4('D7H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">7</td>
                            <td style="padding:10px;">4</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="300" class="ttt1" onmouseover="func1('D4H1-3')" onmouseout="func2()" onclick="func4('D4H1-3')">3</span></td>
                                         <td class="tt"><span id="303" class="ttt1" onmouseover="func1('D4H2-3')" onmouseout="func2()" onclick="func4('D4H2-3')">6</span></td>
                                         <td class="tt"><span id="306" class="ttt1" onmouseover="func1('D4H3-3')" onmouseout="func2()" onclick="func4('D4H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="299" class="ttt1" onmouseover="func1('D4H1-2')" onmouseout="func2()" onclick="func4('D4H1-2')">2</span></td>
                                         <td class="tt"><span id="302" class="ttt1" onmouseover="func1('D4H2-2')" onmouseout="func2()" onclick="func4('D4H2-2')">5</span></td>
                                         <td class="tt"><span id="305" class="ttt1" onmouseover="func1('D4H3-2')" onmouseout="func2()" onclick="func4('D4H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="298" class="ttt1" onmouseover="func1('D4H1-1')" onmouseout="func2()" onclick="func4('D4H1-1')">1</span></td>
                                         <td class="tt"><span id="301" class="ttt1" onmouseover="func1('D4H2-1')" onmouseout="func2()" onclick="func4('D4H2-1')">4</span></td>
                                         <td class="tt"><span id="304" class="ttt1" onmouseover="func1('D4H3-1')" onmouseout="func2()" onclick="func4('D4H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="340" class="ttt1" onmouseover="func1('D8H3-3')" onmouseout="func2()" onclick="func4('D8H3-3')">7</span></td>
                                         <td class="tt"><span id="337" class="ttt1" onmouseover="func1('D8H2-3')" onmouseout="func2()" onclick="func4('D8H2-3')">4</span></td>
                                         <td class="tt"><span id="334" class="ttt1" onmouseover="func1('D8H1-3')" onmouseout="func2()" onclick="func4('D8H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="341" class="ttt1" onmouseover="func1('D8H3-2')" onmouseout="func2()" onclick="func4('D8H3-2')">8</span></td>
                                         <td class="tt"><span id="338" class="ttt1" onmouseover="func1('D8H2-2')" onmouseout="func2()" onclick="func4('D8H2-2')">5</span></td>
                                         <td class="tt"><span id="335" class="ttt1" onmouseover="func1('D8H1-2')" onmouseout="func2()" onclick="func4('D8H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="342" class="ttt1" onmouseover="func1('D8H3-1')" onmouseout="func2()" onclick="func4('D8H3-1')">9</span></td>
                                         <td class="tt"><span id="339" class="ttt1" onmouseover="func1('D8H2-1')" onmouseout="func2()" onclick="func4('D8H2-1')">6</span></td>
                                         <td class="tt"><span id="336" class="ttt1" onmouseover="func1('D8H1-1')" onmouseout="func2()" onclick="func4('D8H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">8</td>
                            <td style="padding:10px;">3</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="291" class="ttt1" onmouseover="func1('D3H1-3')" onmouseout="func2()" onclick="func4('D3H1-3')">3</span></td>
                                         <td class="tt"><span id="294" class="ttt1" onmouseover="func1('D3H2-3')" onmouseout="func2()" onclick="func4('D3H2-3')">6</span></td>
                                         <td class="tt"><span id="297" class="ttt1" onmouseover="func1('D3H3-3')" onmouseout="func2()" onclick="func4('D3H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="290" class="ttt1" onmouseover="func1('D3H1-2')" onmouseout="func2()" onclick="func4('D3H1-2')">2</span></td>
                                         <td class="tt"><span id="293" class="ttt1" onmouseover="func1('D3H2-2')" onmouseout="func2()" onclick="func4('D3H2-2')">5</span></td>
                                         <td class="tt"><span id="296" class="ttt1" onmouseover="func1('D3H3-2')" onmouseout="func2()" onclick="func4('D3H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="289" class="ttt1" onmouseover="func1('D3H1-1')" onmouseout="func2()" onclick="func4('D3H1-1')">1</span></td>
                                         <td class="tt"><span id="292" class="ttt1" onmouseover="func1('D3H2-1')" onmouseout="func2()" onclick="func4('D3H2-1')">4</span></td>
                                         <td class="tt"><span id="295" class="ttt1" onmouseover="func1('D3H3-1')" onmouseout="func2()" onclick="func4('D3H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="349" class="ttt1" onmouseover="func1('D9H3-3')" onmouseout="func2()" onclick="func4('D9H3-3')">7</span></td>
                                         <td class="tt"><span id="346" class="ttt1" onmouseover="func1('D9H2-3')" onmouseout="func2()" onclick="func4('D9H2-3')">4</span></td>
                                         <td class="tt"><span id="343" class="ttt1" onmouseover="func1('D9H1-3')" onmouseout="func2()" onclick="func4('D9H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="350" class="ttt1" onmouseover="func1('D9H3-2')" onmouseout="func2()" onclick="func4('D9H3-2')">8</span></td>
                                         <td class="tt"><span id="347" class="ttt1" onmouseover="func1('D9H2-2')" onmouseout="func2()" onclick="func4('D9H2-2')">5</span></td>
                                         <td class="tt"><span id="344" class="ttt1" onmouseover="func1('D9H1-2')" onmouseout="func2()" onclick="func4('D9H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="351" class="ttt1" onmouseover="func1('D9H3-1')" onmouseout="func2()" onclick="func4('D9H3-1')">9</span></td>
                                         <td class="tt"><span id="348" class="ttt1" onmouseover="func1('D9H2-1')" onmouseout="func2()" onclick="func4('D9H2-1')">6</span></td>
                                         <td class="tt"><span id="345" class="ttt1" onmouseover="func1('D9H1-1')" onmouseout="func2()" onclick="func4('D9H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">9</td>
                            <td style="padding:10px;">2</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="282" class="ttt1" onmouseover="func1('D2H1-3')" onmouseout="func2()" onclick="func4('D2H1-3')">3</span></td>
                                         <td class="tt"><span id="285" class="ttt1" onmouseover="func1('D2H2-3')" onmouseout="func2()" onclick="func4('D2H2-3')">6</span></td>
                                         <td class="tt"><span id="288" class="ttt1" onmouseover="func1('D2H3-3')" onmouseout="func2()" onclick="func4('D2H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="281" class="ttt1" onmouseover="func1('D2H1-2')" onmouseout="func2()" onclick="func4('D2H1-2')">2</span></td>
                                         <td class="tt"><span id="284" class="ttt1" onmouseover="func1('D2H2-2')" onmouseout="func2()" onclick="func4('D2H2-2')">5</span></td>
                                         <td class="tt"><span id="287" class="ttt1" onmouseover="func1('D2H3-2')" onmouseout="func2()" onclick="func4('D2H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="280" class="ttt1" onmouseover="func1('D2H1-1')" onmouseout="func2()" onclick="func4('D2H1-1')">1</span></td>
                                         <td class="tt"><span id="283" class="ttt1" onmouseover="func1('D2H2-1')" onmouseout="func2()" onclick="func4('D2H2-1')">4</span></td>
                                         <td class="tt"><span id="286" class="ttt1" onmouseover="func1('D2H3-1')" onmouseout="func2()" onclick="func4('D2H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="358" class="ttt1" onmouseover="func1('D10H3-3')" onmouseout="func2()" onclick="func4('D10H3-3')">7</span></td>
                                         <td class="tt"><span id="355" class="ttt1" onmouseover="func1('D10H2-3')" onmouseout="func2()" onclick="func4('D10H2-3')">4</span></td>
                                         <td class="tt"><span id="352" class="ttt1" onmouseover="func1('D10H1-3')" onmouseout="func2()" onclick="func4('D10H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="359" class="ttt1" onmouseover="func1('D10H3-2')" onmouseout="func2()" onclick="func4('D10H3-2')">8</span></td>
                                         <td class="tt"><span id="356" class="ttt1" onmouseover="func1('D10H2-2')" onmouseout="func2()" onclick="func4('D10H2-2')">5</span></td>
                                         <td class="tt"><span id="353" class="ttt1" onmouseover="func1('D10H1-2')" onmouseout="func2()" onclick="func4('D10H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="360" class="ttt1" onmouseover="func1('D10H3-1')" onmouseout="func2()" onclick="func4('D10H3-1')">9</span></td>
                                         <td class="tt"><span id="357" class="ttt1" onmouseover="func1('D10H2-1')" onmouseout="func2()" onclick="func4('D10H2-1')">6</span></td>
                                         <td class="tt"><span id="354" class="ttt1" onmouseover="func1('D10H1-1')" onmouseout="func2()" onclick="func4('D10H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">10</td>
                            <td style="padding:10px;">1</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="273" class="ttt1" onmouseover="func1('D1H1-3')" onmouseout="func2()" onclick="func4('D1H1-3')">3</span></td>
                                         <td class="tt"><span id="276" class="ttt1" onmouseover="func1('D1H2-3')" onmouseout="func2()" onclick="func4('D1H2-3')">6</span></td>
                                         <td class="tt"><span id="279" class="ttt1" onmouseover="func1('D1H3-3')" onmouseout="func2()" onclick="func4('D1H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="272" class="ttt1" onmouseover="func1('D1H1-2')" onmouseout="func2()" onclick="func4('D1H1-2')">2</span></td>
                                         <td class="tt"><span id="275" class="ttt1" onmouseover="func1('D1H2-2')" onmouseout="func2()" onclick="func4('D1H2-2')">5</span></td>
                                         <td class="tt"><span id="278" class="ttt1" onmouseover="func1('D1H3-2')" onmouseout="func2()" onclick="func4('D1H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="271" class="ttt1" onmouseover="func1('D1H1-1')" onmouseout="func2()" onclick="func4('D1H1-1')">1</span></td>
                                         <td class="tt"><span id="274" class="ttt1" onmouseover="func1('D1H2-1')" onmouseout="func2()" onclick="func4('D1H2-1')">4</span></td>
                                         <td class="tt"><span id="277" class="ttt1" onmouseover="func1('D1H3-1')" onmouseout="func2()" onclick="func4('D1H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                        <tr><td colspan="4" style="text-align:center;">D</td></tr>
                    </table>
                </td>
                <td>
                    <table >
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="232" class="ttt1" onmouseover="func1('C6H3-3')" onmouseout="func2()" onclick="func4('C6H3-3')">7</span></td>
                                         <td class="tt"><span id="229" class="ttt1" onmouseover="func1('C6H2-3')" onmouseout="func2()" onclick="func4('C6H2-3')">4</span></td>
                                         <td class="tt"><span id="226" class="ttt1" onmouseover="func1('C6H1-3')" onmouseout="func2()" onclick="func4('C6H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="233" class="ttt1" onmouseover="func1('C6H3-2')" onmouseout="func2()" onclick="func4('C6H3-2')">8</span></td>
                                         <td class="tt"><span id="230" class="ttt1" onmouseover="func1('C6H2-2')" onmouseout="func2()" onclick="func4('C6H2-2')">5</span></td>
                                         <td class="tt"><span id="227" class="ttt1" onmouseover="func1('C6H1-2')" onmouseout="func2()" onclick="func4('C6H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="234" class="ttt1" onmouseover="func1('C6H3-1')" onmouseout="func2()" onclick="func4('C6H3-1')">9</span></td>
                                         <td class="tt"><span id="231" class="ttt1" onmouseover="func1('C6H2-1')" onmouseout="func2()" onclick="func4('C6H2-1')">6</span></td>
                                         <td class="tt"><span id="228" class="ttt1" onmouseover="func1('C6H1-1')" onmouseout="func2()" onclick="func4('C6H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">6</td>
                            <td style="padding:10px;">5</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="219" class="ttt1" onmouseover="func1('C5H1-3')" onmouseout="func2()" onclick="func4('C5H1-3')">3</span></td>
                                         <td class="tt"><span id="222" class="ttt1" onmouseover="func1('C5H2-3')" onmouseout="func2()" onclick="func4('C5H2-3')">6</span></td>
                                         <td class="tt"><span id="225" class="ttt1" onmouseover="func1('C5H3-3')" onmouseout="func2()" onclick="func4('C5H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="218" class="ttt1" onmouseover="func1('C5H1-2')" onmouseout="func2()" onclick="func4('C5H1-2')">2</span></td>
                                         <td class="tt"><span id="221" class="ttt1" onmouseover="func1('C5H2-2')" onmouseout="func2()" onclick="func4('C5H2-2')">5</span></td>
                                         <td class="tt"><span id="224" class="ttt1" onmouseover="func1('C5H3-2')" onmouseout="func2()" onclick="func4('C5H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="217" class="ttt1" onmouseover="func1('C5H1-1')" onmouseout="func2()" onclick="func4('C5H1-1')">1</span></td>
                                         <td class="tt"><span id="220" class="ttt1" onmouseover="func1('C5H2-1')" onmouseout="func2()" onclick="func4('C5H2-1')">4</span></td>
                                         <td class="tt"><span id="223" class="ttt1" onmouseover="func1('C5H3-1')" onmouseout="func2()" onclick="func4('C5H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="241" class="ttt1" onmouseover="func1('C7H3-3')" onmouseout="func2()" onclick="func4('C7H3-3')">7</span></td>
                                         <td class="tt"><span id="238" class="ttt1" onmouseover="func1('C7H2-3')" onmouseout="func2()" onclick="func4('C7H2-3')">4</span></td>
                                         <td class="tt"><span id="235" class="ttt1" onmouseover="func1('C7H1-3')" onmouseout="func2()" onclick="func4('C7H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="242" class="ttt1" onmouseover="func1('C7H3-2')" onmouseout="func2()" onclick="func4('C7H3-2')">8</span></td>
                                         <td class="tt"><span id="239" class="ttt1" onmouseover="func1('C7H2-2')" onmouseout="func2()" onclick="func4('C7H2-2')">5</span></td>
                                         <td class="tt"><span id="236" class="ttt1" onmouseover="func1('C7H1-2')" onmouseout="func2()" onclick="func4('C7H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="243" class="ttt1" onmouseover="func1('C7H3-1')" onmouseout="func2()" onclick="func4('C7H3-1')">9</span></td>
                                         <td class="tt"><span id="240" class="ttt1" onmouseover="func1('C7H2-1')" onmouseout="func2()" onclick="func4('C7H2-1')">6</span></td>
                                         <td class="tt"><span id="237" class="ttt1" onmouseover="func1('C7H1-1')" onmouseout="func2()" onclick="func4('C7H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">7</td>
                            <td style="padding:10px;">4</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="210" class="ttt1" onmouseover="func1('C4H1-3')" onmouseout="func2()" onclick="func4('C4H1-3')">3</span></td>
                                         <td class="tt"><span id="213" class="ttt1" onmouseover="func1('C4H2-3')" onmouseout="func2()" onclick="func4('C4H2-3')">6</span></td>
                                         <td class="tt"><span id="216" class="ttt1" onmouseover="func1('C4H3-3')" onmouseout="func2()" onclick="func4('C4H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="209" class="ttt1" onmouseover="func1('C4H1-2')" onmouseout="func2()" onclick="func4('C4H1-2')">2</span></td>
                                         <td class="tt"><span id="212" class="ttt1" onmouseover="func1('C4H2-2')" onmouseout="func2()" onclick="func4('C4H2-2')">5</span></td>
                                         <td class="tt"><span id="215" class="ttt1" onmouseover="func1('C4H3-2')" onmouseout="func2()" onclick="func4('C4H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="208" class="ttt1" onmouseover="func1('C4H1-1')" onmouseout="func2()" onclick="func4('C4H1-1')">1</span></td>
                                         <td class="tt"><span id="211" class="ttt1" onmouseover="func1('C4H2-1')" onmouseout="func2()" onclick="func4('C4H2-1')">4</span></td>
                                         <td class="tt"><span id="214" class="ttt1" onmouseover="func1('C4H3-1')" onmouseout="func2()" onclick="func4('C4H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="250" class="ttt1" onmouseover="func1('C8H3-3')" onmouseout="func2()" onclick="func4('C8H3-3')">7</span></td>
                                         <td class="tt"><span id="247" class="ttt1" onmouseover="func1('C8H2-3')" onmouseout="func2()" onclick="func4('C8H2-3')">4</span></td>
                                         <td class="tt"><span id="244" class="ttt1" onmouseover="func1('C8H1-3')" onmouseout="func2()" onclick="func4('C8H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="251" class="ttt1" onmouseover="func1('C8H3-2')" onmouseout="func2()" onclick="func4('C8H3-2')">8</span></td>
                                         <td class="tt"><span id="248" class="ttt1" onmouseover="func1('C8H2-2')" onmouseout="func2()" onclick="func4('C8H2-2')">5</span></td>
                                         <td class="tt"><span id="245" class="ttt1" onmouseover="func1('C8H1-2')" onmouseout="func2()" onclick="func4('C8H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="252" class="ttt1" onmouseover="func1('C8H3-1')" onmouseout="func2()" onclick="func4('C8H3-1')">9</span></td>
                                         <td class="tt"><span id="249" class="ttt1" onmouseover="func1('C8H2-1')" onmouseout="func2()" onclick="func4('C8H2-1')">6</span></td>
                                         <td class="tt"><span id="246" class="ttt1" onmouseover="func1('C8H1-1')" onmouseout="func2()" onclick="func4('C8H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">8</td>
                            <td style="padding:10px;">3</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="201" class="ttt1" onmouseover="func1('C3H1-3')" onmouseout="func2()" onclick="func4('C3H1-3')">3</span></td>
                                         <td class="tt"><span id="204" class="ttt1" onmouseover="func1('C3H2-3')" onmouseout="func2()" onclick="func4('C3H2-3')">6</span></td>
                                         <td class="tt"><span id="207" class="ttt1" onmouseover="func1('C3H3-3')" onmouseout="func2()" onclick="func4('C3H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="200" class="ttt1" onmouseover="func1('C3H1-2')" onmouseout="func2()" onclick="func4('C3H1-2')">2</span></td>
                                         <td class="tt"><span id="203" class="ttt1" onmouseover="func1('C3H2-2')" onmouseout="func2()" onclick="func4('C3H2-2')">5</span></td>
                                         <td class="tt"><span id="206" class="ttt1" onmouseover="func1('C3H3-2')" onmouseout="func2()" onclick="func4('C3H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="199" class="ttt1" onmouseover="func1('C3H1-1')" onmouseout="func2()" onclick="func4('C3H1-1')">1</span></td>
                                         <td class="tt"><span id="202" class="ttt1" onmouseover="func1('C3H2-1')" onmouseout="func2()" onclick="func4('C3H2-1')">4</span></td>
                                         <td class="tt"><span id="205" class="ttt1" onmouseover="func1('C3H3-1')" onmouseout="func2()" onclick="func4('C3H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="259" class="ttt1" onmouseover="func1('C9H3-3')" onmouseout="func2()" onclick="func4('C9H3-3')">7</span></td>
                                         <td class="tt"><span id="256" class="ttt1" onmouseover="func1('C9H2-3')" onmouseout="func2()" onclick="func4('C9H2-3')">4</span></td>
                                         <td class="tt"><span id="253" class="ttt1" onmouseover="func1('C9H1-3')" onmouseout="func2()" onclick="func4('C9H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="260" class="ttt1" onmouseover="func1('C9H3-2')" onmouseout="func2()" onclick="func4('C9H3-2')">8</span></td>
                                         <td class="tt"><span id="257" class="ttt1" onmouseover="func1('C9H2-2')" onmouseout="func2()" onclick="func4('C9H2-2')">5</span></td>
                                         <td class="tt"><span id="254" class="ttt1" onmouseover="func1('C9H1-2')" onmouseout="func2()" onclick="func4('C9H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="261" class="ttt1" onmouseover="func1('C9H3-1')" onmouseout="func2()" onclick="func4('C9H3-1')">9</span></td>
                                         <td class="tt"><span id="258" class="ttt1" onmouseover="func1('C9H2-1')" onmouseout="func2()" onclick="func4('C9H2-1')">6</span></td>
                                         <td class="tt"><span id="255" class="ttt1" onmouseover="func1('C9H1-1')" onmouseout="func2()" onclick="func4('C9H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">9</td>
                            <td style="padding:10px;">2</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="192" class="ttt1" onmouseover="func1('C2H1-3')" onmouseout="func2()" onclick="func4('C2H1-3')">3</span></td>
                                         <td class="tt"><span id="195" class="ttt1" onmouseover="func1('C2H2-3')" onmouseout="func2()" onclick="func4('C2H2-3')">6</span></td>
                                         <td class="tt"><span id="198" class="ttt1" onmouseover="func1('C2H3-3')" onmouseout="func2()" onclick="func4('C2H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="191" class="ttt1" onmouseover="func1('C2H1-2')" onmouseout="func2()" onclick="func4('C2H1-2')">2</span></td>
                                         <td class="tt"><span id="194" class="ttt1" onmouseover="func1('C2H2-2')" onmouseout="func2()" onclick="func4('C2H2-2')">5</span></td>
                                         <td class="tt"><span id="197" class="ttt1" onmouseover="func1('C2H3-2')" onmouseout="func2()" onclick="func4('C2H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="190" class="ttt1" onmouseover="func1('C2H1-1')" onmouseout="func2()" onclick="func4('C2H1-1')">1</span></td>
                                         <td class="tt"><span id="193" class="ttt1" onmouseover="func1('C2H2-1')" onmouseout="func2()" onclick="func4('C2H2-1')">4</span></td>
                                         <td class="tt"><span id="196" class="ttt1" onmouseover="func1('C2H3-1')" onmouseout="func2()" onclick="func4('C2H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="268" class="ttt1" onmouseover="func1('C10H3-3')" onmouseout="func2()" onclick="func4('C10H3-3')">7</span></td>
                                         <td class="tt"><span id="265" class="ttt1" onmouseover="func1('C10H2-3')" onmouseout="func2()" onclick="func4('C10H2-3')">4</span></td>
                                         <td class="tt"><span id="262" class="ttt1" onmouseover="func1('C10H1-3')" onmouseout="func2()" onclick="func4('C10H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="269" class="ttt1" onmouseover="func1('C10H3-2')" onmouseout="func2()" onclick="func4('C10H3-2')">8</span></td>
                                         <td class="tt"><span id="266" class="ttt1" onmouseover="func1('C10H2-2')" onmouseout="func2()" onclick="func4('C10H2-2')">5</span></td>
                                         <td class="tt"><span id="263" class="ttt1" onmouseover="func1('C10H1-2')" onmouseout="func2()" onclick="func4('C10H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="270" class="ttt1" onmouseover="func1('C10H3-1')" onmouseout="func2()" onclick="func4('C10H3-1')">9</span></td>
                                         <td class="tt"><span id="267" class="ttt1" onmouseover="func1('C10H2-1')" onmouseout="func2()" onclick="func4('C10H2-1')">6</span></td>
                                         <td class="tt"><span id="264" class="ttt1" onmouseover="func1('C10H1-1')" onmouseout="func2()" onclick="func4('C10H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">10</td>
                            <td style="padding:10px;">1</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="183" class="ttt1" onmouseover="func1('C1H1-3')" onmouseout="func2()" onclick="func4('C1H1-3')">3</span></td>
                                         <td class="tt"><span id="186" class="ttt1" onmouseover="func1('C1H2-3')" onmouseout="func2()" onclick="func4('C1H2-3')">6</span></td>
                                         <td class="tt"><span id="189" class="ttt1" onmouseover="func1('C1H3-3')" onmouseout="func2()" onclick="func4('C1H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="182" class="ttt1" onmouseover="func1('C1H1-2')" onmouseout="func2()" onclick="func4('C1H1-2')">2</span></td>
                                         <td class="tt"><span id="185" class="ttt1" onmouseover="func1('C1H2-2')" onmouseout="func2()" onclick="func4('C1H2-2')">5</span></td>
                                         <td class="tt"><span id="188" class="ttt1" onmouseover="func1('C1H3-2')" onmouseout="func2()" onclick="func4('C1H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="181" class="ttt1" onmouseover="func1('C1H1-1')" onmouseout="func2()" onclick="func4('C1H1-1')">1</span></td>
                                         <td class="tt"><span id="184" class="ttt1" onmouseover="func1('C1H2-1')" onmouseout="func2()" onclick="func4('C1H2-1')">4</span></td>
                                         <td class="tt"><span id="187" class="ttt1" onmouseover="func1('C1H3-1')" onmouseout="func2()" onclick="func4('C1H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                        <tr><td colspan="4" style="text-align:center;">C</td></tr>
                    </table>
                </td>
                <td>
                    <table >
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="142" class="ttt1" onmouseover="func1('B6H3-3')" onmouseout="func2()" onclick="func4('B6H3-3')">7</span></td>
                                         <td class="tt"><span id="139" class="ttt1" onmouseover="func1('B6H2-3')" onmouseout="func2()" onclick="func4('B6H2-3')">4</span></td>
                                         <td class="tt"><span id="136" class="ttt1" onmouseover="func1('B6H1-3')" onmouseout="func2()" onclick="func4('B6H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="143" class="ttt1" onmouseover="func1('B6H3-2')" onmouseout="func2()" onclick="func4('B6H3-2')">8</span></td>
                                         <td class="tt"><span id="140" class="ttt1" onmouseover="func1('B6H2-2')" onmouseout="func2()" onclick="func4('B6H2-2')">5</span></td>
                                         <td class="tt"><span id="137" class="ttt1" onmouseover="func1('B6H1-2')" onmouseout="func2()" onclick="func4('B6H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="144" class="ttt1" onmouseover="func1('B6H3-1')" onmouseout="func2()" onclick="func4('B6H3-1')">9</span></td>
                                         <td class="tt"><span id="141" class="ttt1" onmouseover="func1('B6H2-1')" onmouseout="func2()" onclick="func4('B6H2-1')">6</span></td>
                                         <td class="tt"><span id="138" class="ttt1" onmouseover="func1('B6H1-1')" onmouseout="func2()" onclick="func4('B6H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">6</td>
                            <td style="padding:10px;">5</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="129" class="ttt1" onmouseover="func1('B5H1-3')" onmouseout="func2()" onclick="func4('B5H1-3')">3</span></td>
                                         <td class="tt"><span id="132" class="ttt1" onmouseover="func1('B5H2-3')" onmouseout="func2()" onclick="func4('B5H2-3')">6</span></td>
                                         <td class="tt"><span id="135" class="ttt1" onmouseover="func1('B5H3-3')" onmouseout="func2()" onclick="func4('B5H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="128" class="ttt1" onmouseover="func1('B5H1-2')" onmouseout="func2()" onclick="func4('B5H1-2')">2</span></td>
                                         <td class="tt"><span id="131" class="ttt1" onmouseover="func1('B5H2-2')" onmouseout="func2()" onclick="func4('B5H2-2')">5</span></td>
                                         <td class="tt"><span id="134" class="ttt1" onmouseover="func1('B5H3-2')" onmouseout="func2()" onclick="func4('B5H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="127" class="ttt1" onmouseover="func1('B5H1-1')" onmouseout="func2()" onclick="func4('B5H1-1')">1</span></td>
                                         <td class="tt"><span id="130" class="ttt1" onmouseover="func1('B5H2-1')" onmouseout="func2()" onclick="func4('B5H2-1')">4</span></td>
                                         <td class="tt"><span id="133" class="ttt1" onmouseover="func1('B5H3-1')" onmouseout="func2()" onclick="func4('B5H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="151" class="ttt1" onmouseover="func1('B7H3-3')" onmouseout="func2()" onclick="func4('B7H3-3')">7</span></td>
                                         <td class="tt"><span id="148" class="ttt1" onmouseover="func1('B7H2-3')" onmouseout="func2()" onclick="func4('B7H2-3')">4</span></td>
                                         <td class="tt"><span id="145" class="ttt1" onmouseover="func1('B7H1-3')" onmouseout="func2()" onclick="func4('B7H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="152" class="ttt1" onmouseover="func1('B7H3-2')" onmouseout="func2()" onclick="func4('B7H3-2')">8</span></td>
                                         <td class="tt"><span id="149" class="ttt1" onmouseover="func1('B7H2-2')" onmouseout="func2()" onclick="func4('B7H2-2')">5</span></td>
                                         <td class="tt"><span id="146" class="ttt1" onmouseover="func1('B7H1-2')" onmouseout="func2()" onclick="func4('B7H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="153" class="ttt1" onmouseover="func1('B7H3-1')" onmouseout="func2()" onclick="func4('B7H3-1')">9</span></td>
                                         <td class="tt"><span id="150" class="ttt1" onmouseover="func1('B7H2-1')" onmouseout="func2()" onclick="func4('B7H2-1')">6</span></td>
                                         <td class="tt"><span id="147" class="ttt1" onmouseover="func1('B7H1-1')" onmouseout="func2()" onclick="func4('B7H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">7</td>
                            <td style="padding:10px;">4</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="120" class="ttt1" onmouseover="func1('B4H1-3')" onmouseout="func2()" onclick="func4('B4H1-3')">3</span></td>
                                         <td class="tt"><span id="123" class="ttt1" onmouseover="func1('B4H2-3')" onmouseout="func2()" onclick="func4('B4H2-3')">6</span></td>
                                         <td class="tt"><span id="126" class="ttt1" onmouseover="func1('B4H3-3')" onmouseout="func2()" onclick="func4('B4H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="119" class="ttt1" onmouseover="func1('B4H1-2')" onmouseout="func2()" onclick="func4('B4H1-2')">2</span></td>
                                         <td class="tt"><span id="122" class="ttt1" onmouseover="func1('B4H2-2')" onmouseout="func2()" onclick="func4('B4H2-2')">5</span></td>
                                         <td class="tt"><span id="125" class="ttt1" onmouseover="func1('B4H3-2')" onmouseout="func2()" onclick="func4('B4H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="118" class="ttt1" onmouseover="func1('B4H1-1')" onmouseout="func2()" onclick="func4('B4H1-1')">1</span></td>
                                         <td class="tt"><span id="121" class="ttt1" onmouseover="func1('B4H2-1')" onmouseout="func2()" onclick="func4('B4H2-1')">4</span></td>
                                         <td class="tt"><span id="124" class="ttt1" onmouseover="func1('B4H3-1')" onmouseout="func2()" onclick="func4('B4H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="160" class="ttt1" onmouseover="func1('B8H3-3')" onmouseout="func2()" onclick="func4('B8H3-3')">7</span></td>
                                         <td class="tt"><span id="157" class="ttt1" onmouseover="func1('B8H2-3')" onmouseout="func2()" onclick="func4('B8H2-3')">4</span></td>
                                         <td class="tt"><span id="154" class="ttt1" onmouseover="func1('B8H1-3')" onmouseout="func2()" onclick="func4('B8H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="161" class="ttt1" onmouseover="func1('B8H3-2')" onmouseout="func2()" onclick="func4('B8H3-2')">8</span></td>
                                         <td class="tt"><span id="158" class="ttt1" onmouseover="func1('B8H2-2')" onmouseout="func2()" onclick="func4('B8H2-2')">5</span></td>
                                         <td class="tt"><span id="155" class="ttt1" onmouseover="func1('B8H1-2')" onmouseout="func2()" onclick="func4('B8H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="162" class="ttt1" onmouseover="func1('B8H3-1')" onmouseout="func2()" onclick="func4('B8H3-1')">9</span></td>
                                         <td class="tt"><span id="159" class="ttt1" onmouseover="func1('B8H2-1')" onmouseout="func2()" onclick="func4('B8H2-1')">6</span></td>
                                         <td class="tt"><span id="156" class="ttt1" onmouseover="func1('B8H1-1')" onmouseout="func2()" onclick="func4('B8H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">8</td>
                            <td style="padding:10px;">3</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="111" class="ttt1" onmouseover="func1('B3H1-3')" onmouseout="func2()" onclick="func4('B3H1-3')">3</span></td>
                                         <td class="tt"><span id="114" class="ttt1" onmouseover="func1('B3H2-3')" onmouseout="func2()" onclick="func4('B3H2-3')">6</span></td>
                                         <td class="tt"><span id="117" class="ttt1" onmouseover="func1('B3H3-3')" onmouseout="func2()" onclick="func4('B3H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="110" class="ttt1" onmouseover="func1('B3H1-2')" onmouseout="func2()" onclick="func4('B3H1-2')">2</span></td>
                                         <td class="tt"><span id="113" class="ttt1" onmouseover="func1('B3H2-2')" onmouseout="func2()" onclick="func4('B3H2-2')">5</span></td>
                                         <td class="tt"><span id="116" class="ttt1" onmouseover="func1('B3H3-2')" onmouseout="func2()" onclick="func4('B3H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="109" class="ttt1" onmouseover="func1('B3H1-1')" onmouseout="func2()" onclick="func4('B3H1-1')">1</span></td>
                                         <td class="tt"><span id="112" class="ttt1" onmouseover="func1('B3H2-1')" onmouseout="func2()" onclick="func4('B3H2-1')">4</span></td>
                                         <td class="tt"><span id="115" class="ttt1" onmouseover="func1('B3H3-1')" onmouseout="func2()" onclick="func4('B3H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="169" class="ttt1" onmouseover="func1('B9H3-3')" onmouseout="func2()" onclick="func4('B9H3-3')">7</span></td>
                                         <td class="tt"><span id="166" class="ttt1" onmouseover="func1('B9H2-3')" onmouseout="func2()" onclick="func4('B9H2-3')">4</span></td>
                                         <td class="tt"><span id="163" class="ttt1" onmouseover="func1('B9H1-3')" onmouseout="func2()" onclick="func4('B9H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="170" class="ttt1" onmouseover="func1('B9H3-2')" onmouseout="func2()" onclick="func4('B9H3-2')">8</span></td>
                                         <td class="tt"><span id="167" class="ttt1" onmouseover="func1('B9H2-2')" onmouseout="func2()" onclick="func4('B9H2-2')">5</span></td>
                                         <td class="tt"><span id="164" class="ttt1" onmouseover="func1('B9H1-2')" onmouseout="func2()" onclick="func4('B9H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="171" class="ttt1" onmouseover="func1('B9H3-1')" onmouseout="func2()" onclick="func4('B9H3-1')">9</span></td>
                                         <td class="tt"><span id="168" class="ttt1" onmouseover="func1('B9H2-1')" onmouseout="func2()" onclick="func4('B9H2-1')">6</span></td>
                                         <td class="tt"><span id="165" class="ttt1" onmouseover="func1('B9H1-1')" onmouseout="func2()" onclick="func4('B9H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">9</td>
                            <td style="padding:10px;">2</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="102" class="ttt1" onmouseover="func1('B2H1-3')" onmouseout="func2()" onclick="func4('B2H1-3')">3</span></td>
                                         <td class="tt"><span id="105" class="ttt1" onmouseover="func1('B2H2-3')" onmouseout="func2()" onclick="func4('B2H2-3')">6</span></td>
                                         <td class="tt"><span id="108" class="ttt1" onmouseover="func1('B2H3-3')" onmouseout="func2()" onclick="func4('B2H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="101" class="ttt1" onmouseover="func1('B2H1-2')" onmouseout="func2()" onclick="func4('B2H1-2')">2</span></td>
                                         <td class="tt"><span id="104" class="ttt1" onmouseover="func1('B2H2-2')" onmouseout="func2()" onclick="func4('B2H2-2')">5</span></td>
                                         <td class="tt"><span id="107" class="ttt1" onmouseover="func1('B2H3-2')" onmouseout="func2()" onclick="func4('B2H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="100" class="ttt1" onmouseover="func1('B2H1-1')" onmouseout="func2()" onclick="func4('B2H1-1')">1</span></td>
                                         <td class="tt"><span id="103" class="ttt1" onmouseover="func1('B2H2-1')" onmouseout="func2()" onclick="func4('B2H2-1')">4</span></td>
                                         <td class="tt"><span id="106" class="ttt1" onmouseover="func1('B2H3-1')" onmouseout="func2()" onclick="func4('B2H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="178" class="ttt1" onmouseover="func1('B10H3-3')" onmouseout="func2()" onclick="func4('B10H3-3')">7</span></td>
                                         <td class="tt"><span id="175" class="ttt1" onmouseover="func1('B10H2-3')" onmouseout="func2()" onclick="func4('B10H2-3')">4</span></td>
                                         <td class="tt"><span id="172" class="ttt1" onmouseover="func1('B10H1-3')" onmouseout="func2()" onclick="func4('B10H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="179" class="ttt1" onmouseover="func1('B10H3-2')" onmouseout="func2()" onclick="func4('B10H3-2')">8</span></td>
                                         <td class="tt"><span id="176" class="ttt1" onmouseover="func1('B10H2-2')" onmouseout="func2()" onclick="func4('B10H2-2')">5</span></td>
                                         <td class="tt"><span id="173" class="ttt1" onmouseover="func1('B10H1-2')" onmouseout="func2()" onclick="func4('B10H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="180" class="ttt1" onmouseover="func1('B10H3-1')" onmouseout="func2()" onclick="func4('B10H3-1')">9</span></td>
                                         <td class="tt"><span id="177" class="ttt1" onmouseover="func1('B10H2-1')" onmouseout="func2()" onclick="func4('B10H2-1')">6</span></td>
                                         <td class="tt"><span id="174" class="ttt1" onmouseover="func1('B10H1-1')" onmouseout="func2()" onclick="func4('B10H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">10</td>
                            <td style="padding:10px;">1</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="93" class="ttt1" onmouseover="func1('B1H1-3')" onmouseout="func2()" onclick="func4('B1H1-3')">3</span></td>
                                         <td class="tt"><span id="96" class="ttt1" onmouseover="func1('B1H2-3')" onmouseout="func2()" onclick="func4('B1H2-3')">6</span></td>
                                         <td class="tt"><span id="99" class="ttt1" onmouseover="func1('B1H3-3')" onmouseout="func2()" onclick="func4('B1H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="92" class="ttt1" onmouseover="func1('B1H1-2')" onmouseout="func2()" onclick="func4('B1H1-2')">2</span></td>
                                         <td class="tt"><span id="95" class="ttt1" onmouseover="func1('B1H2-2')" onmouseout="func2()" onclick="func4('B1H2-2')">5</span></td>
                                         <td class="tt"><span id="98" class="ttt1" onmouseover="func1('B1H3-2')" onmouseout="func2()" onclick="func4('B1H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="91" class="ttt1" onmouseover="func1('B1H1-1')" onmouseout="func2()" onclick="func4('B1H1-1')">1</span></td>
                                         <td class="tt"><span id="94" class="ttt1" onmouseover="func1('B1H2-1')" onmouseout="func2()" onclick="func4('B1H2-1')">4</span></td>
                                         <td class="tt"><span id="97" class="ttt1" onmouseover="func1('B1H3-1')" onmouseout="func2()" onclick="func4('B1H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                        <tr><td colspan="4" style="text-align:center;">B</td></tr>
                    </table>
                </td>
                <td>
                    <table >
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="52" class="ttt1" onmouseover="func1('A6H3-3')" onmouseout="func2()" onclick="func4('A6H3-3')">7</span></td>
                                         <td class="tt"><span id="49" class="ttt1" onmouseover="func1('A6H2-3')" onmouseout="func2()" onclick="func4('A6H2-3')">4</span></td>
                                         <td class="tt"><span id="46" class="ttt1" onmouseover="func1('A6H1-3')" onmouseout="func2()" onclick="func4('A6H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="53" class="ttt1" onmouseover="func1('A6H3-2')" onmouseout="func2()" onclick="func4('A6H3-2')">8</span></td>
                                         <td class="tt"><span id="50" class="ttt1" onmouseover="func1('A6H2-2')" onmouseout="func2()" onclick="func4('A6H2-2')">5</span></td>
                                         <td class="tt"><span id="47" class="ttt1" onmouseover="func1('A6H1-2')" onmouseout="func2()" onclick="func4('A6H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="54" class="ttt1" onmouseover="func1('A6H3-1')" onmouseout="func2()" onclick="func4('A6H3-1')">9</span></td>
                                         <td class="tt"><span id="51" class="ttt1" onmouseover="func1('A6H2-1')" onmouseout="func2()" onclick="func4('A6H2-1')">6</span></td>
                                         <td class="tt"><span id="48" class="ttt1" onmouseover="func1('A6H1-1')" onmouseout="func2()" onclick="func4('A6H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">6</td>
                            <td style="padding:10px;">5</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="39" class="ttt1" onmouseover="func1('A5H1-3')" onmouseout="func2()" onclick="func4('A5H1-3')">3</span></td>
                                         <td class="tt"><span id="42" class="ttt1" onmouseover="func1('A5H2-3')" onmouseout="func2()" onclick="func4('A5H2-3')">6</span></td>
                                         <td class="tt"><span id="45" class="ttt1" onmouseover="func1('A5H3-3')" onmouseout="func2()" onclick="func4('A5H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="38" class="ttt1" onmouseover="func1('A5H1-2')" onmouseout="func2()" onclick="func4('A5H1-2')">2</span></td>
                                         <td class="tt"><span id="41" class="ttt1" onmouseover="func1('A5H2-2')" onmouseout="func2()" onclick="func4('A5H2-2')">5</span></td>
                                         <td class="tt"><span id="44" class="ttt1" onmouseover="func1('A5H3-2')" onmouseout="func2()" onclick="func4('A5H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="37" class="ttt1" onmouseover="func1('A5H1-1')" onmouseout="func2()" onclick="func4('A5H1-1')">1</span></td>
                                         <td class="tt"><span id="40" class="ttt1" onmouseover="func1('A5H2-1')" onmouseout="func2()" onclick="func4('A5H2-1')">4</span></td>
                                         <td class="tt"><span id="43" class="ttt1" onmouseover="func1('A5H3-1')" onmouseout="func2()" onclick="func4('A5H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="61" class="ttt1" onmouseover="func1('A7H3-3')" onmouseout="func2()" onclick="func4('A7H3-3')">7</span></td>
                                         <td class="tt"><span id="58" class="ttt1" onmouseover="func1('A7H2-3')" onmouseout="func2()" onclick="func4('A7H2-3')">4</span></td>
                                         <td class="tt"><span id="55" class="ttt1" onmouseover="func1('A7H1-3')" onmouseout="func2()" onclick="func4('A7H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="62" class="ttt1" onmouseover="func1('A7H3-2')" onmouseout="func2()" onclick="func4('A7H3-2')">8</span></td>
                                         <td class="tt"><span id="59" class="ttt1" onmouseover="func1('A7H2-2')" onmouseout="func2()" onclick="func4('A7H2-2')">5</span></td>
                                         <td class="tt"><span id="56" class="ttt1" onmouseover="func1('A7H1-2')" onmouseout="func2()" onclick="func4('A7H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="63" class="ttt1" onmouseover="func1('A7H3-1')" onmouseout="func2()" onclick="func4('A7H3-1')">9</span></td>
                                         <td class="tt"><span id="60" class="ttt1" onmouseover="func1('A7H2-1')" onmouseout="func2()" onclick="func4('A7H2-1')">6</span></td>
                                         <td class="tt"><span id="57" class="ttt1" onmouseover="func1('A7H1-1')" onmouseout="func2()" onclick="func4('A7H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">7</td>
                            <td style="padding:10px;">4</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="30" class="ttt1" onmouseover="func1('A4H1-3')" onmouseout="func2()" onclick="func4('A4H1-3')">3</span></td>
                                         <td class="tt"><span id="33" class="ttt1" onmouseover="func1('A4H2-3')" onmouseout="func2()" onclick="func4('A4H2-3')">6</span></td>
                                         <td class="tt"><span id="36" class="ttt1" onmouseover="func1('A4H3-3')" onmouseout="func2()" onclick="func4('A4H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="29" class="ttt1" onmouseover="func1('A4H1-2')" onmouseout="func2()" onclick="func4('A4H1-2')">2</span></td>
                                         <td class="tt"><span id="32" class="ttt1" onmouseover="func1('A4H2-2')" onmouseout="func2()" onclick="func4('A4H2-2')">5</span></td>
                                         <td class="tt"><span id="35" class="ttt1" onmouseover="func1('A4H3-2')" onmouseout="func2()" onclick="func4('A4H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="28" class="ttt1" onmouseover="func1('A4H1-1')" onmouseout="func2()" onclick="func4('A4H1-1')">1</span></td>
                                         <td class="tt"><span id="31" class="ttt1" onmouseover="func1('A4H2-1')" onmouseout="func2()" onclick="func4('A4H2-1')">4</span></td>
                                         <td class="tt"><span id="34" class="ttt1" onmouseover="func1('A4H3-1')" onmouseout="func2()" onclick="func4('A4H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="70" class="ttt1" onmouseover="func1('A8H3-3')" onmouseout="func2()" onclick="func4('A8H3-3')">7</span></td>
                                         <td class="tt"><span id="67" class="ttt1" onmouseover="func1('A8H2-3')" onmouseout="func2()" onclick="func4('A8H2-3')">4</span></td>
                                         <td class="tt"><span id="64" class="ttt1" onmouseover="func1('A8H1-3')" onmouseout="func2()" onclick="func4('A8H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="71" class="ttt1" onmouseover="func1('A8H3-2')" onmouseout="func2()" onclick="func4('A8H3-2')">8</span></td>
                                         <td class="tt"><span id="68" class="ttt1" onmouseover="func1('A8H2-2')" onmouseout="func2()" onclick="func4('A8H2-2')">5</span></td>
                                         <td class="tt"><span id="65" class="ttt1" onmouseover="func1('A8H1-2')" onmouseout="func2()" onclick="func4('A8H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="72" class="ttt1" onmouseover="func1('A8H3-1')" onmouseout="func2()" onclick="func4('A8H3-1')">9</span></td>
                                         <td class="tt"><span id="69" class="ttt1" onmouseover="func1('A8H2-1')" onmouseout="func2()" onclick="func4('A8H2-1')">6</span></td>
                                         <td class="tt"><span id="66" class="ttt1" onmouseover="func1('A8H1-1')" onmouseout="func2()" onclick="func4('A8H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">8</td>
                            <td style="padding:10px;">3</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="21" class="ttt1" onmouseover="func1('A3H1-3')" onmouseout="func2()" onclick="func4('A3H1-3')">3</span></td>
                                         <td class="tt"><span id="24" class="ttt1" onmouseover="func1('A3H2-3')" onmouseout="func2()" onclick="func4('A3H2-3')">6</span></td>
                                         <td class="tt"><span id="27" class="ttt1" onmouseover="func1('A3H3-3')" onmouseout="func2()" onclick="func4('A3H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="20" class="ttt1" onmouseover="func1('A3H1-2')" onmouseout="func2()" onclick="func4('A3H1-2')">2</span></td>
                                         <td class="tt"><span id="23" class="ttt1" onmouseover="func1('A3H2-2')" onmouseout="func2()" onclick="func4('A3H2-2')">5</span></td>
                                         <td class="tt"><span id="26" class="ttt1" onmouseover="func1('A3H3-2')" onmouseout="func2()" onclick="func4('A3H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="19" class="ttt1" onmouseover="func1('A3H1-1')" onmouseout="func2()" onclick="func4('A3H1-1')">1</span></td>
                                         <td class="tt"><span id="22" class="ttt1" onmouseover="func1('A3H2-1')" onmouseout="func2()" onclick="func4('A3H2-1')">4</span></td>
                                         <td class="tt"><span id="25" class="ttt1" onmouseover="func1('A3H3-1')" onmouseout="func2()" onclick="func4('A3H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="79" class="ttt1" onmouseover="func1('A9H3-3')" onmouseout="func2()" onclick="func4('A9H3-3')">7</span></td>
                                         <td class="tt"><span id="76" class="ttt1" onmouseover="func1('A9H2-3')" onmouseout="func2()" onclick="func4('A9H2-3')">4</span></td>
                                         <td class="tt"><span id="73" class="ttt1" onmouseover="func1('A9H1-3')" onmouseout="func2()" onclick="func4('A9H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="80" class="ttt1" onmouseover="func1('A9H3-2')" onmouseout="func2()" onclick="func4('A9H3-2')">8</span></td>
                                         <td class="tt"><span id="77" class="ttt1" onmouseover="func1('A9H2-2')" onmouseout="func2()" onclick="func4('A9H2-2')">5</span></td>
                                         <td class="tt"><span id="74" class="ttt1" onmouseover="func1('A9H1-2')" onmouseout="func2()" onclick="func4('A9H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="81" class="ttt1" onmouseover="func1('A9H3-1')" onmouseout="func2()" onclick="func4('A9H3-1')">9</span></td>
                                         <td class="tt"><span id="78" class="ttt1" onmouseover="func1('A9H2-1')" onmouseout="func2()" onclick="func4('A9H2-1')">6</span></td>
                                         <td class="tt"><span id="75" class="ttt1" onmouseover="func1('A9H1-1')" onmouseout="func2()" onclick="func4('A9H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">9</td>
                            <td style="padding:10px;">2</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="12" class="ttt1" onmouseover="func1('A2H1-3')" onmouseout="func2()" onclick="func4('A2H1-3')">3</span></td>
                                         <td class="tt"><span id="15" class="ttt1" onmouseover="func1('A2H2-3')" onmouseout="func2()" onclick="func4('A2H2-3')">6</span></td>
                                         <td class="tt"><span id="18" class="ttt1" onmouseover="func1('A2H3-3')" onmouseout="func2()" onclick="func4('A2H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="11" class="ttt1" onmouseover="func1('A2H1-2')" onmouseout="func2()" onclick="func4('A2H1-2')">2</span></td>
                                         <td class="tt"><span id="14" class="ttt1" onmouseover="func1('A2H2-2')" onmouseout="func2()" onclick="func4('A2H2-2')">5</span></td>
                                         <td class="tt"><span id="17" class="ttt1" onmouseover="func1('A2H3-2')" onmouseout="func2()" onclick="func4('A2H3-2')">8</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="10" class="ttt1" onmouseover="func1('A2H1-1')" onmouseout="func2()" onclick="func4('A2H1-1')">1</span></td>
                                         <td class="tt"><span id="13" class="ttt1" onmouseover="func1('A2H2-1')" onmouseout="func2()" onclick="func4('A2H2-1')">4</span></td>
                                         <td class="tt"><span id="16" class="ttt1" onmouseover="func1('A2H3-1')" onmouseout="func2()" onclick="func4('A2H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                         <tr>
                            <td>
                                <br />
                                <table>
                                    <tr>
                                         <td class="tt"><span id="88" class="ttt1" onmouseover="func1('A10H3-3')" onmouseout="func2()" onclick="func4('A10H3-3')">7</span></td>
                                         <td class="tt"><span id="85" class="ttt1" onmouseover="func1('A10H2-3')" onmouseout="func2()" onclick="func4('A10H2-3')">4</span></td>
                                         <td class="tt"><span id="82" class="ttt1" onmouseover="func1('A10H1-3')" onmouseout="func2()" onclick="func4('A10H1-3')">1</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="89" class="ttt1" onmouseover="func1('A10H3-2')" onmouseout="func2()" onclick="func4('A10H3-2')">8</span></td>
                                         <td class="tt"><span id="86" class="ttt1" onmouseover="func1('A10H2-2')" onmouseout="func2()" onclick="func4('A10H2-2')">5</span></td>
                                         <td class="tt"><span id="83" class="ttt1" onmouseover="func1('A10H1-2')" onmouseout="func2()" onclick="func4('A10H1-2')">2</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="90" class="ttt1" onmouseover="func1('A10H3-1')" onmouseout="func2()" onclick="func4('A10H3-1')">9</span></td>
                                         <td class="tt"><span id="87" class="ttt1" onmouseover="func1('A10H2-1')" onmouseout="func2()" onclick="func4('A10H2-1')">6</span></td>
                                         <td class="tt"><span id="84" class="ttt1" onmouseover="func1('A10H1-1')" onmouseout="func2()" onclick="func4('A10H1-1')">3</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                            <td style="padding:10px;">10</td>
                            <td style="padding:10px;">1</td>
                            <td>
                                <br />
                               <table>
                                    <tr>
                                         <td class="tt"><span id="3" class="ttt1" onmouseover="func1('A1H1-3')" onmouseout="func2()" onclick="func4('A1H1-3')">3</span></td>
                                         <td class="tt"><span id="6" class="ttt1" onmouseover="func1('A1H2-3')" onmouseout="func2()" onclick="func4('A1H2-3')">6</span></td>
                                         <td class="tt"><span id="9" class="ttt1" onmouseover="func1('A1H3-3')" onmouseout="func2()" onclick="func4('A1H3-3')">9</span></td>
                                    </tr>
                                    <tr>
                                         <td class="tt"><span id="2" class="ttt1" onmouseover="func1('A1H1-2')" onmouseout="func2()" onclick="func4('A1H1-2')">2</span></td>
                                         <td class="tt"><span id="5" class="ttt1" onmouseover="func1('A1H2-2')" onmouseout="func2()" onclick="func4('A1H2-2')">5</span></td>
                                         <td class="tt"><span id="8" class="ttt1" onmouseover="func1('A1H3-2')" onmouseout="func2()" onclick="func4('A1H3-2')">8</span></td>
                                    </tr>
                                    <tr>                      
                                         <td class="tt"><span id="1" class="ttt1" onmouseover="func1('A1H1-1')" onmouseout="func2()" onclick="func4('A1H1-1')">1</span></td>
                                         <td class="tt"><span id="4" class="ttt1" onmouseover="func1('A1H2-1')" onmouseout="func2()" onclick="func4('A1H2-1')">4</span></td>
                                         <td class="tt"><span id="7" class="ttt1" onmouseover="func1('A1H3-1')" onmouseout="func2()" onclick="func4('A1H3-1')">7</span></td>
                                    </tr>
                                </table>
                                <br />
                            </td>                            
                        </tr>
                        <tr><td colspan="4" style="text-align:center;">A</td></tr>
                    </table>
                </td>
            </tr>
        </table>
        
        </div>
    </div>     
    <center>
        <div id="aaa" style="display:none;"></div>
    </center>
</asp:Content>
