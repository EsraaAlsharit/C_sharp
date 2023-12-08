# Core Assignment: Game Developer II

### Learning Objectives:

- Create child classes using inheritance to streamline the code-building process.
- Demonstrate how pre-existing methods can be overwritten to create unique methods for child classes.
##
Your fellow devs are happy with the basic Enemy and Attack classes you provided them and are done with their initial tests. Now they want to test things a little further by creating a variety of enemies with different attacks and capabilities. You could hard-code a series of various enemies for testing purposes, but you're a smart programmer and you know that you can save time and effort by using Inheritance and your original Enemy class to help you out.

### Directions
**Review the list of added features your colleagues would like and get coding:**

To get started, you need to add a new method to your existing Enemy class: a PerformAttack() method. This method should take in a Target (for now you will use other Enemies as Targets) and a specified Attack to perform from the enemy's available AttackList. The method should reduce the Health of the Target based on the DamageAmount provided by the Attack. Here is some code to get you started:
```md
// Inside of the Enemy class
public void PerformAttack(Enemy Target, Attack ChosenAttack)
{
    // Write some logic here to reduce the Targets health by your Attack's DamageAmount
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
}
````
Once you have your PerformAttack() method ready, the next step is to create three unique classes that inherit from your Enemy class: a melee fighter class, a ranged fighter class, and a magic caster class. Each enemy type comes with its own set of Attacks and methods, as outlined below.

### Melee Fighter
- Health starts at a default of 120
- Attacks:
    - Punch, 20 damage
    - Kick, 15 damage
    - Tackle, 25 damage
- Rage method - The fighter performs a random attack from its AttackList, but the attack deals 10 extra damage
    - Hint: How will you handle updating the DamageAmount of your attack when you perform the attack?

### Ranged Fighter
- Ranged enemies have a Distance field that tracks how far from the player the ranged enemy is (the "player" in this scenario is theoretical and does not need to be factored into the code at this time)
- The Distance field defaults to 5 upon initialization
- Attacks:
    - Shoot an Arrow, 20 damage
    - Throw a Knife, 15 damage
- A ranged enemy cannot perform an attack if Distance is less than 10
- Dash method - The fighter performs a dash, setting Distance to 20
    - Note: Do not worry about Distance when considering if a close-range attack like a punch can hit a Ranged fighter, just assume it will for now

### Magic Caster
- Health starts at a default of 80
- Attacks:
    - Fireball, 25 damage
    - Lightning Bolt, 20 damage
    - Staff Strike, 10 damage
- Heal method - The fighter heals a targeted Enemy character for 40 health and displays the new health at the end

**Once all your classes are created, complete the following series of actions to test all your new code:**

1. Create instances of the Melee, Ranged, and Magic Caster classes
1. Perform the Kick Attack from your Melee class character on your Ranged character
1. Perform the Rage method from your Melee class character on your Magic Caster character
1. Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
1. Have your Ranged character perform the Dash method
1. Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
1. Perform a Fireball Attack from your Magic Caster on your Melee character
1. Have the Magic Caster perform the Heal method on the Ranged character
1. Have the Magic Caster perform the Heal method on themselves

### Bonuses
- Write special Console messages for each fighter's PerformAttack method
    - You can add even more detail by considering what types of messages would appear for specific attacks
- You may have noticed that when you Heal a character they can end up with more health than they started with. Can you think of a clever way to ensure that your character does not go above their maximum health?
- Conversely, do you think a character should be able to attack another character who has 0 health? Or that a character with 0 health should be capable of attacking? How can you ensure that a character can only be attacked/perform attacks so long as their health is a positive value?
- Have your code reviewed by someone else to see how you might make your code more efficient (comparing your code to someone else's code is a great way to learn!) Some potential areas to check for efficiency might include:
    - Assessing where and how you chose to assign each Attack to your enemies
    - Considering best practices when affecting another character's stats (like in the PerformAttack or Heal method)
    - How you tackled the bonus challenges

- [x] Add the PerformAttack() method to your Enemy class

- [X] Create a Melee class to the specifications listed

- [x] Create a Ranged class to the specifications listed

- [x] Create a Magic class to the specifications listed

- [x] Complete the series of actions section

- [ ] Bonus: Complete the bonus challenges