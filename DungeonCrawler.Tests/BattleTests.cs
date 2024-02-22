using NUnit.Framework;
using DungeonCrawler.Lib.Characters;

namespace DungeonCrawler.Tests;

public class BattleTests
{
    Enemy char1 = new Enemy();
    ICharacter char2 = new Enemy();

    Battle testBattle;

    [SetUp]
    public void Setup()
    {
        testBattle = new Battle(char1, char2);
    }

    [Test]
    public void Test1()
    {
        testBattle.StartBattle();
        Assert.Pass();
    }
}