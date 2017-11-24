using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory_Returing_Diff_Types;
using Factory_Returing_Diff_Types.Types;

namespace MSTests.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testing_If_You_Are_Getting_Not_Null_Type()
        {
            var objTV = ElectronicsFactory.Factory("TV");
            Assert.IsNotNull(objTV);

        }

        [TestMethod]
        public void Testing_If_You_Are_Getting_Correct_Type()
        {
            var objTV = ElectronicsFactory.Factory("TV");
            Assert.IsInstanceOfType(objTV, new TV().GetType());

        }

        [TestMethod]

        public void Testing_If_We_Can_Return_Concrete_types()
        {

            TV myTV = ElectronicsFactory.Factory("TV") as TV;
            myTV.Play();
            Assert.AreEqual(myTV.CircuirError, null);
        }

    }
}
