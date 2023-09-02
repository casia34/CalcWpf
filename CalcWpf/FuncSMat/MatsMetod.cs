using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;

namespace CalcWpf.FuncSMat
{
    class MatsMetod
    {
       
        public static int somma(int a, int b)
        {
           return a + b;
        }
        public static float somma(float a, int b)
        {
            return a + b;
        }
        public static float somma(int a, float b)
        {
            return a + b;
        }
        public static float somma(float a, float b)
        {
            return a + b;          
        }
        public static decimal somma(int a, decimal b)
        {
            return a + b;
        }
        public static decimal somma(decimal a, int b)
        {
            return a + b;
        }
        public static decimal somma(decimal a, decimal b)
        {
            return a + b;
        }

    }
}
