# Practice Assignment: Debugging Practice

###  Learning Objectives:

- Evaluate pre-written code for errors
- Indicate in comments what problems were encountered and how they were resolved
##
### Directions
Create a console project called "DebuggingPractice" and paste the code provided below into your Program.cs file. This code is filled with bugs! Use what you've learned so far about debugging to make your way through each challenge. Take notes on what the problems were and how you solved them. When you are done, upload the fixed-up project to the platform (with all the surrounding files and folders, please!)

Note: there is no one true way to solve some of these problems. (In fact, some might not be solvable!) It is up to you to make a judgment call on how the problem should be addressed.
```md
// Challenge 1
bool amProgrammer = "true";
int Age = 27.9;
List<string> Names = new List<string>();
Names = "Monica";
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", 0);
// This is a tricky one! Hint: look up what a char is in C#
string MyName = 'MyName';
// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}
// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(MoreNumbers[i]);
}
// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        num = 0;
    }
}
// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
MyString[7] = "p";
// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
````
- [ ] Debug each challenge by correcting and/or noting the bug causing the issue
