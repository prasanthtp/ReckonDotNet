using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Test1.Classes;

namespace Test1.Tests
{
    [TestClass]
    public class BossHogUnitTests
    {
        private ReadOnlyCollection<int> DefaultNumbers = new ReadOnlyCollection<int>(new List<int> { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19, 22, 23, 26, 28, 29 });
        private ReadOnlyCollection<int> DivOnlyBy3Numbers = new ReadOnlyCollection<int>(new List<int> { 3, 6, 9, 12, 18, 21, 24 });
        private ReadOnlyCollection<int> DivOnlyBy5Numbers = new ReadOnlyCollection<int>(new List<int> { 5, 10, 20, 25 });
        private ReadOnlyCollection<int> DivBy3And5Numbers = new ReadOnlyCollection<int>(new List<int> { 15, 30, 45, 60, 75, 90 });
         
        [TestMethod]
        public void BossHog_WhenDefault_ReturnsInputIntegerAsString()
        {
            foreach (var input in DefaultNumbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreEqual(input.ToString(), output);
            }
        }

        [TestMethod]
        public void BossHog_WhenDivisibleBy3_ReturnsBoss()
        {
            foreach (var input in DivOnlyBy3Numbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreEqual("Boss", output);
            }
        }

        [TestMethod]
        public void BossHog_WhenDivisibleBy5_ReturnsHog()
        {
            foreach (var input in DivOnlyBy5Numbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreEqual("Hog", output);
            }
        }

        [TestMethod]
        public void BossHog_WhenDivisibleBy3And5_ReturnsBossHog()
        {
            foreach (var input in DivBy3And5Numbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreEqual("BossHog", output);
            }
        }


        [TestMethod]
        public void BossHog_WhenDefault_Not_ReturnsBoss()
        {
            foreach (var input in DefaultNumbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreNotEqual("Boss", output);
            }
        }

        [TestMethod]
        public void BossHog_WhenDefault_Not_ReturnsHog()
        {
            foreach (var input in DefaultNumbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreNotEqual("Hog", output);
            }
        }

        [TestMethod]
        public void BossHog_WhenDefault_Not_ReturnsBossHog()
        {
            foreach (var input in DefaultNumbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreNotEqual("BossHog", output);
            }
        }

        [TestMethod]
        public void BossHog_WhenDivisibleOnlyBy3_NotReturnsBossHog()
        {
            foreach (var input in DivOnlyBy3Numbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreNotEqual("BossHog", output);
            }
        }


        [TestMethod]
        public void BossHog_WhenDivisibleOnlyBy5_NotReturnsBossHog()
        {
            foreach (var input in DivOnlyBy5Numbers)
            {
                string output = BossHog.PrintNumber(input);
                Assert.AreNotEqual("BossHog", output);
            }
        }
    }
}
