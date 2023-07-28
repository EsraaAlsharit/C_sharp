//Three Basic Arrays
Console.WriteLine("Three Basic Arrays");

// Create an integer array with the values 0 through 9 inside.
int[] numArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] nameArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };

//Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] boolArray = new bool[10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    boolArray[i] = rand.Next(2) == 1;
    // if(rand.Next(2)){
    // boolArray[i]=True;
    // }else
    // {
    //     boolArray[i]=False;
    // }

    Console.WriteLine(boolArray[i]);
}
Console.WriteLine("");
Console.WriteLine("List of Flavors");


// List of Flavors
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> iceCream = new List<string>();
iceCream.Add("Vanilla");
iceCream.Add("Cotton Candy");
iceCream.Add("Chocolate");
iceCream.Add("Rainbow Sherbet");
iceCream.Add("Chocolate Chip Cookie");


// Output the length of the List after you added the flavors.
Console.WriteLine($"We currently have {iceCream.Count} different flavors");

// Output the third flavor in the List.
Console.WriteLine(iceCream[2]);
// Now remove the third flavor using its index location.
iceCream.RemoveAt(2);
// Output the length of the List again. It should now be one fewer.
Console.WriteLine($"We currently have {iceCream.Count} different flavors");

Console.WriteLine("");
Console.WriteLine("User Dictionary");


// User Dictionary
// Create a dictionary that will store string keys and string values.

Dictionary<string, string> dic = new Dictionary<string, string>();

// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)

for (int i = 0; i < nameArray.Length; i++)
{
    int index = rand.Next(iceCream.Count);
    dic.Add(nameArray[i], iceCream[index]);

}

// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

foreach (KeyValuePair<string, string> entry in dic)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}