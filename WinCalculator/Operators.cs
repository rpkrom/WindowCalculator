using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCalculator
{
    class Operators
    {
       public static int add(int n1, int n2)
        {
            return n1 + n2;
        }

       public static Double add(Double n1,Double n2)
       {
           return n1 + n2;
       }

       public static int subtract(int n1, int n2)
       {
           return n1 - n2;
       }

       public static Double subtract(Double n1, Double n2)
       {
           return n1 - n2;
       }

       public static int multiply(int n1, int n2)
       {
           return n1 * n2;
       }

       public static Double multiply(Double n1, Double n2)
       {
           return n1 * n2;
       }

       public static int divide(int n1, int n2)
       {
           return n1 / n2;
       }

       public static Double divide(Double n1, Double n2)
       {
           return n1 / n2;
       }

       public static Double sqrt(int n1)
       {
           return Math.Sqrt(n1);
       }

       public static Double sqrt(Double n1)
       {
           return Math.Sqrt(n1);
       }
    }
}
