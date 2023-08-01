# Practice Assignment: Ride Mader

### Learning Objectives:

- Construct a class using OOP concepts in C#.
- Build fields and methods within classes.
- Create instances of a class to test OOP concepts.
##
Now that you understand what a class is and its various features, it's time to build a class! We will begin by making a basic vehicle class. A vehicle in this case can refer to anything that is able to take someone from one place to another faster than walking (i.e. a car, a plane, a skateboard, or even a horse can all be considered vehicles).

### Directions
Create a vehicle class with the following features in a Vehicle.cs file:

- Fields
    - A name (i.e. Honda Accord, Mountain Bike, Rollerblades)
    - The number of passengers the vehicle carries
    - The color of the vehicle
    - Whether or not the vehicle has an engine
    - How many miles the vehicle has already traveled - start this at 0 by default
- Constructors
    - A constructor that allows a user to fill in all fields (except distance traveled)
    - A constructor that only allows a user to fill in name and color and provides default values for all other fields (you can assume it will become some sort of car)
- Methods
    - A method called ShowInfo() prints out all the information about the vehicle
    - A method called Travel() accepts input for distance, adds that distance to the total distance traveled, and prints out a message saying how far the vehicle has gone

Once your vehicle class has been created, head back to Program.cs and complete the following tasks:

- Create at least 4 different vehicles using any of the constructors (use each constructor at least once)
- Put all the vehicles you created into a List
- Loop through the List and have each vehicle run its ShowInfo() method
- Make one of the vehicles Travel 100 miles
- Print the information of the vehicle to verify the distance traveled went up
- Bonuses:
    - Test this: manually set the distance traveled field to 350 and print the information. If your field was public, this will work. Why is this not the best practice to allow our users to change the distance traveled without going through the Travel() method?
    - Once you know the answer, make the distance traveled field private. How does this affect the code in Program.cs? Why is this better for us? Write comments in your code explaining your reasoning.

- [ ] Create a vehicle class using the features outlined above

- [ ] Test the vehicle class using the prompts above