using ResColCodeCalculator;
using ResistorColCodeCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResistorColCodeCalculator.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                //Setting up the DropDown listbox on page load
                DefaultColorSet setInitialValue = new DefaultColorSet();

                //Return to view with value to set initial values in dropdown liast box
                return View(setInitialValue);
            }
            catch (Exception ex)
            {
                // Exception for error
                return Json(new { error = "Error while loading the Band Lists " + ex.Message });
            }
        }


       //Based on provided color code returning the Resistor value, Min and Max Resistance and Tolerance vlaue
        [HttpPost]
        public ActionResult getCaluclatedResistorValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            try
            {

                // Initialize the Object for ResColCodeCalculation
                IOhmValueCalculator resColCodeCalculation = new ResColCodeCalculation();

                // Calling the ColCodeOutput methods for calculation the Resistor value, Min and Max Resistance and Tolerance vlaue 
                ColCodeOutput colCodeOutput = resColCodeCalculation.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
               
                /// Passing back the resulted values form CalculateOhmValue method
                return Json(new { minResistance = colCodeOutput.MinOhms, maxResistance = colCodeOutput.MaxOhms, resistorvalue = colCodeOutput.Ohms, toleranceValue = colCodeOutput.tolerValue });
            }
            catch (Exception ex)
            {
                // Error
                return Json(new { error = "Error while loading the Band Lists " + ex.Message });
            }
        }

    }

}