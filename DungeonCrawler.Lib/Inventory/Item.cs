// item takes in argument that determines what stat it will affect
// health, strength, etc...

using DungeonCrawler.Lib.Characters;

namespace DungeonCrawler.Lib.Inventory;

public class Item : IItem
{
    // TOTO Implement
    public PossibleStat AffectedStat { get; set; }

    public string ItemName {
        get {
            // TODO determine the name for the strength here
            return $"{PotionSize} Potion of {AffectedStat.ToString()}"; // or nameof(enum)
        }
    } 

    // TOTO Implement
    public int PotionStrength { get; private set; }

    public string PotionSize {get; set;}

    public Item (PossibleStat stat, int potionStrength, string potionSize) {
        PotionSize = potionSize;
        AffectedStat = stat;
        PotionStrength = potionStrength;
    }

    // TOTO Implement - Targets the player, and raises the stat of the AffectedStat
    public void UseItem(ICharacter player)
    {
        if (AffectedStat == PossibleStat.Health) {
            player.Health += PotionStrength;
        } else if (AffectedStat == PossibleStat.Strength) {
            player.Strength += PotionStrength;
        } else if (AffectedStat == PossibleStat.Defense) {
            player.Defense += PotionStrength;
        } else {
            player.Speed += PotionStrength;
        }
    }
}