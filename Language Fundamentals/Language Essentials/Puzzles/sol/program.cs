// Coin flipper
static string CoinFlip()
{
    Random rand = new Random();
    // rand.Next will give back 0 or 1
    if(rand.Next(2) == 0)
    {
        return "Heads";
    } else {
        return "Tails";
    }
}

Console.WriteLine(CoinFlip());


static int DiceRoll(int sides)
{
    Random rand = new Random();
    return rand.Next(1,sides+1);
}

Console.WriteLine(DiceRoll(6));

static List<int> StatRoll()
{
    List<int> Results = new List<int>();
    for(int i = 0; i < 4; i++)
    {
        Results.Add(DiceRoll(6));
    }
    return Results;
}

Console.WriteLine(string.Join(", ", StatRoll()));

static string RollUntil(int number, int sides)
{
    if(number > sides)
    {
        return "Please choose another number";
    }
    int count = 0;
    int result = DiceRoll(sides);
    while(result != number)
    {
        count++;
        result = DiceRoll(sides);
    }
    return $"Rolled a {number} after {count} tries";
}

Console.WriteLine(RollUntil(3, 6));