using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using candyshopProject;

namespace UnitTestСandyshopProject
{
    [TestClass]
    public class authenticationComponentTest
    {
        [TestMethod]
        public void ComputeHashTest()
        {
            //arrange
            string enteredPassword = "123qwerty";
            string expected = "e87b2fd7-fd00-2551-35e3-438f52effce3";
            //act
            authenticationComponent myAC = new authenticationComponent(new dbProvider());
            string actual = myAC.ComputeHash(enteredPassword).ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }    
}

  
