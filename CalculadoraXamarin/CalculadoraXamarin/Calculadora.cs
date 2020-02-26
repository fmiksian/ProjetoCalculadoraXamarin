using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CalculadoraXamarin
{
  public  class Calculadora
    {
        private bool blnDecimal, blnOperador;
        private double dblValorVisor, dblOperando1, dblOperando2, dblResultado;
        private int intDigitos, intFavorDivisao;
        private char chrOperador;
        private string strValorVisor;

        public Calculadora()
        {
            blnDecimal = false;
            blnOperador = false;
            intFavorDivisao = 1;
            dblValorVisor = 0;
            dblOperando1 = 0;
            dblOperando2 = 0;
            dblResultado = 0;
            intDigitos = 0;
            chrOperador = ' ';
            strValorVisor = "0";


        }

        public string ValorVisor
        {
            get { return strValorVisor; }

        }
        private void ConverterValor()
        {

            strValorVisor = String.Format(new CultureInfo("pr-BR"), "{0:0:00}", dblValorVisor);
        }

        private void Inicializar()
        {
            dblOperando1 = 0.0;
            dblOperando2 = 0.0;
            intDigitos = 0;
            intFavorDivisao = 1;
            blnDecimal = false;
            blnOperador = false;
            chrOperador = ' ';

        }
        private int Fatorial(int intValor)
        {
            int intResultado = 1;
            for (int intContador = 2; intContador <= intValor; intContador++)
                intResultado *= intContador;
            return intResultado;

        }

        private double ConverterRadianos(double dblValorAngulo) => (dblValorAngulo * 0.0174532925);
        public void TeclaNumeros(double dblDigitos)
        {
            if (intDigitos <= 10)
            {
                if (blnDecimal)
                {
                    intFavorDivisao *= 10;
                    dblValorVisor += (dblDigitos / intFavorDivisao);

                }
                else
                    dblValorVisor = (dblValorVisor * 10) + dblDigitos;
                intDigitos++;
                ConverterValor();
            }
        }

        public void TeclaVirgula()
        {
            if (!blnDecimal)
            {
                blnDecimal = true;
                intFavorDivisao = 1;
                dblValorVisor /= intFavorDivisao;
                ConverterValor();
            }
        }

        public void TeclaIgual()
        {
            if (!blnOperador)
            {
                dblOperando1 = dblValorVisor;
                dblValorVisor = 0.0;
            }

            else
            {
                dblOperando2 = dblValorVisor;
                switch (chrOperador)
                {
                    case '/':
                        if (dblOperando2 > 0.0)
                            dblResultado = dblOperando1 / dblOperando2;
                        break;
                    case 'X':
                        dblResultado = dblOperando1 - dblOperando2;
                        break;
                    case '-':
                        dblResultado = dblOperando1 - dblOperando2;
                        break;
                    case '+':
                        dblResultado = dblOperando1 + dblOperando2;
                        break;
                }
                dblOperando1 = dblResultado;
                dblValorVisor = dblResultado;
            }
            ConverterValor();
            blnDecimal = false;
        }

        public void TeclaDivisao()
        {
            chrOperador = '/';
            TeclaIgual();
            blnOperador = true;
        }

        public void TeclaMultiplicacao()
        {
            chrOperador = 'X';
            TeclaIgual();
            blnOperador = true;
        }

        public void TeclaSubtracao()
        {
            chrOperador = '-';
            TeclaIgual();
            blnOperador = true;
        }

        public void TeclaAdicao()
        {
            chrOperador = '+';
            TeclaIgual();
            blnOperador = true;
        }


        public void TeclaLimparCE()
        {
            dblValorVisor = 0.0;
            intDigitos = 0;
            blnDecimal = false;
            blnOperador = false;
            ConverterValor();
        }

        public void TeclaLimparC()
        {
            dblValorVisor = 0.0;
            dblResultado = 0.0;

            Inicializar();
            ConverterValor();
        }

        public void TeclaElevarQuadrado()
        {

            dblResultado = dblValorVisor * dblValorVisor;
            dblValorVisor = dblResultado;
            ConverterValor();
            Inicializar();
        }

        public void TeclaRaizQuadrada()
        {

            dblResultado = Math.Sqrt(dblValorVisor);
            dblValorVisor = dblResultado;
            ConverterValor();
            Inicializar();
        }

        public void TeclaSeno()
        {

            dblResultado = Math.Sin(ConverterRadianos(dblValorVisor));
            dblValorVisor = dblResultado;
            ConverterValor();
            Inicializar();
        }

        public void TeclaCosseno()
        {

            dblResultado = Math.Cos(ConverterRadianos(dblValorVisor));
            dblValorVisor = dblResultado;
            ConverterValor();
            Inicializar();
        }

        public void TeclaTangente()
        {

            dblResultado = Math.Tan(ConverterRadianos(dblValorVisor));
            dblValorVisor = dblResultado;
            ConverterValor();
            Inicializar();
        }

        public void TeclaFatorial()
        {

            dblResultado = Fatorial((int)dblValorVisor);
            dblValorVisor = dblResultado;
            ConverterValor();
            Inicializar();
        }

        public void TeclaConversao(int intOpcaoConversao)
        {
            double[] dblFatorMultiplicacao = { 2.54, 0.3937, 1.609, 0.6214, 16.387064, 0.0610237, 3.7854117, 0.2642, 0.4536, 2.205, 0.4047, 2.417 };
            dblResultado = dblValorVisor * dblFatorMultiplicacao[intOpcaoConversao];
            dblValorVisor = dblResultado;
            ConverterValor();
            Inicializar();
        }
    }
}
