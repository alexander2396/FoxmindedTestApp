using NUnit.Framework;
using FoxmindedTestApp;
using System.IO;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void AnalizeFileTest()
        {
            var result = Helper.AnalizeFile("C:\\Users\\Alexander\\source\\repos\\FoxmindedTestApp\\test.txt");

            Assert.IsTrue(result.MaxLineNumber == 2);
            Assert.IsTrue(result.MaxSum == 502.3);
            Assert.IsTrue(result.BrokenLines[0] == "234,dsfsd,23");
        }

        [Test]
        public void AnalizeFileTest_WrongPath()
        {
            Assert.Throws<FileNotFoundException>(delegate { Helper.AnalizeFile("C:\\path_not_exists.txt"); });
        }
    }
}