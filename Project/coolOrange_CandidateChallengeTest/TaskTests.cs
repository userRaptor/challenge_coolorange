using System;

using Assignment02_OOP;
using coolOrange_CandidateChallenge;
using NUnit.Framework;

namespace coolOrange_CandidateChallengeTest
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void IsPalindrome_passing_empty_returns_true()
        {
            Assert.IsTrue(PalindromeChecker.IsPalindrome(""));
        }
    }
}
