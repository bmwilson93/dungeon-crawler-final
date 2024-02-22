namespace DungeonCrawler.Lib.Characters;
public interface ICharacter { // REQUIREMENT #13 an Interface
    public int Health {get; set;}
    public int Strength {get; set;}
    public int Defense {get; set;}
    public int Speed {get; set;}

    // Determines how much damage to cause, then Calls TakeDamage on the provided target Character
    public void Attack (ICharacter target, Defending value);
    // Applys damage to this objects health
    public void TakeDamage (int damage);

    public TurnActions GetInput();

}