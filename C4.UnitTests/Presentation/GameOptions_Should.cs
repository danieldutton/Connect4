using C4.Presentation;
using C4.Utilities.Interfaces;
using Moq;
using NUnit.Framework;
using System;

namespace C4.Tests_Unit.Presentation
{
    [TestFixture]
    public class GameOptions_Should
    {
        [Test]
        public void FormatNameCalledTwice()
        {
            var fakeNameFormatter = new Mock<INameFormatter>();
            var sut = new ConfirmPlayers(fakeNameFormatter.Object);

            sut.ConfirmPlayers_Click(this, new EventArgs());
        }

        [Test]
        public void PLayersConfirmedEventFired()
        {
            var fakeNameFormatter = new Mock<INameFormatter>();
            var sut = new ConfirmPlayers(fakeNameFormatter.Object);

            sut.ConfirmPlayers_Click(this, new EventArgs());
        }
    }
}
