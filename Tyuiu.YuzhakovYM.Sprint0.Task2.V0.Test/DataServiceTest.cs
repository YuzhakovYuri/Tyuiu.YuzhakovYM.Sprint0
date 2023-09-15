using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.YuzhakovYM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Юрий";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Юрий", res);
        }
    }
}
