using Microsoft.VisualStudio.TestTools.UnitTesting;
using negyszogCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszogCLI.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void ParalelogrammaETrueTest()
        {
            Negyszog negyszog = new Negyszog(1, 3, 1, 3);
            Assert.IsTrue(Program.ParalelogrammaE(negyszog));
        }

        [TestMethod()]
        public void SzerkeszthetokTrueTest()
        {
            Negyszog negyszog = new Negyszog(1, 1, 1, 1);
            Assert.IsTrue(negyszog.SzerkeszthetoE());
        }

        [TestMethod()]
        public void SzerkeszthetokFalseTest()
        {
            Negyszog negyszog = new Negyszog(1, 4, 5, 9);
            Assert.IsFalse(negyszog.SzerkeszthetoE());
        }

        [TestMethod()]
        public void RombuszETrueTest()
        {
            Negyszog negyszog = new Negyszog(3, 3, 3, 3);
            Assert.IsTrue(Program.RombuszE(negyszog));
        }

        [TestMethod]
        public void RombuszEFalseTest()
        {
            Negyszog negyszog = new Negyszog(3, 3, 3, 4);
            Assert.IsFalse(Program.RombuszE(negyszog));
        }
    }
}