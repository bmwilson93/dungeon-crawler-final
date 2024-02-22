// Holds a list of the items in the inventory
// also can print a list of the inventory contents
// maybe even holds code to interact with the inventory

// Adding to inventory ==
// spawner will choose from the itemDB,
// the item in the db will be used to create a new item
// item = new Item(db.stat, db.potionStrength)
// list.add(item)

using System.Collections.Generic;
using DungeonCrawler.Lib.Characters;

namespace DungeonCrawler.Lib.Inventory;

public class NoInputException : Exception {

}

public struct Inventory { // REQUIREMENT #4 a struct definition  

    private ICharacter _player;
    private List<IItem> inventoryList = new List<IItem>(); // REQUIREMENT #15 use of built-in collection type

    public Inventory (ICharacter player) {
        _player = player;
    }

    // Print a list of the items in the inventory, give player option to use items
    public void OpenInventory() {
        bool exit = false;

        while (!exit) {
            Console.WriteLine();
            Console.WriteLine("Your inventory...");
            for (int i = 0; i < inventoryList.Count; i++) {
                Console.WriteLine($"{i}: {inventoryList[i].ItemName}");
            }
            Console.WriteLine("Enter the number of the item to use it, or enter \"e\" to exit the inventory.");

            // get the input
            try {
            string? input = Console.ReadLine();
                if (input == "e") {
                    exit = true;
                } else {
                    if (input is null) throw new NoInputException(); // REQUIREMENT #9 Throwing and handling an exception
                    int intInput = Int32.Parse(input);
                    inventoryList[intInput].UseItem(_player);
                    inventoryList.RemoveAt(intInput);
                }
            } catch (NoInputException){
                Console.WriteLine("Please make a selection");
            } catch (IndexOutOfRangeException) {
                Console.WriteLine("Not a valid selection");
            } catch {
                Console.WriteLine("Please try again");
            }
        }
    }

    public void addToInventory(IItem item) {
        inventoryList.Add(item);
    }
}