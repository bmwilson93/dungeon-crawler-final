// Brian Wilson
// Final Project - Text Based Dungeon Crawler
// 3 31 22 

/* 
Required Elements
1 a class definition                                                (Dungeon.cs)
2 a second class definition                                         (Room.cs)
3 a third class definition                                          (Battle.cs)
4 a struct definition                                               (Inventory.cs)
5 an enumerated type                                                (TurnActions.cs)
6 inheritance                                                       (Player.cs)
7 polymorphism                                                      (Player.cs)
8 a second example of polymorphism                                  (Enemy.cs)
9 throwing an exception and properly catching it                    (Inventory.cs)
10 definition of your own generic datatype                          ()
11 properties                                                       (Dungeon.cs)
12 a static member function                                         (Program.cs)
13 an interface                                                     (ICharacter.cs)
14 a second interface                                               (IItem.cs)
15 use of at least two of the built-in generic collection types     (Inventory.cs & ItemDB.cs) - dictionary and list for items
*/

using System;
using DungeonCrawler.Lib.Characters;
using DungeonCrawler.Lib.Environment;

public class Program {

    public static void Main () {
        Game game = new Game();
        game.StartNewGame();
        GameOver();
    }

    public static void GameOver() { // REQUIREMENT 12 - Static member
        // display a game over screen
        Console.WriteLine("Game over");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
        Environment.Exit(0);
    }
    

}