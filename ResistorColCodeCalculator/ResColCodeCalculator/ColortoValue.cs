using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResColCodeCalculator
{
    public class ColortoValue
    {
        // band D values to convert from color code to numberic value
        public Dictionary<string, double> bandDtol;

        // band D values to convert from color code to numberic value
        public Dictionary<string, string> toleranceValue;

        //Constructor of ColortoValue class 
        public ColortoValue()
        {

            //band D 
            bandDtol = new Dictionary<string, double> {
                    {"silver", 0.10},
                    {"gold", 0.05},
                    {"brown",  0.01},
                    {"red", 0.02},
                    {"yellow", 0.05},
                    {"green", 0.005},
                    {"blue", 0.0025},
                    {"violet", 0.001},
                    {"gray", 0.0005}         
            };

            //ToleranceValue 
            toleranceValue = new Dictionary<string, string> {
                    {"silver",  "± 10% "},
                    {"gold",  "± 5% "},                   
                    {"yellow", "± 4% "},
                    {"red", "± 2% "},
                    {"brown", "± 1% "},
                    {"green", "± 0.5% "},
                    {"blue",  "± 0.25% "},
                    {"violet", "± 0.1% "},
                    {"gray", "± 0.05% "}
            };
        
        }

    }
}