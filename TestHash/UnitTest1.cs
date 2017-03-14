using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing_Excercise;

namespace TestHash
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Hash_leepadg ()
        {
            var result = Program.Hash("leepadg");
            Assert.AreEqual(680131659347, result);
        }

    }
}
