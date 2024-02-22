namespace DungeonCrawler.Lib.Characters;

public class Enemy: Character {
    public override TurnActions GetInput() // REQUIREMENT #8 - a second example of polymorphism 
    {
        // Determine what the enemy shoudl do and return it
        return base.GetInput();
    }

}