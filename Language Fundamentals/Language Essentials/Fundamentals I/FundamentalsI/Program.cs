// Create a loop that prints all values from 1-255.
Console.WriteLine("Create a loop that prints all values from 1-255.");
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}
// Create a new loop that generates 5 random numbers between 10 and 20.
Console.WriteLine("Create a new loop that generates 5 random numbers between 10 and 20.");
// Console.WriteLine(" ");   
Random rand = new Random();
int sum = 0;
for (int j = 1; j <= 5; j++)
{
    int tem = rand.Next(10, 20);
    sum += tem;
    Console.WriteLine(tem);
}

Console.WriteLine("Modify the previous loop to add the random values together and print the sum after the loop finishes.");
Console.WriteLine(sum);


Console.WriteLine("Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.");
for (int k = 1; k <= 100; k++)
{
    if (k % 3 == 0 && k % 5 == 0)
    {
        continue;
    }
    if (k % 3 == 0 || k % 5 == 0)
    {
        Console.WriteLine(k);
    }
}

Console.WriteLine("Modify the previous loop to print 'Fizz' for multiples of 3 and 'Buzz' for multiples of 5.");
for (int l = 1; l <= 100;l++)
{
    if (l % 3 == 0 && l % 5 == 0)
    {
        continue;
    }
    if (l % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    if (l % 3 == 0 || l % 5 == 0)
    {
        Console.WriteLine("Buzz");

    }
}

Console.WriteLine("Modify the previous loop once more to now also print 'FizzBuzz' for numbers that are multiples of both 3 and 5.");
for (int m = 1; m <= 100; m++)
{
    if (m % 3 == 0 && m % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");

    }
    if (m % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    if (m % 3 == 0 || m % 5 == 0)
    {
        Console.WriteLine("Buzz");

    }
}

Console.WriteLine("(Optional) If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!");
int n = 1;
while (n<= 100)
{
    if (n% 3 == 0 && n% 5 == 0)
    {
        Console.WriteLine("FizzBuzz");

    }
    if (n% 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    if (n% 3 == 0 || n% 5 == 0)
    {
        Console.WriteLine("Buzz");

    }
    n++;
}