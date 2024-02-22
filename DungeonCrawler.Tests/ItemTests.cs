using NUnit.Framework;
using DungeonCrawler.Lib.Inventory;
using DungeonCrawler.Lib.Characters;

namespace DungeonCrawler.Tests;


public class ItemTests
{

    IItem item1 = new Item(PossibleStat.Health, 50, "Small");
    IItem item2 = new Item(PossibleStat.Strength, 10, "Medium");
    IItem item3 = new Item(PossibleStat.Speed, 15, "Large");

    ICharacter testPlayer = new Player(100, 25, 10, 10);

    ItemDB db = new ItemDB();

    IItem item4;

    [SetUp]
    public void Setup()
    {
        item4 = db.itemDB[9]; // large potion of defense
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(item1.PotionStrength, 50);
        Assert.AreEqual(item1.ItemName, "Small Potion of Health");

        Assert.AreEqual(item2.PotionStrength, 10);
        Assert.AreEqual(item2.ItemName, "Medium Potion of Strength");

        Assert.AreEqual(item3.PotionStrength, 15);
        Assert.AreEqual(item3.ItemName, "Large Potion of Speed");

        Assert.AreEqual(testPlayer.Health, 100);
        item1.UseItem(testPlayer);
        Assert.AreEqual(testPlayer.Health, 150);

        Assert.AreEqual(testPlayer.Strength, 25);
        item2.UseItem(testPlayer);
        Assert.AreEqual(testPlayer.Strength, 35);

        Assert.AreEqual(testPlayer.Speed, 10);
        item3.UseItem(testPlayer);
        Assert.AreEqual(testPlayer.Speed, 25);

        Assert.AreEqual(item4.ItemName, "Large Potion of Defense");
        Assert.AreEqual(testPlayer.Defense, 10);
        item4.UseItem(testPlayer);
        Assert.AreEqual(testPlayer.Defense, 25);

    }
}