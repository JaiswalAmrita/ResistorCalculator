using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistorColCodeCalculator;
using ResistorColCodeCalculator.Controllers;
using ResColCodeCalculator;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace ResistorColCodeCalculator.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void NoBandvaluesPassed()
        {
            Exception exceptionResult = null;

            try
            {    //Initialize
                IOhmValueCalculator ohmValueCalculator = new ResColCodeCalculation();

                // Pass the null for all four bands
                ohmValueCalculator.CalculateOhmValue(null, null, null, null);
            }
            catch (Exception exception)
            {
                exceptionResult = exception;
            }

            // Check the result
            Assert.IsNotNull(exceptionResult);
            Assert.IsInstanceOfType(exceptionResult, typeof(ArgumentException));
        }


        [TestMethod]
        public void AllBandsValuesPassed()
        {
            //Initialize
            IOhmValueCalculator ohmValueCalculator = new ResColCodeCalculation();

            //pass the values for all bands
            ColCodeOutput result = ohmValueCalculator.CalculateOhmValue("red", "green", "pink", "silver");

            //result
            Assert.AreEqual("0.0225 Ω", result.MinOhms);
            Assert.AreEqual("0.0275 Ω", result.MaxOhms);
            Assert.AreEqual("0.025 Ω", result.Ohms);
            Assert.AreEqual("± 10% ", result.tolerValue);
        }

    }
}
