# Practice Assignment: Puzzles

### Learning Objectives:

- Create functions using C# syntax.
- Implement programming logic to solve problems using C# syntax in a console application.
- Demonstrate how built-in features like Random and while loops can be used to achieve a variety of results.
- Bonus: Demonstrate how user input can be taken into consideration when writing functions.
##
### Directions
Using the skills you have gained so far, complete these challenges:

### Coin Flip
We've likely all flipped a coin at least once in our lives when trying to decide on this or that. Flipping a coin in person is easy. But how would you write your own coin flip function? Write a function that returns "heads" or "tails" depending on the result you get.

**If you don't know where to start, consider the following prompts:**

- How many results can you get when you flip a coin?
- How can we write code that produces a single, random result from our pool of options?
- What happens after the coin lands? (i.e. How do you determine what the result was and convey that to your user?)
### Dice Roll
Once you have figured out coin flip, take your learning to the next level by creating a dice roller. Once again, think about what it is like to roll a die in real life. How could you replicate those actions in code?

**Consider the following:**

- How many sides is your die? (We recommend you start with a standard 6-sided die but feel free to start wherever you like!)
- How many results can we get based on how many sides there are? Write down all possible results if needed.

Tip: Make sure to return the value rolled at the end.

Bonus: Can you rewrite your function to accept a parameter for the number of sides so you can roll any number-sided die?

### Stat Roll
Once you have your dice roller all worked out, write a new function that will roll your dice 4 times and returns a List of those 4 results. You can write your function to hard-code 4 dice rolls.

**Consider the following:**

- How do you make a function run repeatedly?
- How can we see the results of our rolls? (What happens when you try to Console.WriteLine a List?)

Bonus: Write your function to roll any number of times you would like.

Bonus: After finishing your rolls, print the largest value you rolled.

### Roll Until...
Write a new function that will roll your 6-sided die until you land on a certain result and tracks how many rolls occurred until it lands on the given number. For example, you could tell your code to keep rolling until your 6-sided die rolls the number 2. When you land on the number, return a string that says "Rolled a {number} after {count} tries". Tip: Do not hard-code the number you're looking for. Be able to accept any number.

#### Consider the following:

- Do we know how many times our die will roll before it lands on the number we asked for? If not, how will this influence the logical options we have?
- What would happen if we ask for a number that is not on our die? (i.e. What happens if we tell our die to roll until it lands on 8 on a 6-sided die?) How can we prevent or handle unwanted inputs?

### Optional Bonus
Can you take some of the methods you wrote and combine them with what you learned about taking in user input and type casting to create an interactive dice roller? Upon starting the project, a user should be prompted to ask what size of die they would like to roll (6-sided, 12-sided, 20-sided, etc...) and receive a result. Optionally, you can also take input to determine if you would like to roll again or run a different function (like Roll Until). Have fun with it!

- [x] Complete Coin Flip

- [x] Complete Dice Roll

- [x] Complete Stat Roll

- [x] Complete Roll Until

- [ ] Bonus: Complete Optional Bonus
