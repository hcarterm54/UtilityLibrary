using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringLibrary.Test
{
    [TestClass]
    public class StringLibraryTests
    {
        #region StaartsWithUpperTests

        [TestMethod]
        public void StartsWithUpper_FirstCharacterUppercase_ReturnsTrue()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                    $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [TestMethod]
        public void StartsWithUpper_FirstCharacterLowercase_ReturnsFalse()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                "1234", ".", ";"};
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
                    $"Expected for '{word}': false; Actual: {result}");
            }
        }

        [TestMethod]
        public void StartsWithUpper_EmptyString_ReturnsFalse()
        {
            // Tests that we expect to return false.
            string word = String.Empty;

            bool result = StringLibrary.StartsWithUpper(word);
            Assert.IsFalse(result,
                $"Expected for '{word}': " +
                $"false; Actual: {result}");
        }

        [TestMethod]
        public void StartsWithUpper_Null_ReturnsFalse()
        {
            // Tests that we expect to return false.
            string[] words = { String.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result,
                    $"Expected for '<null>': " +
                    $"false; Actual: {result}");
            }
        }

        #endregion

        #region StartsWithLower tests

        [TestMethod]
        public void StartsWithLower_FirstCharacterUppercase_ReturnsFalse()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва",
                                "1234", ".", ", "};
            foreach (var word in words)
            {
                bool result = word.StartsWithLower();
                Assert.IsFalse(result,
                              $"Expected for '{word}': false; Actual: {result}");
            }
        }

        [TestMethod]
        public void StartsWithLower_FirstCharacterLowercase_ReturnsTrue()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство" };
            foreach (var word in words)
            {
                bool result = word.StartsWithLower();

                Assert.IsTrue(result,
                               $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [TestMethod]
        public void StartsWithLower_EmptyString_ReturnsFalse()
        {
            // Tests that we expect to return false.
            string word = String.Empty;

            bool result = StringLibrary.StartsWithLower(word);
            Assert.IsFalse(result,
                           $"Expected for '{word}': " +
                           $"false; Actual: {result}");
        }

        [TestMethod]
        public void StartsWithLower_Null_ReturnsFalse()
        {
            // Tests that we expect to return false.
            string[] words = { String.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithLower(word);
                Assert.IsFalse(result,
                               $"Expected for '<null>': " +
                               $"false; Actual: {result}");
            }

        }

        #endregion


        #region HasEmbeddedSpaces tests

        [TestMethod]
        public void HasEmbeddedSpaces_NoSpaces_ReturnsFalse()
        {
            string word = "alphabetsouprainsspainontheplain";

            bool result = word.HasEmbeddedSpaces();

            Assert.IsFalse(result,
                            $"Expected for '{word}': false; Actual: {result}");
        }

        [TestMethod]
        public void HasEmbeddedSpaces_LeadingSpaces_ReturnsFalse()
        {
            string word = "   alphabetsouprainsspainontheplain";

            bool result = word.HasEmbeddedSpaces();

            Assert.IsFalse(result,
                            $"Expected for '{word}': false; Actual: {result}");
        }

        [TestMethod]
        public void HasEmbeddedSpaces_TrailingSpaces_ReturnsFalse()
        {
            string word = "alphabetsouprainsspainontheplain   ";

            bool result = word.HasEmbeddedSpaces();

            Assert.IsFalse(result,
                            $"Expected for '{word}': false; Actual: {result}");
        }

        [TestMethod]
        public void HasEmbeddedSpaces_HasSpaces_ReturnsTrue()
        {
            string word = "alphabet soup rains spain on the plain";

            bool result = word.HasEmbeddedSpaces();

            Assert.IsTrue(result,
                            $"Expected for '{word}': true; Actual: {result}");
        }

        [TestMethod]
        public void TestHasEmbeddedSpaces()
        {
            string[] phrases = { "one car", "Name\u0009Description",
                                 "Line1\nLine2", "Line3\u000CLine8",
                                 "Line5\u000BLine6", "Line7\u000CLine8",
                                 "Line9\u0009Line10", "word1\u00A0word2"};

            foreach (var phrase in phrases)
            {
                bool result = phrase.HasEmbeddedSpaces();
                Assert.IsTrue(result,
                                $"Expected for '{phrase}': true; Actual: {result}");
            }
        }

        #endregion
    }
}
