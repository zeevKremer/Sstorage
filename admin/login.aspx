<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Sstorage.admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title> כניסה למערכת | Sstorage</title>
<link rel="icon" type="image/png" href="/images/icon.png">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><br />
        <image src="../images/logo.jpg" id="logo"></image>
                <h1 id="h" style="color:#4800ff;">Sstorage</h1>
            <br /><br />
             
           <div id="t1" style="width:1450px;">
               <label id="p1"  style="pading:20px; direction:rtl; text-align:right;">שם משתמש</label>
               <span style="pading:20px;">
                   <asp:TextBox ID="TxtUserName"  runat="server"></asp:TextBox>
               </span>
           </div>
           <asp:Literal ID="tval1" runat="server"></asp:Literal><br />
           <div id="T2">
              <label id="t" style="pading:20px; width:450px; direction:rtl; text-align:right;">   סיסמה</label>
                <span style="pading:20px;">
                    <asp:TextBox ID="TxtPassword" type="password" runat="server"></asp:TextBox>
                </span>
           </div>
           <asp:Literal ID="tval2" runat="server"></asp:Literal>
           <br /><br />           
            <asp:Button ID="btn1" Text="אישור" runat="server" OnClick="btn1_Click" />            
            <br /><br /> <br /><br /> <br /><br /> <br /><br /> 
    
        </div>
    </form>
    <style>
        body {
    text-align: center;
    direction: rtl;
    background-color: #6fc0f1;
    width: 1500px;  
}

#h {
     color: #ff0000;
    font-family: Gabriola;
    font-size: 50px;
}
#logo{
width:180px;

}

#log {
    align-content: center;
}

#T1 {
    align-items: end;
    width: 1500px;
    height: 40px;
}

#T2 {
    align-items: end;
}

#1 {
    width: 1500px;
}

#2 {
    width: 100%;
}

#3 {
    width: 800px;
}

#4 {
    width: 500px;
}

#t1 {
    color: #4800ff;
    font-family: Gabriola;
    font-size: 25px;
    height: 80%;
    width: 100%;
}

#p1 {
    width: 700px;
    color: #4800ff;
    font-family: Gabriola;
    font-size: 25px;
}

#t2 {
    color: #4800ff;
    font-family: Gabriola;
    font-size: 25px;
    height: 80%;
    width: 50%;
}

#t {
    color: #4800ff;
    font-family: Gabriola;
    font-size: 25px;
    width: 100px;
    width: 750px;
}

#TxtUserName {
    height: 25px;
    width: 300px;
    font-size: 25px;
}

#TxtPassword {
    height: 25px;
    width: 300px;
    font-size: 25px;
}

#tval1 {
    color: #ff0000;
}

#tval2 {
}

#btn1 {
    height: 40px;
    width: 100px;
    font-size: 25px;
    background-color: #54e6a0;
    color: #af22f1;
}

    #btn1:hover {
        background-color: #4800ff;
        color: #00ff21;
        text-decoration: none;
    }

    </style>
</body>
</html>
