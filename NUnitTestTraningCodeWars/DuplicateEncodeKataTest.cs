using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TraningCodeWars.Licao;

namespace TraningCodeWars.Test
{
    [TestFixture]
    public class DuplicateEncodeKataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", DuplicateEncodeKata.DuplicateEncode2("din"));
            Assert.AreEqual("()()()", DuplicateEncodeKata.DuplicateEncode2("recede"));
            Assert.AreEqual(")())())", DuplicateEncodeKata.DuplicateEncode2("Success"), "should ignore case");
            Assert.AreEqual("))((", DuplicateEncodeKata.DuplicateEncode2("(( @"));
        }
    }
}
