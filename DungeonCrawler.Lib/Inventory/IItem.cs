using DungeonCrawler.Lib.Characters;

namespace DungeonCrawler.Lib.Inventory;
public interface IItem { // REQUIREMENT #14 a second Interface
    public PossibleStat AffectedStat {get; set;}

    public int PotionStrength {get;}

    public string ItemName {get;}

    public void UseItem (ICharacter player);
}