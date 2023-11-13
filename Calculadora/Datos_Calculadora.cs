using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora
{
    public class Datos_Calculadora
    {
        public static double Valor1 { get; set; }
        public static string Operacion { get; set; }

        public void SetValor1(double valor)
        {
            Valor1 = valor;
        }

        public void SetOperacion(string operacion)
        {
            Operacion = operacion;
        }
    }
    }