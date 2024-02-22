using NUnit.Framework;
using DungeonCrawler.Lib.Environment;

namespace DungeonCrawler.Tests;

public class RoomTests
{
    Room testRoom1 = new Room(1);
    Room testRoom2 = new Room(2);
    Room testRoom3 = new Room(3);

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // These randomly generated descriptions will be hard to test when fully implemented
        // A simple message is used to test for now
        if (testRoom1.RoomContents == Contents.Enemy) {
            Assert.AreEqual(testRoom1.Description, "The room contains: Enemy");
        }
        if (testRoom1.RoomContents == Contents.Item) {
            Assert.AreEqual(testRoom1.Description, "The room contains: Item");
        }
        if (testRoom1.RoomContents == Contents.Nothing) {
            Assert.AreEqual(testRoom1.Description, "The room contains: Nothing");
        }
    }
}