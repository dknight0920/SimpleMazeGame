using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeLib;

namespace MazeLib.Tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void PlayerHasFinished_When_CurrentRoomEqualsFinishRoom()
        {
            var room1 = new Room(1);
            var room2 = new Room(2);
            var player1 = new Player(room1, room2);

            Assert.IsFalse(player1.hasFinished());

            var player2 = new Player(room1, room1);

            Assert.IsTrue(player2.hasFinished());
        }
    }
}
