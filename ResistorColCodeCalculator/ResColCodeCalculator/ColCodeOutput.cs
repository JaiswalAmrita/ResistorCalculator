using System;

namespace ResColCodeCalculator
{
   
    /// This class will provide the Min and Max ohms output after calculating the color code value
    public class ColCodeOutput
    {
        //output ohms vlaue  
        public string Ohms { get; set; }

        //Tolerance vlaue  
        public string tolerValue { get; set; }
        
        //Minimum output ohms vlaue  
        public string MinOhms { get; set; }
        
        //Maximum output ohms vlaue  
        public string MaxOhms { get; set; }
    }
}
