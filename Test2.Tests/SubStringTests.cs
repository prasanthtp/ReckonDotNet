using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2.Classes;

namespace Test2.Tests
{
    [TestClass]
    public class SubStringTests
    {
        [TestMethod]
        public void SubString_WhenEmptyStringInput_ReturnsOne()
        {
            string textToSearch = string.Empty;
            string subtext = string.Empty;
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "1");
        }
 

        [TestMethod]
        public void SubString_WhenSubTextEmptyString_ReturnsNoOutput()
        {
            string textToSearch = "quick brown fox";
            string subtext = string.Empty;
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "<No Output>");
        }

        [TestMethod]
        public void SubString_WhenTextToSearchEmptyString_ReturnsNoOutput()
        {
            string textToSearch = string.Empty; 
            string subtext = "Fox";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "<No Output>");
        } 

        [TestMethod]
        public void SubString_WhenNULLInput_ReturnsNoOutput()
        {
            string textToSearch = null;
            string subtext = null;
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "1");
        }

        [TestMethod]
        public void SubString_WhenSubTextNULL_ReturnsNoOutput()
        {
            string textToSearch = "quick brown fox";
            string subtext = null;
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "<No Output>");
        }

        [TestMethod]
        public void SubString_WhenTextToSearchNULL_ReturnsNoOutput()
        {
            string textToSearch = null;
            string subtext = "Fox";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "<No Output>");
        }

        [TestMethod]
        public void SubString_WhenSubTextDifferentcasing_ReturnsOutput()
        {
            string textToSearch = "samantha fox fo x quick brown fox.";
            string subtext = "FoX";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "10, 31");
        }

        [TestMethod]
        public void SubString_WhenTextToSearchDifferentcasing_ReturnsOutput()
        {
            string textToSearch = "samantha Fox fo_X quick brown FOX.";
            string subtext = "fox";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "10, 31");
        }

        [TestMethod]
        public void SubString_Acceptance_Criteria1_Passed()
        {
            string textToSearch = "Peter told me (actually he slurrred) that peter the pickle piper piped a pitted pickle before he petered out. Phew!";
            string subtext = "Peter";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "1, 43, 98");
        }

        [TestMethod]
        public void SubString_Acceptance_Criteria2_Passed()
        {
            string textToSearch = "Peter told me (actually he slurrred) that peter the pickle piper piped a pitted pickle before he petered out. Phew!";
            string subtext = "peter";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "1, 43, 98");
        }

        [TestMethod]
        public void SubString_Acceptance_Criteria3_Passed()
        {
            string textToSearch = "Peter told me (actually he slurrred) that peter the pickle piper piped a pitted pickle before he petered out. Phew!";
            string subtext = "pick";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "53, 81");
        }


        [TestMethod]
        public void SubString_Acceptance_Criteria4_Passed()
        {
            string textToSearch = "Peter told me (actually he slurrred) that peter the pickle piper piped a pitted pickle before he petered out. Phew!";
            string subtext = "pi";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "53, 60, 66, 74, 81");
        }

        [TestMethod]
        public void SubString_Acceptance_Criteria5_Passed()
        {
            string textToSearch = "Peter told me (actually he slurrred) that peter the pickle piper piped a pitted pickle before he petered out. Phew!";
            string subtext = "z";
            Assert.AreEqual(SubString.Find(textToSearch, subtext), "<No Output>");
        }





    }
}
