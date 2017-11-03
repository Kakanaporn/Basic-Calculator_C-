using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * PORTFOLIO ACTIVITY 1.6
 * Supanat Kakanaporn
 * ID: 445682
 * Using math libraries with the following methods
    Arithmetic
         Addition
         Subtraction
         Division
         Multiplication
 */
namespace Arithmetic
{
    public class Arithmetic
    {
        public static double Add(double input1, double input2)//Addition method
        {
            return (input1 + input2);
        }
        public static double Sub(double input1, double input2)//Subtraction method
        {
            return ((input1 - input2));
        }
        public static double Div(double input1, double input2)//Division Method
        {
            return (input1 / input2);
        }
        public static double Mult(double input1, double input2)//Multiplication Method
        {
            return (input2 * input2);
        }
    }
}
