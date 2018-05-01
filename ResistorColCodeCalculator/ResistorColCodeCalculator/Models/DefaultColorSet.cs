using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistorColCodeCalculator.Models
{
    public class DefaultColorSet
    {
        //to setup the values in the dropdown list for bandA and bandB 
        public Dictionary<string, string> ohmValuesList;
        //to setup the values in the dropdown list for bandc or Multiplier
        public Dictionary<string, string> MultiplierValuesList;
        //to setup the values in the dropdown list for bandD or Tolerance
        public Dictionary<string, string> ToleranceValueList;
        
        public DefaultColorSet()
        {
            //Setting up the values in the dropdown list for bandA and bandB 
            ohmValuesList = new Dictionary<string, string> {
                    {"black", "0 Black"},
                    {"brown", "1 Brown"},
                    {"red", "2 Red"},
                    {"orange", "3 Orange"},
                    {"yellow", "4 Yellow"},
                    {"green", "5 Green"},
                    {"blue", "6 Blue"},
                    {"violet", "7 Violet"},
                    {"gray", "8 Gray"},
                    {"white", "9 White"}
                };

            //Setting up the values in the dropdown list for bandc or Multiplier
            MultiplierValuesList = new Dictionary<string, string> {
                    {"pink", "÷1000 Pink"},
                    {"silver", "÷100 Silver"},
                    {"gold", "÷10 Gold"},
                    {"black", "x1 Black"},
                    {"brown", "x10 Brown"},
                    {"red", "x100 Red"},
                    {"orange", "x1k Orange"},
                    {"yellow", "x10k Yellow"},
                    {"green", "x100k Green"},
                    {"blue", "x1M Blue"},
                    {"violet",  "x10M Violet"},
                    {"gray",  "x100M Gray"},
                    {"white", "1G White"}
            };

            //Setting up the values in the dropdown list for bandD or Tolerance
            ToleranceValueList = new Dictionary<string, string> {
                    {"silver",  "± 10% Silver"},
                    {"gold",  "± 5% Gold"},                   
                    {"yellow", "± 4% Yellow"},
                    {"red", "± 2% Red"},
                    {"brown", "± 1% Brown"},
                    {"green", "± 0.5% Green"},
                    {"blue",  "± 0.25% Blue"},
                    {"violet", "± 0.1% Violet"},
                    {"gray", "± 0.05% Gray"}
            };
        }
    }
}