using C4.Utilities;
using NUnit.Framework;
using System;

namespace C4.Tests_Unit.Utilities
{
    [TestFixture]
    public class NameFormatter_Should
    {
        private NameFormatter _sut;

        [SetUp]
        public void Init()
        {
            _sut = new NameFormatter();
        }

        [Test]
        public void FormatName_ReturnAStringValueOfUnknown_IfNameToFormatIsEmpty()
        {
            const string expected = "Unknown";
            string actual = _sut.FormatName(string.Empty);
            
            Assert.AreEqual(actual, expected);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FormatName_ThrowAnArgumentNullException_IfNameToFormatIsNull()
        {
            _sut.FormatName(null);
        }

        [Test]
        public void FormatName_ReturnAStringOfLengthTen_IfNameToFormatIsGreaterThanTen()
        {
            const int expected = 10;
            string result = _sut.FormatName("A name with more than ten chars");

            Assert.AreEqual(expected, result.Length);
        }

        [Test]
        public void FormatName_ReturnTheCorrectStringValue_IfNameToFormatLengthIsGreaterThanTen()
        {
            const string expected = "A name wit";
            string actual = _sut.FormatName("A name with more than ten chars");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FormatName_ReturnAStringOfLengthTen_IfNameToFormatIsOfLengthTen()
        {
            const int expected = 10;
            string result = _sut.FormatName("test chars");

            Assert.AreEqual(expected, result.Length);
        }

        [Test]
        public void FormatName_LeaveTheNameToFormatUntouched_IfNameToFormatLengthIsLessThanTen()
        {
            const int expected = 4;
            string result = _sut.FormatName("test");

            Assert.AreEqual(expected, result.Length);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }

    }
}
