using C4.Utilities;
using NUnit.Framework;
using System;

namespace C4.Tests_Unit.Utilities
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
        public void Truncate_ReturnAStringOfLengthTen_IfStringToTruncateIsGreaterThanTen()
        {
            const int expected = 10;
            string result = _sut.Truncate("A name with more than ten chars");

            Assert.AreEqual(expected, result.Length);
        }

        [Test]
        public void Truncate_ReturnTheCorrectStringValue_IfStringToTruncateLengthIsGreaterThanTen()
        {
            const string expected = "A name wit";
            string actual = _sut.Truncate("A name with more than ten chars");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Truncate_ReturnAStringOfLengthTen_IfStringToTruncateIsOfLengthTen()
        {
            const int expected = 10;
            string result = _sut.Truncate("test chars");

            Assert.AreEqual(expected, result.Length);
        }

        [Test]
        public void Truncate_LeaveTheStringToTruncateIntact_IfStringToTruncateLengthIsLessThanTen()
        {
            const int expected = 4;
            string result = _sut.Truncate("test");

            Assert.AreEqual(expected, result.Length);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
