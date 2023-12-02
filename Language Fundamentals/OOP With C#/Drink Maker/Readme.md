# Practice Assignment: Drink Maker

### Learning Objectives:

- Create child classes using inheritance to streamline the code-building process.
- Implement polymorphism concepts to group alike objects.
- Implement method overriding to create unique results for each class.
##

When someone asks you to think of a "drink", what comes to mind? Perhaps you thought of a glass of water, a cup of coffee, or a pint of beer. "Drink" is a very generic word used to describe a wide variety of possible outcomes. But at the end of the day, there are certain characteristics we could use to describe any drink. We could describe a drink based on color, temperature, whether or not it's carbonated and much more. We will be using the idea of a basic "drink" to build out a series of more defined drinks using inheritance.

### Directions
Practice the OOP concepts of inheritance and polymorphism to complete the following assignment.

### Making a Drink
We will begin with our parent class. Take a moment to think: what are the basic components of any drink? Once you have these in mind, we will begin to build our class. Below is an example of a basic Drink class, but you are free to add any features you feel are missing.

```md
public class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;
    
    // We need a basic constructor that takes all these features in
    public Drink(string name, string color, double temp, bool isCarb, int calories)
    {
    	Name = name;
    	Color = color;
    	Temperature = temp;
    	IsCarbonated = isCarb;
    	Calories = calories;
    }
}
````
### Making Child Classes
Now that we have a basic Drink class, we can use this to build out some child classes. We encourage you to think creatively about the types of classes you can make, but if you would like some prompts, then build out the following classes. At a minimum, you should make three child classes.

Build the following child classes by inheriting from the Drink class. Add more features if desired!

### Soda Class
- Sodas are always carbonated.
- Sodas can be a diet version or not.
### Coffee Class
- Coffee has a roast value (dark, medium, light).
- Coffee has a type of beans used.
### Wine Class
- Wine has a region it came from.
- Wine has a year it was bottled.

Once you have created a few child classes, create instances of each class. Then perform the following actions:

- _Create a List of Drinks called AllBeverages and add all your instances to it (congrats! You just practiced polymorphism!)_
- Add a ShowDrink() method to your Drink class that displays information about the Drink.
- Loop through your List of AllBeverages and call the ShowDrink() method for each. (Something appears to be missing, right?)
- Write override methods for each child class that properly displays each class's unique fields and run your loop again. (Much better now!)
- Bonus: try this line of code Coffee `MyDrink = new Soda();` What is wrong with this? Why will it not work? Leave a commented note about it in Program.cs.

- [x] Create a Drink class

- [x] Create a Soda class

- [x] Create a coffee class

- [x] Create a wine class

- [ ] Test the classes using the directions above