# Optional Assignment: Game Developer III

### Learning Objectives:

- Build upon previous work to create robust applications capable of user input and random responses.
- Bonus: Compare and contrast practices in the way you write code against someone else's methods.
##
### Directions
It's time to have your own bit of fun with the game you've been developing! Using your knowledge of OOP and problem-solving, build out a small input-based encounter between a player and the enemies your created earlier.

This means you'll need to create a Player class to add to your project. To keep it simple, your Player should just have a Name, a default health of 100, and a set of at least four attacks (your choice on what the attacks are).

Once you're ready to go, follow these steps. Feel free to improvise or add your own features as well!

1. Start your game by welcoming the player and prompting them to enter a name for their character. This will become your playable character's name and create the instance of the player.
1. Then, randomly select an enemy for your player to fight. You can optionally default to the same character when running tests since some enemies have special conditions when fighting. The Melee character would be the easiest to start with.
1. Now it's time to program your gameplay loop. The objective is to keep fighting until one character falls to 0 health. On each turn, select a move you would like to use. This should reduce the enemy's health (use some of that code on attacking you wrote earlier to help you out here). In turn, the enemy will randomly select one of their own moves to use on you (do not worry about special moves like Rage, Dash, or Heal until you feel prepared to add it to the rotation). If neither of you is reduced to 0 health by the end of the round, the cycle begins again.
1. Once a character is reduced to 0 health, declare the winner and ask the player if they would like to go again. If yes, start a new round. If no, end the runtime.

### Bonuses
- Since the ranged fighter takes Distance into consideration, work this into your program by tracking how far away the two characters are from each other and not allowing certain actions like punching or kicking to take place unless the distance is less than 3. (Hint: you may need to limit when your ranged enemy can use the Dash method, and you may want to provide them with a melee attack option, otherwise they'll be helpless!)
    - When the game begins, have the characters start 2 units apart by default.
    - You will also need a way to close the distance gap if you want your character to stand a chance! Perhaps one of the attack options is to get close to the enemy.
- After you complete your project, go back through and see if there are any ways you could clean up your code. Maybe there are excessive bits of code in places, or maybe there's a more efficient way to make the gameplay loop run. It is encouraged to reach out to another student who completed the assignment and see what they did. Comparing notes is an excellent way to learn!

- [ ] Add welcome and name input feature

- [ ] Set up an enemy to fight

- [ ] Create fighting game loop

- [ ] Handle ending cases where one character reaches 0 health

- [ ] Allow the player to end or restart the game

- [ ] Complete bonus features