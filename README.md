# Dungeon Crawler Final Project

Final Project for Object-oriented Programming course

## Dungeon Crawler
A text based dungeon crawling adventure game. The player can select and name their character, and choose a dungeon to explore. 
The game works by generating a room, with a possbile item or enemy to interact with, and letting the player explore. When exiting a room, another room is generated.
When the final number of rooms is reached, a boss battle begins. If the player can defeat the boss, they win. 


## Main Game Loop:
1. Generate a room in the dungeon
- The dungeon class creates a new room and passes it the game class
- The Game class reads the rooms description to the player
    
2. Interact with the room
- If the Room contains anything, allow the player to interact with the contents
- This could be adding an item to their inventory, or battling an enemy

3. Choose the next room
- After any contents are interacted with, preset the play with options to continue to another room


## Required Elements:

A list of the project requirements 

1. a class definition
2. a second class definition
3. a third class definition
    (Should be pretty easy to complete, Dungeon, Character, Enemy, etc)

4. a struct definition
    (Use Item, or maybe the inventory as a stuct)

5. an enumerated type
    (Room contents can be an enum, 0 = empty, 1 = item, 2 = enemy)

6. inheritance
    (Player and enemy inherit from a base character class)

7. polymorphism
8. a second example of polymorphism
    (Player and enemy can implement their attack differently)

9. throwing an exception and properly catching it
    (When naming a character an exception could be used, or possibly when selecting another room)

10. definition of your own generic datatype
    (Maybe I could make a generic item type?)

11. properties
    (Rooms can use a property to hold their description, Characters can use properties to hold their stats)

12. a static member function
    (A static spawner could be used to create and pass Room contents, or even used in the room to generate the description)

13. an interface
    (The properties and methods of a character could be defined in an interface)

14. a second interface
    (Items could make use of an interface)

15. use of at least two of the built-in generic collection types
    (The inventory could use a list, and the item type could possibly make use of a dictionary)

5 points extra credit for any of the following:
working with file IO
    (May be able to implement a save game, not sure on that yet.)
recursion
operator overloading




(15 pts): discussion of required elements (1pt each)
For each required element, include a comment clearly pointing me to where you used that element. For example, your first interface should be accompanied by a comment like the following (feel free to include a description justifying why it is an appropriate use of that feature):
// REQUIREMENT #13 an interface
(-10 pts if data hiding is violated)
(-5 pts for an inappropriate use of any of the required elements)

 (25 pts): style (5pt each)
README.txt description of the overall project (the goal and basic organization)
documentation of the role of classes/files and the method signatures
easy to read code (possible aided by comments if necessary)
meaningful identifiers
quality whitespace
