using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp16
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void countOfAllQuestionary_chechingCount()
        {
            int expected = 15;
            string[] linesFile = Program.readingFile();

            int c = Program.countAll(linesFile);

            Assert.AreEqual(expected, c);

        }

        [TestMethod]
        public void countOfEveryCourse_chechingCount()
        {
            int[] expected = new int[3] {3, 10, 2 };
            string[] linesFile = Program.readingFile();

            int[] c = Program.countOfCourses(linesFile);

            Assert.AreEqual(expected[0], c[0]);
            Assert.AreEqual(expected[1], c[1]);
            Assert.AreEqual(expected[2], c[2]);
        }

        [TestMethod]
        public void countOfDormitory_chechingCount()
        {
            int expected = 12;
            string[] linesFile = Program.readingFile();

            int c = Program.countOfDormitory(linesFile);

            Assert.AreEqual(expected, c);
        }
    }
}
