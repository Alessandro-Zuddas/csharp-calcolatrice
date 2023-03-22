﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int SommaInt(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double SommaDouble(double num1, double num2)
        {
            return num1 + num2;
        }

        public static int DiffInt(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double DiffDouble(double num1, double num2)
        {
            return num1 - num2;
        }

        public static int MoltiInt(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double MoltiDouble(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int AssolutoInt(int num)
        {
            return Math.Abs(num);
        }

        public static double AssolutoDouble(double num)
        {
            return Math.Abs(num);
        }

        public static int MinInt(int num1, int num2)
        {
            if(num1 < num2)
            {
                return num1;
            }
            else if(num2 < num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        public static double MinDouble(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else if (num2 < num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        public static int MaxInt(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if (num2 > num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        public static double MaxDouble(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if (num2 > num1)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }
    }
}