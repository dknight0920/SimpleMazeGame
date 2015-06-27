using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeLib;

namespace MazeLib.Tests
{
    [TestClass]
    public class DoorTest
    {
        [TestMethod]
        public void DoorIsOpenByDefault()
        {
            var room1 = new Room(1);
            var room2 = new Room(2);
            var door = new Door(room1, room2);

            Assert.IsTrue(door.isOpen());
        }

        [TestMethod]
        public void DoorCanBeClosedAndOpened()
        {
            var room1 = new Room(1);
            var room2 = new Room(2);
            var door = new Door(room1, room2);

            Assert.IsTrue(door.isOpen());

            door.CloseDoor();

            Assert.IsFalse(door.isOpen());

            door.OpenDoor();

            Assert.IsTrue(door.isOpen());
        }

        [TestMethod]
        public void PlayerCanEnterDoor()
        {
            var room1 = new Room(1);
            var room2 = new Room(2);
            var door = new Door(room1, room2);
            var player = new Player(room1, room2);

            Assert.AreEqual(room2, door.Enter(player));
        }
    }
}
