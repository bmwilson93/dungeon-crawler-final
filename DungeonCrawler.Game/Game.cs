using System;
using DungeonCrawler.Lib.Characters;
using DungeonCrawler.Lib.Environment;
using DungeonCrawler.Lib.Inventory;

public class Game {
    public bool gameOver = false;

    private ICharacter? _player;
    private Dungeon? dungeon;
    private Inventory inventory;

    public void StartNewGame () {
        // Describe the room
        // Get the description from CurrentRoom in Dungeon instance

        // Interact with room content
        // If there is an item, then add the item to the player inventory
        // If there is an enemy, start a battle instance

        // Present player option to choose next room
        // IE; "There is an exit to the right, and an exit to the left. Which one should you take?"

        // Repeat

        initalize();

        while (!gameOver) {

            if (dungeon.CurrentRoomNumber >= dungeon.TotalRooms) {
                break;
            }

            //string des = Dungeon.CurrentRoom;
            Console.WriteLine(dungeon.CurrentRoom.Description);
            Console.ReadKey();
            if (dungeon.CurrentRoom.RoomContents == Contents.Enemy) {
                Battle battle = new Battle(_player, new Enemy());
                if (battle.StartBattle()) { // if lose the battle
                    gameOver = true;
                }
                Console.WriteLine("testing");
            }
            else if (dungeon.CurrentRoom.RoomContents == Contents.Item) {
                // give the player an item
            }
            else { // room was empty

            }

            // Let player continue to next room
            // TODO let the player open and use the inventory here
            Console.WriteLine("Press any key to conintue to the next room");
            Console.ReadKey();
            dungeon.GetNewRoom();
        }
    }

    private string playerName = "";

    private void initalize() {
        Console.WriteLine("Welcome to Dungeon Crawler.");
        Console.WriteLine("Please, select your character.");
        characterSelect();
        Console.WriteLine("Please, select the dungeon.");
        dungeonSelect();
        inventory = new Inventory(_player);
    }

    private void characterSelect() {
        Console.WriteLine("1 - Fighter");
        Console.WriteLine("2 - Rouge");
        Console.WriteLine("3 - Mage");

        _player = new Player(100, 25, 10, 150000000);
        
    }

    private void dungeonSelect() {
        Console.WriteLine("1 - Cave");
        Console.WriteLine("2 - Ruins");
        Console.WriteLine("3 - Fort");

        dungeon = new Dungeon(1);
    }
}