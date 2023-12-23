# Practice Assignment: Fuel Up!

### Learning Objectives:

- Build on top of your existing OOP knowledge.
- Apply interfaces to classes.
- Apply abstract to classes.
## 
Remember the Vehicle class we made in the Ride Maker assignment? We are going to be revisiting that assignment and building new features onto it. If you did not do the Ride Maker assignment, now is a good time to go back and complete it so you can work on this assignment next.

### Directions
Complete the following prompts to build out an advanced OOP structure.

Child Classes
First thing, we are going to need some child classes to make interfaces and abstract work best. Quickly build out the following three child classes. Do not worry about adding unique features to the classes for now. You can always come back and add more features later. For now, create a Car class, a Horse class, and a Bicycle class. These should all inherit from Vehicle.

Since they do not require extra features, setting up the classes should take no more than a few lines of code and should be repeatable across all three. Take special note of some features that should be defaulted. For example, a Horse would not have an engine, so the HasEngine field should default to false upon initialization.

### Interface
Create the following INeedFuel interface (code provided) that contains properties for FuelType (i.e. gas, hay), FuelTotal (how much fuel the vehicle has), and a method called GiveFuel(int Amount).
```md
interface INeedFuel
{
    string FuelType {get;set;}
    int FuelTotal {get;set;}
    void GiveFuel(int Amount);
}
````
Now take this interface and add it to your Car class and your Horse class. (Cars need gas or electricity to run and horses need hay to run.) Refactor the appropriate classes as needed to account for the new features. Default FuelTotal for all classes to 10. Get creative in how your GiveFuel method works!

### Abstract
We are now able to make our Vehicle an abstract class. Apply the abstract keyword where needed and adjust your code base accordingly until your program functions correctly.
```md
abstract class Vehicle
{
    // your code here
}
````
### Testing
With all the pieces in place, complete the following prompts:

1. Create an instance of each child (car, horse, bicycle)
Try to create an instance of Vehicle. Make a comment on what happened.
1. Create a List of Vehicles and put all your instances inside of it (notice you can still make Lists of type Vehicle!)
1. Create a List of type INeedFuel, but do not add anything to it yet.
1. _Loop through the List of Vehicles, and if an item has the INeedFuel interface applied, add it to the INeedFuel List. This should be done using coding logic. How can we identify that something has a specific interface applied to it? (Hint: you can find the answer on the page on Polymorphism.)_
1. _Take your finished INeedFuel List, loop through it, and give each item 10 units of fuel (what exactly 10 stands for here isn't the important part)._
1. _Finally, loop through the List again and print out the Name of the vehicle and how much fuel it has. If you did this correctly, all instances should say they have 20 units of fuel, since they all should have been initialized with 10 units._

- [x] Create a Car class, a Horse class, and a Bicycle class that all inherit from Vehicle

- [x] Create an Interface called INeedFuel

- [x] Add the INeedFuel Interface to Car and Horse

- [x] Make Vehicle an abstract class

- [ ] Complete the Testing portion of the assignment