// Runs the code for a player battle with an enemy
// Holds two characters, gets the turn actions from them
// then has them damage each other and determines a winner


using DungeonCrawler.Lib.Characters;

public class Battle { // REQUIREMENT # a third class definition
    public ICharacter Player {get; set;}
    public ICharacter Enemy {get; set;}

    private bool battleLost = false;

    public Battle(ICharacter player, ICharacter enemy) {
        Player = player;
        Enemy = enemy;
    }

    private bool battleOver = false;
    public bool StartBattle(){
        while (!battleOver) {

            // Ask for player input
            var playerInput = Player.GetInput();
            // Determine AI turn
            var enemyInput = Enemy.GetInput();

            if (playerInput == TurnActions.Run) {
                if (isPlayerFaster()) {
                    Console.WriteLine("You were able to evade the attacker, and escaped!");
                    battleOver = true;
                } else { // Player Couldn't get away, do enemies turn
                    if (enemyInput == TurnActions.Defend) {
                        Console.WriteLine("You try to make a run for it, but your attacker is focused on you!");
                        Console.WriteLine("Fortunately, your attacker is on the defensive.");
                    } else { // Enemy Attck
                        Enemy.Attack(Player, Defending.No);
                        Console.WriteLine("You try to make a run for it, but your attacker is too quick!");
                        Console.WriteLine("You are attacked while trying to escape!");
                        checkWinner();
                    }
                }
            } 
            else if (playerInput == TurnActions.Defend) {
                if (enemyInput == TurnActions.Defend) {
                    Console.WriteLine("You go on the defensive, anticipating an attack!");
                    Console.WriteLine("Forturnately, your attacker does the same.");
                }
                else { // Enemy Attacked
                    Enemy.Attack(Player, Defending.Yes);
                    Console.WriteLine("You brace yourself, preparing for an attack!");
                    Console.WriteLine("The attacker attacks you, but the hit is softened by your defensive stance!");
                    checkWinner();
                }
            }
            else if (playerInput == TurnActions.Attack) {
                if (enemyInput == TurnActions.Defend) {
                    Player.Attack(Enemy, Defending.Yes);
                    Console.WriteLine("You strike at your attacker!");
                    Console.WriteLine("Unfortunately, your attacker defends off much of the damage.");
                    checkWinner();
                }
                // both attacking, determine order by speed
                if (isPlayerFaster()) {
                    Player.Attack(Enemy, Defending.No);
                    Console.WriteLine("You strike at your attacker swiftly!");
                    checkWinner();
                    Enemy.Attack(Player, Defending.No);
                    Console.WriteLine("Your attacker responds with an attack of their own!");
                    checkWinner();
                } else {
                    Enemy.Attack(Player, Defending.No);
                    Console.WriteLine("You move to attack, but your attacker is faster!");
                    checkWinner();
                    Player.Attack(Enemy, Defending.No);
                    Console.WriteLine("After taking the hit, you strike back!");
                    checkWinner();
                }
            }

            displayTurnResults();
        }
        return battleLost;
    }
    private bool isPlayerFaster() {
        Console.WriteLine($"Player speed: {Player.Speed}, Enemy speed: {Enemy.Speed}");
        return (Player.Speed > Enemy.Speed);
    }
    public void executeTurn() {}

    public void checkWinner() {
        if (Player.Health <= 0) {
            // Enemy Wins, End the game
            Console.WriteLine("You lost the battle.");
            battleLost = true;
            battleOver = true;
            // Find a way to set the game over
        } else if (Enemy.Health <= 0) {
            Console.WriteLine("You won the battle.");
            // Player Wins
            battleOver = true;
        }
    }
    public void displayTurnResults() {
        // display the players health
        Console.WriteLine($"Your health is: {Player.Health}");
        Console.WriteLine();
    }
    public void displayResults() {}

}