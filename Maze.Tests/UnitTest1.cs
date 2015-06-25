﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeLib;

namespace MazeLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLevelOneNavigation()
        {
            var factory = new LevelFactory();

            var maze = factory.MakeLevelOne();

            var player = new Player(maze.GetRoom(1), maze.GetRoom(7));

            Assert.AreEqual(1, player.GetCurrentRoom().GetRoomNumber());

            player.Move(Room.directions.north);

            Assert.AreEqual(2, player.GetCurrentRoom().GetRoomNumber());

            player.Move(Room.directions.south);

            Assert.AreEqual(1, player.GetCurrentRoom().GetRoomNumber());

            player.Move(Room.directions.north);
            player.Move(Room.directions.east);

            Assert.AreEqual(4, player.GetCurrentRoom().GetRoomNumber());

            player.Move(Room.directions.west);

            Assert.AreEqual(2, player.GetCurrentRoom().GetRoomNumber());

            player.Move(Room.directions.south);

            Assert.AreEqual(1, player.GetCurrentRoom().GetRoomNumber());

            player.Move(Room.directions.east);

            Assert.AreEqual(3, player.GetCurrentRoom().GetRoomNumber());

            player.Move(Room.directions.west);

            Assert.AreEqual(1, player.GetCurrentRoom().GetRoomNumber());
        }
    }
}