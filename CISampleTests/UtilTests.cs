using Microsoft.VisualStudio.TestTools.UnitTesting;
using CISample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISample.Tests
{
    [TestClass()]
    public class UtilTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(2, Util.Add(1, 1));
        }
    }
}