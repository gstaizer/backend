using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveExtraBlanksLibrary;

namespace RemoveExtraBlanksTests
{
    [TestClass]
    public class StringProcessorTests
    {
        [TestMethod]
        public void TestRemoveExtraBlanks()
        {
            StringProcessor stringProcessor = new StringProcessor();
            Assert.AreEqual("", stringProcessor.RemoveExtraBlanks("  "));
            Assert.AreEqual("hndk", stringProcessor.RemoveExtraBlanks(" hndk\t "));
            Assert.AreEqual("аоытвк", stringProcessor.RemoveExtraBlanks(" аоытвк \t"));
            Assert.AreEqual("оанаы оышыв", stringProcessor.RemoveExtraBlanks("оанаы оышыв"));
            Assert.AreEqual("оанаы оышыв", stringProcessor.RemoveExtraBlanks("оанаы  оышыв"));
            Assert.AreEqual("аонк\tjgh", stringProcessor.RemoveExtraBlanks("аонк\t  jgh "));
        }
    }
}
