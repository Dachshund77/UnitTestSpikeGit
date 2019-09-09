using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        

        [TestMethod()]
        public void ReadASCIIFileTestPass()
        {
            Program program = new Program();
            Assert.IsTrue(program.ReadASCIIFile(new Uri(@"..\Ressources\CorrectFile.txt")));
        }

        [TestMethod()]
        public void ReadASCIIFileTestEmptyFile()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReadASCIIFileTestDoesNotExist()
        {

            Assert.Fail();
        }

        /// <summary>
        /// letsd think about this later
        /// </summary>
        [TestMethod()]
        public void ReadASCIIFileTestFormattingError1()
        {
            Assert.Fail();
        }

        /// <summary>
        /// Each usecase must be on EITHER a new line or punctuation. 
        /// </summary>
        [TestMethod()]
        public void ReadASCIIFileTestFormattingError2()
        {
            Assert.Fail();
        }
    }
}