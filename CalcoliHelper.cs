using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int Somma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Somma(double num1, double num2)
        {
            return num1 + num2;
        }

        public static int Differenza(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double Differenza(double num1, double num2)
        {
            return num1 - num2;
        }

        public static int Moltiplicazione(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Moltiplicazione(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int Assoluto(int num)
        {
            return Math.Abs(num);
        }

        public static double Assoluto(double num)
        {
            return Math.Abs(num);
        }

        public static int Minimo(int num1, int num2)
        {
            return Math.Min(num1, num2);
        }

        public static double Minimo(double num1, double num2)
        {
            return Math.Min(num1, num2);
        }

        public static int Massimo(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        public static double Massimo(double num1, double num2)
        {
            return Math.Max(num1, num2);
        }

        public static int ElevaPotenza(int numero, int esponente)
        {
            if(numero == 0 || esponente == 0)
            {
                return 1;
            }
            else
            {
                 return (int)Math.Pow(numero, esponente);
            }
        }
    }
}
