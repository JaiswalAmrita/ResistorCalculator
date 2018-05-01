using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResColCodeCalculator
{
    public class ResColCodeCalculation : IOhmValueCalculator
    {
        /// <summary>
        /// It is a implemet of the interface from IOhmValueCalculator
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        public ColCodeOutput CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            //ColortoValue class initialization
            ColortoValue ohmcolortovalue = new ColortoValue();

            ColCodeOutputEnum colcodEnum = new ColCodeOutputEnum();

            //Passing value to ColortoValue class to find out the associate numeric values
            int ohmValue = Convert.ToInt32(string.Format("{0}{1}", (int)Enum.Parse(typeof(ColCodeOutputEnum.bandAbandB), bandAColor), (int)Enum.Parse(typeof(ColCodeOutputEnum.bandAbandB), bandBColor)));
            int multiValue = (int)Enum.Parse(typeof(ColCodeOutputEnum.bandCMulti), bandCColor);
            double toleranceValue = ohmcolortovalue.bandDtol[bandDColor];

            // finding out resistance values based on provided band C and band D values
            double ohmVal = (ohmValue * Math.Pow(10, multiValue));
            double resultMax = (ohmValue * Math.Pow(10, multiValue) * (1 + toleranceValue));
            double resultMin = (ohmValue * Math.Pow(10, multiValue) * (1 - toleranceValue));

            // Passing the out put resistance values to ColCodeOutput class for diplay
            ColCodeOutput colorCodeOutput = new ColCodeOutput();
            colorCodeOutput.tolerValue = ohmcolortovalue.toleranceValue[bandDColor];
            colorCodeOutput.Ohms = ConvertToResitanceString(ohmVal);
            colorCodeOutput.MinOhms = ConvertToResitanceString(resultMin);
            colorCodeOutput.MaxOhms = ConvertToResitanceString(resultMax);

            // return resistance value range.
            return colorCodeOutput;
        }


        //Convert the higher numeric value with Converted prefix values. <<< reference from msdn >>>>
        public static readonly List<string> Suffixes = new List<string>() { "", "k", "M", "G" };
        public string ConvertToResitanceString(double resistance)
        {
            int start = 0;
            while (resistance >= 1000)
            {
                resistance /= 1000;
                ++start;
            }
            return resistance.ToString() + " " + Suffixes[start] + "Ω";
        } 
    }

}
