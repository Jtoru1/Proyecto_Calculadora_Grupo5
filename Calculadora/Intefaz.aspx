<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intefaz.aspx.cs" Inherits="Calculadora.Intefaz" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Proyecto Calculadora</title>
    <link rel="stylesheet" type="text/css" href="Estilos.css" />
  
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" ID="resultado" CssClass="result-box"></asp:Label>
        <div class="grid-container">
            <asp:Button runat="server" ID= "btn_raiz" CssClass="grid-item" Text="²√x" OnClick="BotonRaiz_Click" />
            <asp:Button runat="server" ID= "btn_limpiar" CssClass="grid-item" Text="C" OnClick="BotonLimpiar_Click" />
            <asp:ImageButton runat="server" ID="btnBorrar" ImageUrl="~/Imagenes/btnborrar.jpg" OnClick="BotonBorrar_Click" />
            <asp:Button runat="server" ID= "btn_fact" CssClass="grid-item" Text="n!" OnClick="BotonFactorial_Click" />
            <asp:Button runat="server" ID= "btn_div" CssClass="grid-item" Text="÷" OnClick="BotonDivision_Click" />
            <asp:Button runat="server" ID= "btn_poty" CssClass="grid-item" Text="xʸ" OnClick="Botonpotenciay_Click" />
            <asp:Button runat="server" ID= "btn_7" CssClass="grid-item" Text="7" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_8" CssClass="grid-item" Text="8" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_9" CssClass="grid-item" Text="9" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_mult" CssClass="grid-item" Text="x" OnClick="BotonMultiplicacion_Click" />
            <asp:Button runat="server" ID= "btn_pot10" CssClass="grid-item" Text="10ˣ" OnClick="Boton10Potencia_Click" />
            <asp:Button runat="server" ID= "btn_4" CssClass="grid-item" Text="4" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_5" CssClass="grid-item" Text="5" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_6" CssClass="grid-item" Text="6" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_resta" CssClass="grid-item" Text="-" OnClick="BotonResta_Click" />
            <asp:Button runat="server" ID= "btn_log" CssClass="grid-item" Text="log" OnClick="Botonlog_Click" />
            <asp:Button runat="server" ID= "btn_1" CssClass="grid-item" Text="1" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_2" CssClass="grid-item" Text="2" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_3" CssClass="grid-item" Text="3" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_suma" CssClass="grid-item" Text="+" OnClick="BotonSuma_Click" />
            <asp:Button runat="server" ID= "btn_potencia2" CssClass="grid-item" Text="x²" OnClick="BotonPotencia2_Click" />
            <asp:Button runat="server" ID= "btn_nyp" CssClass="grid-item" Text="+/-" OnClick="BotonMasyMenos_Click" />
            <asp:Button runat="server" ID= "btn_0" CssClass="grid-item" Text="0" OnClick="BotonNumero_Click" />
            <asp:Button runat="server" ID= "btn_coma" CssClass="grid-item" Text="," OnClick="BotonComa_Click" />
            <asp:Button runat="server" ID= "btn_igual" CssClass="grid-item" Text="=" OnClick="BotonIgual_Click" />
            
        </div>
     
        
    </form>
</body>
</html>

