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
       
        public static decimal somma(decimal a, decimal b)
        {
            return a + b;
        }
        public static decimal sottrazione(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Divisione(decimal a, decimal b)
        {
            return a / b;
        }
        public static decimal Moltiplicazione(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
