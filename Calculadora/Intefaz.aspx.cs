using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{

    public partial class Intefaz : System.Web.UI.Page
    {
        double valor1 = 0;
        double valor2 = 0;
        double valor_operacion = 0;
        string operacion ="";
        protected void Page_Load(object sender, EventArgs e)
        {
       
        }
        protected void BotonNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            resultado.Text += "" + boton.Text;
        }
     
        protected void BotonBorrar_Click(object sender, ImageClickEventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "ERROR" || resultado.Text=="NaN")
            {
                resultado.Text = "";
            }else if (!string.IsNullOrEmpty(resultado.Text))
            {
                resultado.Text = resultado.Text.Substring(0, resultado.Text.Length - 1);
            }
               
            
        }
        protected void BotonLimpiar_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            valor_operacion = 0;
            resultado.Text = "";
            Datos_Calculadora.Valor1 = 0;
            Datos_Calculadora.Operacion = "";
        }
        protected void BotonComa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                // Verificar si el resultado ya tiene una coma
                if (!resultado.Text.Contains(","))
                {
                    // Agregar la coma solo si no existe
                    resultado.Text += ",";
                }
            }
        }
        protected void BotonIgual_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                valor2 = double.Parse(resultado.Text);
                if (resultado.Text.EndsWith(",") || resultado.Text.EndsWith("."))
                {
                    resultado.Text = resultado.Text.Substring(0, resultado.Text.Length - 1);
                }
                
                switch (Datos_Calculadora.Operacion)
                {
                    case "+":
                        resultado.Text = (Datos_Calculadora.Valor1 + valor2).ToString();
                        break;
                    case "-":
                        resultado.Text = (Datos_Calculadora.Valor1 - valor2).ToString();
                        break;
                    case "*":
                        resultado.Text = (Datos_Calculadora.Valor1 * valor2).ToString();
                        break;
                        
                    case "/":
                        if (valor2 != 0)
                            resultado.Text = (Datos_Calculadora.Valor1 / valor2).ToString();
                        else
                            resultado.Text = "Error: División por cero";
                        break;
                    case "x*y":
                        resultado.Text = Math.Pow(Datos_Calculadora.Valor1, valor2).ToString();
                        break;
                    default:
                       // resultado.Text = "ERROR"; // Mensaje por defecto si no coincide con ninguna operación válida
                        break;
                }

                valor1 = 0;
                valor2 = 0;
                Datos_Calculadora.Valor1 = 0;
                Datos_Calculadora.Operacion = "";
                operacion = ""; // Restablecer operación a vacío para la próxima operación
            }
        }
        protected void BotonRaiz_Click(object sender, EventArgs e)

        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
               
                valor1 = double.Parse(resultado.Text);
                valor_operacion = Math.Sqrt(valor1);
                resultado.Text = valor_operacion.ToString();
            }
        }
        protected void Botonlog_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
               
                double logaritmo = Math.Log10(double.Parse(resultado.Text));
                resultado.Text = logaritmo.ToString();
            }

        }
        protected void BotonMasyMenos_Click(object obj, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
               
                valor1 = double.Parse(resultado.Text);
                valor_operacion = valor1 * -1;
                resultado.Text = valor_operacion.ToString();
            }
        }
        protected void BotonPotencia2_Click(object obj, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
               
                valor1 = double.Parse(resultado.Text);
                double resultadoPotencia = Math.Pow(valor1, 2);
                resultado.Text = resultadoPotencia.ToString();
            }
        }
        protected void Boton10Potencia_Click(object obj, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
              
                valor1 = double.Parse(resultado.Text);
                double resultadoPotencia = Math.Pow(10, valor1);
                resultado.Text = resultadoPotencia.ToString();
            }
        }
        protected void BotonPotencia_Click(object obj, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
               
                valor1 = double.Parse(resultado.Text);
                valor2 = double.Parse(resultado.Text);
                double resultadoPotencia = Math.Pow(valor1, valor2);
                resultado.Text = resultadoPotencia.ToString();
            }
        }
      
            int CalcularFactorial(int numero)
            {
                if (numero == 0)
                {
                    return 1;
                }
                int resultado = 1;
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }
        protected void BotonFactorial_Click (object obj, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                
                valor1 = double.Parse(resultado.Text);
                int factorial = CalcularFactorial((int)valor1);
                resultado.Text = factorial.ToString();
            }
        }
        protected void BotonSuma_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }

            if (!string.IsNullOrEmpty(resultado.Text))
            {
                
                valor1 = double.Parse(resultado.Text);
                operacion = "+";
                resultado.Text = "";
                Datos_Calculadora.Valor1 = valor1;
                Datos_Calculadora.Operacion = "+";
            }
        }
        protected void BotonResta_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(resultado.Text))
            {
                if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
                {
                    resultado.Text = "";
                }
                valor1 = double.Parse(resultado.Text);
                operacion = "-";
                resultado.Text = "";

                Datos_Calculadora.Valor1 = valor1;
                Datos_Calculadora.Operacion = "-";
            }
        }
        protected void BotonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                
                valor1 = double.Parse(resultado.Text);
                operacion = "*";
                resultado.Text = "";

                Datos_Calculadora.Valor1 = valor1;
                Datos_Calculadora.Operacion = "*";
            }
        }
        protected void BotonDivision_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
               
                valor1 = double.Parse(resultado.Text);
                operacion = "/";
                resultado.Text = "";

                Datos_Calculadora.Valor1 = valor1;
                Datos_Calculadora.Operacion = "/";
            }
        }
        protected void Botonpotenciay_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "Error: División por cero" || resultado.Text == "NaN")
            {
                resultado.Text = "";
            }
            if (!string.IsNullOrEmpty(resultado.Text))
            {
               
                valor1 = double.Parse(resultado.Text);
                operacion = "x*y";
                resultado.Text = "";

                Datos_Calculadora.Valor1 = valor1;
                Datos_Calculadora.Operacion = "x*y";
            }
        }
    }
}