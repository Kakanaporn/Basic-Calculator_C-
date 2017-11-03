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
    Algebraic
         Square Root
         Cube Root
         Inverse
 */
namespace Algebraic
{
    public class Algebraic
    {
        public static double sqrt(double input) //Square root method return to math function on systems.
        {
            return (System.Math.Sqrt(input));
        }
        public static double cubeRT(double input)//Cube root method return to math Power by (1/input)
        {

            return (System.Math.Pow(input, (1.0 / 3.0)));
        }
        public static double inv(double input)//Inverse method return value to 1 divide by input
        {
            return (1.0 / input);
        }
    }
}
