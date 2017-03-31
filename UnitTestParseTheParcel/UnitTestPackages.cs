using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTheParcel;

namespace UnitTestParseTheParcel
{
    [TestClass]
    public class UnitTestPackages
    {
        [TestMethod]
        public void TestGetPackageName()
        {
            //Arrange
            IParceTheParcel testPackage;
           
            //Act
            testPackage = new ParseTheParcelPackage();
           
            //Asert
            Assert.AreEqual("Small Package", testPackage.GetPackageName(210, 280, 130, 20));
        }

        [TestMethod]
        public void TestGetPackageCost()
        {
            //Arrange
            IParceTheParcel testPackage;
            
            //Act
            testPackage = new ParseTheParcelPackage();
           
            //Asert
            Assert.AreEqual(5, testPackage.GetPackageCost(210, 280, 130, 20));
        }
    }
}
