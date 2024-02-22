namespace DungeonCrawler.Lib.Characters;

// Character the base class for all character objects
public class Character: ICharacter {
    public int Health {get; set;}
    public int Strength {get; set;}
    public int Defense {get; set;}
    public int Speed {get; set;}

    public Character(int hp = 100, int str = 10, int def = 10, int spd = 10) {
        Health = hp;
        Strength = str;
        Defense = def;
        Speed = spd;
    }

    // Attack, takes an object as an argument, then calls that object's damage method
    public void Attack (ICharacter target, Defending defending) {
        // determine the damage
        int damage = this.Strength * 4 - target.Defense * 2;
        // if target Defending.Yes half the damage
        if (defending == Defending.Yes) {damage = damage / 2;}
        // call TakeDamage on target
        target.TakeDamage(damage);
    }

    public void TakeDamage (int damage) {
        this.Health -= damage;
    }

    public virtual TurnActions GetInput() {
        return TurnActions.Attack;
    }
}