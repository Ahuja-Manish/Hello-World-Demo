using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using Moq;
namespace TestProject
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Sum()
        {
            int a = 1, b = 2;
            int c = 3;
            Assert.Equals(c, (a + b));

        }
    }
}
