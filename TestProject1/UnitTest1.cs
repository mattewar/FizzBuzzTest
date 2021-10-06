using ClassLibrary1;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestThreeFive()
        {
            var conditions = new List<ModPair>();
            conditions.Add(new ModPair() { Word = "Three", Number = 3 });
            conditions.Add(new ModPair() { Word = "Five", Number = 5 });
            var results = new Class1().Print(15, conditions);
            Assert.Contains("Five", results);
            Assert.Contains("Three", results);
        }

        [Test]
        public void MemoryLeakTestMaxValue()
        {
            var conditions = new List<ModPair>();
            conditions.Add(new ModPair() { Word = "Fizz", Number = 3 });
            conditions.Add(new ModPair() { Word = "Buzz", Number = 5 });
            for (int i = 0; i < int.MaxValue; i++)
            {
                new Class1().Print(i, conditions);
            }
            Assert.Pass();
        }

        [Test]
        public void PrintListMaxException()
        {
            var conditions = new List<ModPair>();
            conditions.Add(new ModPair() { Word = "Fizz", Number = 3 });
            conditions.Add(new ModPair() { Word = "Buzz", Number = 5 });
            try
            {
                new Class1().PrintList(int.MaxValue, conditions);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Invalid length for list printing, use the Print() method instead");
            }
        }

        [Test]
        public void NegativeTest()
        {
            var conditions = new List<ModPair>();
            conditions.Add(new ModPair() { Word = "Fizz", Number = 3 });
            conditions.Add(new ModPair() { Word = "Buzz", Number = 5 });
            try
            {
                new Class1().PrintList(int.MinValue, conditions);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Negative numbers are invalid");
            }
        }
    }
}
