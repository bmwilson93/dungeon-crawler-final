// a dictionary of the possible items

using DungeonCrawler.Lib.Inventory;

public class ItemDB {
    // Dictionary<int, ItemDB> itemDB = new Dictionary<int, ItemDB>(); // REQUIREMENT #15 use oftwo of the built-in generic collection types

    public Dictionary<int, IItem> itemDB = new Dictionary<int, IItem>() 
    {
        {1, new Item(PossibleStat.Health, 50, "Small")},
        {2, new Item(PossibleStat.Health, 75, "Medium")},
        {3, new Item(PossibleStat.Health, 100, "Large")},
        {4, new Item(PossibleStat.Strength, 5, "Small")},
        {5, new Item(PossibleStat.Strength, 10, "Medium")},
        {6, new Item(PossibleStat.Strength, 15, "Large")},
        {7, new Item(PossibleStat.Defense, 5, "Small")},
        {8, new Item(PossibleStat.Defense, 10, "Medium")},
        {9, new Item(PossibleStat.Defense, 15, "Large")},
        {10, new Item(PossibleStat.Speed, 5, "Small")},
        {11, new Item(PossibleStat.Speed, 10, "Medium")},
        {12, new Item(PossibleStat.Speed, 15, "Large")},
    };
}