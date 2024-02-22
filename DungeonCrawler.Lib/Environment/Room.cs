namespace DungeonCrawler.Lib.Environment;

// Room
// contains the room content, and description
// can generate it's content and description

// Decided to make contents public for use in a spawner object
// TODO, recode the contents in the Room to use the public Contents
public enum Contents // REQUIREMENT #5 an enumerated type
    {
        Nothing,
        Item,
        Enemy
    }

public class Room { // REQUIREMENT #2 a second class definition

    public Room (int difficulty) {
        _difficulty = difficulty;
        GenerateContents();
        Description = GenerateDescription();
    }
    

    // !!! expose the difficulty & contents for testing
    public int Difficulty { 
        get{
            return _difficulty;
        }
    }

    public Contents RoomContents { 
        get{
            return _contents;
            // if (_contents == Contents.Enemy) return ;
            // if (_contents == Contents.Item) return 2;
            // return 1;
        }
    }
    // !!!
    
    public string Description { get; private set; } = "";

    private int _difficulty = 1;
    private Random rnd = new Random();
    private Contents _contents = Contents.Nothing;

    // TODO - implement GenerateDescription()
    // called in the constructor
    // Used the rooms generated content to build a string descripton to display to the user
    public string GenerateDescription() {
        return "The room contains: " + _contents;
    }

    // If your luck < the enemy chance, then room contains an enemy
    // Enemy chance: Difficulty 1 = 20%; 2 = 40%; 3 = 60%
    // Otherwise 50/50 chance of finding an item
    public void GenerateContents() {
        int luck = rnd.Next(100);
        int enemyChance = 20 * _difficulty;
        if (luck < enemyChance) {
            _contents = Contents.Enemy;
        } else if (luck % 2 == 0) {
            _contents = Contents.Item;
        } else {
            _contents = Contents.Nothing;
        }
    }

}