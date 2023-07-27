// Create a loop that prints all values from 1-255.
// for(int i = 1; i < 256; i++)
// {
//     Console.WriteLine(i);
// }

// Create a new loop that generates 5 random numbers between 10 and 20.
Random rand = new Random();
// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine(rand.Next(10,21));
// }

// Modify the previous loop to add the random values together and print the sum after the loop finishes.
int sum = 0;
// for(int i = 0; i < 5; i++)
// {
//     sum+=rand.Next(10,21);
// }
// Console.WriteLine(sum);

// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.
// for(int i = 1; i < 101; i++)
// {
//     if(i % 3 == 0 && i % 5 == 0)
//     {
//         continue;
//     }
//     if(i % 3 == 0 || i % 5 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
// for(int i = 1; i < 101; i++)
// {
//     if(i % 3 == 0 && i % 5 == 0)
//     {
//         continue;
//     }
//     if(i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - Fizz");
//     }
//     if(i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     }
// }

// Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
for(int i = 1; i < 101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}

// (Optional) If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!
// for(int i = 1; i < 256; i++)
// {
//     Console.WriteLine(i);
// }
int j = 1;
while(j < 256)
{
    Console.WriteLine(j);
    j++;
}