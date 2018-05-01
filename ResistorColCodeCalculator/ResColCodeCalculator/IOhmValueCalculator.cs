using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResColCodeCalculator
{
   public interface IOhmValueCalculator
    {
        /// <summary>
        /// It is a interface to implement for the color band value
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
       ColCodeOutput CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }

   
}
