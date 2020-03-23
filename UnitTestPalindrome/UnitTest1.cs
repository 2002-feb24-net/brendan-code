using System;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeDetector.ConsoleApp;

namespace UnitTestPalindrome
{
    public class UnitTest1 
    {
        [Fact]
        private int Ispalindrome()
        {
            Assert(Ispalindrome(string1, or, string2);
            Assert(Ispalindrome("racecaR"());

        }
    }
    public class VSTests
    {
        [TestMethod]
        public void PalindromeDetectorCanUnderstandPalindrome()
        {
            bool expected = true;
            bool actual;
            actual = Program.IsPalindromeNonRecursive("racecaR");
            Assert.(expected, actual);
        }
        [TestMethod]
        public void PalindromeDetecotryCanUnderstandNonPalindrome()
        {
            bool notExpected = true;
            actual = Program.IsPalindromeNonRecursive("123abccba123");
            Assert.(notExpected, actual);
        }
    }

  }

   