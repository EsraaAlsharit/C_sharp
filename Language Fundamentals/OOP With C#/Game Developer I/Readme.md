# Core Assignment: Game Developer I

### Learning Objectives:

- Construct classes using OOP concepts in C#.
- Build fields and methods within classes.
- Demonstrate how classes can interact by creating instances of one class in another.
- Bonus: Illustrate the uses for accessibility modifiers.
##
### Directions
Scenario: You are working alongside a team of game developers on your next big project! It will be an exciting platformer game with tons of levels to explore and enemies to face. You have been tasked with building the enemies and combat system for the game. Your colleagues are already hard at work on the other elements, and what they really need from you right now is a basic Enemy class and an Attack class to get things going.

**Follow the guidelines below to build out your Enemy and Attack classes:**

### The Attack Class:
- Attack fields:
    - Name (i.e. fireball, punch, throw)
    - DamageAmount (i.e. a fireball will do 20 damage, keep the damage range between 5 and 25)
- Constructor: When an Attack is created, we must specify the Name and DamageAmount upon creation
### The Enemy Class:
- Enemy fields:
    - Name (i.e. Bandit, Boss, Guard)
    - Health
    - AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
- Constructor: 
    - When an Enemy is created, we must provide their Name upon creation
    - Health will start at a default value of 100
    - AttackList will initialize as an empty List
- Methods:
- RandomAttack: the enemy object performs a randomized attack from their AttackList (hint: remember Random()?)
### Testing:
- Create an instance of an Enemy in Program.cs (you can create any enemy you would like)
- Create 3 instances of Attacks in Program.cs (again, you can create any attacks you would like. Have fun with it!)
- Add the three Attacks to your Enemy instance's AttackList (hint: how do you add items to a List?)
- Call your Enemy instance's RandomAttack method to test that a random Attack can be called on (a good developer will run this multiple times to ensure there are no bugs)

Once you have confirmed your code is functional your part is done! Your colleagues will use your code for testing and ask for it to be developed further a little later...

- [x] Build the Attack class

- [x] Build the Enemy class

- [x] Create an instance of an Enemy in Program.cs

- [x] Create 3 instances of Attacks in Program.cs

- [x] Add these Attacks to your Enemy instance's Attack List

- [x] Call on your Enemy's RandomAttack method to test that they can now perform the given Attacks

- [x] Bonus: Practice good programming by making the Enemy's Health attribute private and adding a Public version that lets us just see the value of private health

- [x] Bonus: Write a method for adding Attacks to your Enemy's AttackList rather than having to call on the List's Add method in Program.cs
