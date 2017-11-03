using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * PORTFOLIO ACTIVITY 1.6
 * Supanat Kakanaporn
 * ID: 445682
 * Using this math libraries with the following methods
    Trigonometric
         Tan
         Sine
         Cosine
 */
namespace Trigonometric
{
    public class Trigonometric
    {
        //The angle is in degree, need to convert to radians is equal to the angle in degrees times pi constant divided by 180 degrees.
        public static double sin(double input)//Sine Function
        {
            return (System.Math.Sin(Math.PI * input / 180.0));
        }

        public static double cos(double input)//Cosine Function
        {
            return (System.Math.Cos(Math.PI * input / 180.0));
        }
        public static double tan(double input)//TangentFunction
        {
            return (System.Math.Tan(Math.PI * input / 180.0));
        }

    }
}
