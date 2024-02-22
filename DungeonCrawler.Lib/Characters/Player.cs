namespace DungeonCrawler.Lib.Characters;

public class Player: Character { // REQUIREMENT #6 Inheritance
    public string Name {get; set;} = "";

    public Player(int hp = 100, int str = 10, int def = 10, int spd = 10) {
        Health = hp;
        Strength = str;
        Defense = def;
        Speed = spd;
    }

    public override TurnActions GetInput() // REQUIREMENT #7 - polymorphism 
    {
        bool validInput = false;
        TurnActions choice = TurnActions.Attack;
        
        while (!validInput){

            // Ask the player for their input & return the choice
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 Attack");
            Console.WriteLine("2 Defend");
            Console.WriteLine("3 Run");
            var input = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            // determine the choice
            if (input.Key == ConsoleKey.D1) {
                choice = TurnActions.Attack;
                validInput = true;
            }
            else if (input.Key == ConsoleKey.D2) {
                choice = TurnActions.Defend;
                validInput = true;
            }
            else if (input.Key == ConsoleKey.D3) {
                choice = TurnActions.Run;
                validInput = true;
            }
            else Console.WriteLine("That's not an option.");
        }
        return choice;
    }

}