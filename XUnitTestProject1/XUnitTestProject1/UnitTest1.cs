using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Replace_Test_Char()
        {
            string str = "1 2 3 4 5 6 7 8 9";

            string result = str.Replace(' ', ',');
            string expected = "1,2,3,4,5,6,7,8,9";

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Replace_Test_String()
        {
            string errString = "This docment uses 3 other docments to docment the docmentation";

            string result = errString.Replace("docment", "document");
            string expected = "This document uses 3 other documents to document the documentation";

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Replace_Test_ArgumentNullException()
        {
            string errString = "This docment uses 3 other docments to docment the docmentation";

            string correctString = errString.Replace("docment", null);
            string expected = "This  uses 3 other s to  the ation";
            Assert.DoesNotContain("docment", correctString);
            Assert.Equal(expected, correctString);
        }
        [Fact]
        public void Substring_Test_Int()
        {
            string value = "Good day";

            string result = value.Substring(2);
            string expected = "od day";

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Substring_Test_Int_int()
        {
            string value = "Good day";

            string result = value.Substring(0, value.Length - 2);
            string expected = "Good d";

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Substring_Test_Exception1()
        {
            string value = "Good day";

            Assert.Throws<ArgumentOutOfRangeException>(() => value.Substring(-2, value.Length - 2));
        }
        [Fact]
        public void Substring_Test_Exception2()
        {
            string value = "Good day";

            Assert.Throws<ArgumentOutOfRangeException>(() => value.Substring(121, value.Length - 2));
        }
        [Fact]
        public void Substring_Test_Exception3()
        {
            string value = "Good day";

            Assert.Throws<ArgumentOutOfRangeException>(() => value.Substring(0, -1));
        }
        [Fact]
        public void Substring_Test_Exception4()
        {
            string value = "Good day";

            Assert.Throws<ArgumentOutOfRangeException>(() => value.Substring(121, value.Length - 2));
        }
        [Fact]
        public void Split_Test_Char()
        {
            string words = "This is a list of words, with: a bit of punctuation" +
               "\tand a tab character.";

            string[] result = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });

            string[] expected = new string[] { "This", "is", "a", "list", "of", "words", "", "with", "", "a", "bit", "of", "punctuation", "and", "a", "tab", "character", "" };

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Split_Test_Char_Int()
        {
            string str = "Geeks, For Geeks";

            char[] spearator = { ',', ' ' };
            int count = 2;

            string[] result = str.Split(spearator, count);
            string[] expected = new string[] { "Geeks", " For Geeks" };

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Split_Test_Char_StringSplitOptions()
        {
            string str = "Geeks, For Geeks";
            char[] spearator = { ',', ' ' };

            string[] result = str.Split(spearator,
               StringSplitOptions.RemoveEmptyEntries);

            string[] expected = new string[] { "Geeks", "For", "Geeks" };

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Split_Test_String_StringSplitOptions()
        {
            string str = "Geeks, For Geeks";
            string[] spearator = { "s,", "For" };

            string[] result = str.Split(spearator,
               StringSplitOptions.RemoveEmptyEntries);
            string[] expected = new string[] { "Geek", " ", " Geeks" };

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Split_Test_Char_Int_StringSplitOptions()
        {
            string str = "Geeks, For Geeks";
            char[] spearator = { ',', ' ' };
            int count = 2;

            string[] result = str.Split(spearator,
                   count, StringSplitOptions.None);
            string[] expected = new string[] { "Geeks", " For Geeks" };

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Split_Test_String_Int_StringSplitOptions()
        {
            string str = "Geeks, For Geeks";

            string[] spearator = { "s, ", "For" };
            int count = 2;

            string[] result = str.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);
            string[] expected = new string[] { "Geek", " Geeks" };

            Assert.Equal(expected, result);
        }
    }
}
