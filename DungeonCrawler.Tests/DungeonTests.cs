using NUnit.Framework;
using DungeonCrawler.Lib.Environment;

namespace DungeonCrawler.Tests;

public class DungeonTests
{
    Dungeon testDungeon1 = new Dungeon(difficulty: 1);
    Dungeon testDungeon2 = new Dungeon(difficulty: 2);
    Dungeon testDungeon3 = new Dungeon(difficulty: 3);

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Test the Dungeons for total rooms
        Assert.AreEqual(testDungeon1.Difficulty, 1);
        Assert.AreEqual(testDungeon1.TotalRooms, 10);
        Assert.AreEqual(testDungeon1.CurrentRoomNumber, 1);
        
        Assert.AreEqual(testDungeon2.Difficulty, 2);
        Assert.AreEqual(testDungeon2.TotalRooms, 15);
        Assert.AreEqual(testDungeon2.CurrentRoomNumber, 1);

        Assert.AreEqual(testDungeon3.Difficulty, 3);
        Assert.AreEqual(testDungeon3.TotalRooms, 20);
        Assert.AreEqual(testDungeon3.CurrentRoomNumber, 1);
        
        // Test adding a new room
        testDungeon1.GetNewRoom();
        Room? newRoom = testDungeon1.CurrentRoom;
        Assert.AreEqual(newRoom, testDungeon1.CurrentRoom);
        Assert.AreEqual(testDungeon1.CurrentRoomNumber, 2);

        
    }
}