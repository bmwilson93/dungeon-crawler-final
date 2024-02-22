namespace DungeonCrawler.Lib.Environment;

/* 
    Dungeon class
    contains a room
    tracks the dungeon difficulty, current room number, and the total rooms
*/ 

/// <summary>
/// Dungeon - Used to create and return a Room.
/// Holds the difficulty, current room, and total number of rooms
/// </summary>
public class Dungeon // REQUIREMENT #1 a class definition
{
    // REQUIREMENT #11 properties
    public int Difficulty { get; set; }
    public int CurrentRoomNumber { get; set; }
    public int TotalRooms { get; private set; }

    private Room? _currentRoom = null;
    public Room? CurrentRoom { 
        get {
            if (_currentRoom == null) {
                GetNewRoom();
            }
            return _currentRoom;
        } set {
            _currentRoom = value;
        } 
    }

    /// <param name="difficulty">the difficulty of the dungeon (1, 2, or 3) - affects number of total rooms, and odds of enemies</param>
    public Dungeon(int difficulty = 1) {
        Difficulty = difficulty;
        setTotalRooms(difficulty);
        GetNewRoom();
    }

    // sets the number of total rooms based on the difficulty
    private void setTotalRooms(int difficulty) {
        if (difficulty == 3) TotalRooms = 20;
        else if (difficulty == 2) TotalRooms = 15;
        else TotalRooms = 10;
    }

    // Creates a new room, and sets it to the Current Room
    public void GetNewRoom() {
        _currentRoom = new Room(Difficulty);
        CurrentRoomNumber++;
    }

}

public class NoRoomException: Exception {}