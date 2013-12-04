using C4.Utilities;
using NUnit.Framework;
using System;

namespace C4._UnitTests.Utilities
{
    [TestFixture]
    public class StringTruncator_Should
    {
        private StringTruncator _sut;

        [SetUp]
        public void Init()
        {
            _sut = new StringTruncator();
        }

        [Test]
        public void Truncate_ReturnAStringValueOfUnknown_IfStringToTruncateIsEmpty()
        {
            const string expected = "Unknown";
            string actual = _sut.Truncate(string.Empty);
            
            Assert.AreEqual(actual, expected);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Truncate_ThrowAnArgumentNullException_IfStringToTruncateIsNull()
        {
            _sut.Truncate(null);
        }

        [Test]
        public void Truncate_ReturnATrimmedStringOfLengthTen_IfInputStringIsLongerThanTenCharacters()
        {
            const int expected = 10;
            string actual = _sut.Truncate("A name with more than ten chars");

            Assert.AreEqual(expected, actual.Length);
        }

        [Test]
        public void Truncate_ReturnTheCorrectTrimmedStringValue_IfInputStringIsLongerThanTenCharacters()
        {
            const string expected = "A name wit";
            string actual = _sut.Truncate("A name with more than ten chars");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Truncate_ReturnAStringOfLengthTen_IfInputStringIsTenCharacters()
        {
            const int expected = 10;
            string actual = _sut.Truncate("test chars");

            Assert.AreEqual(expected, actual.Length);
        }

        [Test]
        public void Truncate_ReturnTheCorrectStringValue_IfInputStringIsTenCharacters()
        {
            const string expected = "test chars";
            string actual = _sut.Truncate("test chars");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Truncate_LeaveTheStringToTruncateIntact_IfInputStringIsLessThanTenCharacters()
        {
            const int expected = 4;
            string actual = _sut.Truncate("test");

            Assert.AreEqual(expected, actual.Length);
        }

        [Test]
        public void Truncate_ReturnTheCorrectStringValue_IfInputStringIsLessThanTenCharacters()
        {
            const string expected = "test";
            string actual = _sut.Truncate("test");

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
