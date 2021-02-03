using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TraningCodeWars.Licao;

namespace TraningCodeWars.Test
{
    [TestFixture]
    public class Rot13Test
    {
        [Test, Description("test")]
        public void testTest()
        {
            Assert.AreEqual("grfg", Rot13.Transform("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Rot13.Transform("test")));
        }

        [Test, Description("Test")]
        public void TestTest()
        {
            Assert.AreEqual("Grfg", Rot13.Transform("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Rot13.Transform("Test")));
        }

        [Test, Description("Hello@")]
        public void Hello()
        {
            Assert.AreEqual("Uryyb@", Rot13.Transform("Hello@"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Rot13.Transform("Test")));
        }
    }
}
