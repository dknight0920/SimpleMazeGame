using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeLib;

namespace MazeLib.Tests
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void SetAndGetRoomNumber()
        {
            var room1 = new Room(1);
            Assert.AreEqual(1, room1.GetRoomNumber());

            var room2 = new Room(2);
            Assert.AreEqual(2, room2.GetRoomNumber());
        }

        [TestMethod]
        public void SetAndGetRoomSides()
        {
            var room1 = new Room(1);
            var room2 = new Room(2);

            room1.SetSide(Room.directions.north, new Wall());
            room1.SetSide(Room.directions.east, new Wall());
            room1.SetSide(Room.directions.south, new Door(room1, room2));
            room1.SetSide(Room.directions.west, new Wall());

            Assert.AreEqual(typeof(Wall), room1.GetSide(Room.directions.north).GetType());
            Assert.AreEqual(typeof(Wall), room1.GetSide(Room.directions.east).GetType());
            Assert.AreEqual(typeof(Door), room1.GetSide(Room.directions.south).GetType());
            Assert.AreEqual(typeof(Wall), room1.GetSide(Room.directions.west).GetType());

            room2.SetSide(Room.directions.north, new Door(room1, room2));
            room2.SetSide(Room.directions.east, new Door(room1, room2));
            room2.SetSide(Room.directions.south, new Wall());
            room2.SetSide(Room.directions.west, new Door(room1, room2));

            Assert.AreEqual(typeof(Door), room2.GetSide(Room.directions.north).GetType());
            Assert.AreEqual(typeof(Door), room2.GetSide(Room.directions.east).GetType());
            Assert.AreEqual(typeof(Wall), room2.GetSide(Room.directions.south).GetType());
            Assert.AreEqual(typeof(Door), room2.GetSide(Room.directions.west).GetType());
        }
    }
}
