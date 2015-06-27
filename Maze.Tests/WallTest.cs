using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeLib;

namespace MazeLib.Tests
{
    [TestClass]
    public class WallTest
    {
        [TestMethod]
        public void CannotEnterAWall()
        {
            var room1 = new Room(1);
            var room2 = new Room(2);
            var player = new Player(room1, room2);
            var wall = new Wall();

            try
            {
                wall.Enter(player);
                throw new Exception("TEST FAILED");
            }
            catch (Exception e)
            {
                Assert.AreEqual("You just ran into a wall. Have you been drinking?", e.Message);
            }
        }

    }
}
