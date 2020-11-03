using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckIdentifierLibrary;

namespace CheckIdentifierTests
{
    [TestClass]
    public class CheckIdentifierLibraryTests
    {
        [TestMethod]
        public void TestDetermineIdentifier()
        {
            CheckIdentifier checkIdentifier = new CheckIdentifier();

            Assert.IsFalse(checkIdentifier.IsIdentifier(""));
            Assert.IsTrue(checkIdentifier.IsEmpty());

            Assert.IsFalse(checkIdentifier.IsIdentifier("7"));
            Assert.IsFalse(checkIdentifier.IsEmpty());
            Assert.AreEqual(0, checkIdentifier.GetIncorrectIndex());

            Assert.IsFalse(checkIdentifier.IsIdentifier("4дверь"));
            Assert.AreEqual(0, checkIdentifier.GetIncorrectIndex());

            Assert.IsFalse(checkIdentifier.IsIdentifier("Ъ"));
            Assert.AreEqual(0, checkIdentifier.GetIncorrectIndex());

            Assert.IsFalse(checkIdentifier.IsIdentifier("дверь4"));
            Assert.AreEqual(1, checkIdentifier.GetIncorrectIndex());

            Assert.IsTrue(checkIdentifier.IsIdentifier("лифт"));
            Assert.IsTrue(checkIdentifier.IsIdentifier("лифт4"));
            Assert.IsTrue(checkIdentifier.IsIdentifier("Лифт"));
        }
    }
}