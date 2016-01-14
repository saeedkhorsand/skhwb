using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SKHWB.test
{
    [TestClass]
    public class xmlQueryReader
    {
        [TestMethod]
        public void readData()
        {
            var listOfQuerys = SKHWB.xmlTools.controller.xmlQueryController.getListOfQueryModels("c:\\queries.xml");
            Assert.AreEqual(listOfQuerys.Result, true);
        }
    }
}
