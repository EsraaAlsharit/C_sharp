// Challenge 1
// This value is supposed to be a boolean, not a string
// cannot implicitly convert from a string to a boolean
bool amProgrammer = true;
// doubles are not whole numbers
int Age = 27;
List<string> Names = new List<string>();
// Names = "Monica";
// This is not how we add values to a string List
Names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
// must convert to a string to follow the dictionary pattern
MyDictionary.Add("Hi there", "0");
// This is a tricky one! Hint: look up what a char is in C#
// Chars can only have one letter inside them 'm' 'myName'
string MyName = "MyName";

// Challenge 2
// Our starting value was out of bounds for the list
// We fixed it by subtracting 1 from the Count of our List
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count-1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
// Foreach loops deal with the value inside of a list, not the index
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i);
}

// Challenge 4
// Foreach values do NOT represent the location of the value
// Therefore, we cannot alter the value within a foreach loop
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        // I need to figure out what this is meant to do
        // num = 0;
    }
}

// Challenge 5
// What can we learn from this error message?
// strings are immutable and this is not a valid operation
string MyString = "superduberawesome";
// We need to go back and figure out what the intent was
// MyString[7] = "p";

// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
// random will get a number between 0 and 11
int randomNum = rand.Next(12);
// We will never hit this if statement
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
