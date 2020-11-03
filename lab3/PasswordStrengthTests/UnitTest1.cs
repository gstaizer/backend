using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrengthLibrary;

namespace PasswordStrengthTests
{
    [TestClass]
    public class PasswordStrengthTests
    {
        private PasswordStrength passwordStrength;

        public PasswordStrengthTests()
        {
            this.passwordStrength = new PasswordStrength();
        }

        [TestMethod]
        public void TestGetSafetyByLength()
        {
            Assert.AreEqual(0, passwordStrength.GetSafetyByLength(""));
            Assert.AreEqual(4, passwordStrength.GetSafetyByLength("c"));
        }

        [TestMethod]
        public void TestGetSafetyByDigitsCount()
        {
            Assert.AreEqual(0, passwordStrength.GetSafetyByDigitsCount("c"));
            Assert.AreEqual(1, passwordStrength.GetSafetyByDigitsCount("3"));
            Assert.AreEqual(2, passwordStrength.GetSafetyByDigitsCount("77"));
        }

        [TestMethod]
        public void TestGetSafetyByUpperCaseChars()
        {
            Assert.AreEqual(0, passwordStrength.GetSafetyByUpperCaseChars("c"));
            Assert.AreEqual(0, passwordStrength.GetSafetyByUpperCaseChars("C"));
            Assert.AreEqual(2, passwordStrength.GetSafetyByUpperCaseChars("cC"));
        }

        [TestMethod]
        public void TestGetSafetyByLowerCaseChars()
        {
            Assert.AreEqual(0, passwordStrength.GetSafetyByLowerCaseChars("f"));
            Assert.AreEqual(0, passwordStrength.GetSafetyByLowerCaseChars("F"));
            Assert.AreEqual(2, passwordStrength.GetSafetyByLowerCaseChars("fF"));
        }

        [TestMethod]
        public void TestGetSafetyByContainsOnlyLetters()
        {
            Assert.AreEqual(-1, passwordStrength.GetSafetyByContainsOnlyLetters("f"));
            Assert.AreEqual(-2, passwordStrength.GetSafetyByContainsOnlyLetters("fF"));
            Assert.AreEqual(0, passwordStrength.GetSafetyByContainsOnlyLetters("fF1"));
        }

        [TestMethod]
        public void TestGetSafetyByContainsOnlyDigits()
        {
            Assert.AreEqual(0, passwordStrength.GetSafetyByContainsOnlyDigits("c"));
            Assert.AreEqual(0, passwordStrength.GetSafetyByContainsOnlyDigits("c3"));
            Assert.AreEqual(-1, passwordStrength.GetSafetyByContainsOnlyDigits("3"));
            Assert.AreEqual(-2, passwordStrength.GetSafetyByContainsOnlyDigits("33"));
        }

        [TestMethod]
        public void TestGetSafetyByRepeateChars()
        {
            Assert.AreEqual(0, passwordStrength.GetSafetyByRepeateChars("c"));
            Assert.AreEqual(-2, passwordStrength.GetSafetyByRepeateChars("cc"));
            Assert.AreEqual(-3, passwordStrength.GetSafetyByRepeateChars("ccc"));
            Assert.AreEqual(-2, passwordStrength.GetSafetyByRepeateChars("ccd"));
            Assert.AreEqual(-4, passwordStrength.GetSafetyByRepeateChars("ccdd"));
        }

        [TestMethod]
        public void TestCalcSafety()
        {
            Assert.AreEqual(4, passwordStrength.CalcSafety("1"));
            Assert.AreEqual(3, passwordStrength.CalcSafety("c"));
            Assert.AreEqual(46, passwordStrength.CalcSafety("1234asdff"));
            Assert.AreEqual(70, passwordStrength.CalcSafety("732628jdshhsa@"));
        }
    }
}
