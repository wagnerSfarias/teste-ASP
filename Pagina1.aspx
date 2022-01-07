<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Web.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link  href="CSS.css"rel="stylesheet"/>
    <title>LOGIN</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <header>
            <div class="logo">
              <a href="Home.aspx">
                  <img src="imagens/banner.hotel.jpg" alt="logo pagina"/>
              </a>  
            </div>
            <nav>
                <ul>
                    <li><a href="Home.aspx">INICIO</a></li>
                    <li><a href="#topo">LOGIN</a></li>
                    <li><a href="F_Resersas.aspx">RESERVAS</a></li>
                </ul>
            </nav>
        </header>
            <div class="divLogin">
              <h1 class="nomeLogin">LOGIN</h1>
              
          
              <asp:TextBox cssClass="txtUser" ID="tb_Usuario" runat="server" placeholder=" Usuario"></asp:TextBox>
         
             
              <asp:TextBox cssClass="txtPass" ID="tb_Senha" runat="server" TextMode="Password" placeholder=" Senha" maxlength ="11"></asp:TextBox>
             
           
              <asp:Label cssClass="avisoLogin" ID="Mensagem" Text="" runat="server"></asp:Label>
          
              <asp:Button cssClass="btnLogar" ID="btn_Logar" runat="server" Text="Logar" OnClick="btn_Logar_Click" />
              
          </div>    
        </div>
    </form>
</body>
</html>
