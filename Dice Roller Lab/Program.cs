
        Console.WriteLine("Hello!  Welcome to the Dice Roller Game.");
        int dice = 0;

        while (true)
        {
            Console.WriteLine("\nEnter number of sides for your pair of dice.");
            while (!int.TryParse(Console.ReadLine(), out dice))
            {
                Console.WriteLine("Entry is not acceptable. Try again.");
            }
            if (dice < 0)
            {
                Console.WriteLine("Dice cannot have negative sides. Try again.");
            }
            else if (dice == 0)
            {
                Console.WriteLine($"Dice cannot be {dice}-sided.  Try again.");
            }
            else
            {
                Console.WriteLine($"\nYour dice pair is {dice}-sided. Let's play!");
                break;
            }
        }
bool roller = true;
while (roller)
{
    Console.WriteLine("\nPress enter to roll.");
    Console.ReadLine();
    int roll1 = GetRandom(dice);
    int roll2 = GetRandom2(dice);
    if (dice == 6)
    {
       Console.WriteLine($"{SixSum(roll1, roll2)}{GetSix(roll1, roll2)}Your roll is: {roll1} & {roll2}, which makes {roll1+roll2}.");
    }
    else
    {
        Console.WriteLine($"{DoublesorOdd(roll1, roll2)}Your roll is: {roll1} & {roll2}, which makes {roll1+roll2}.");
    }
    while (true)
    {
        Console.WriteLine("Would you like to roll again? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            roller = true;
            break;
        }
        else if (choice == "n")
        {
            roller = false;
            break;
        }
        else
        {
            Console.WriteLine("Answer not valid. Try again.");
        }
    }
}
Console.WriteLine("\nThanks for playing!");
Console.ReadLine();

static int GetRandom(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}

static int GetRandom2(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}

static string GetSix(int roll1, int roll2)
{
   if (roll1 == 1 && roll2 == 1)
    {
        return "You got Snake Eyes! ";
    }
   else if ((roll1 == 1 && roll2 == 2) || (roll1 ==2 && roll2 == 1))
    {
        return "You got Ace Deuce! ";
    }
   else if (roll1 == 6 && roll2 == 6)
    {
        return "You got Box Cars! ";
    }
   else
    {
        return "";
    }
}
static string SixSum(int roll1, int roll2)
{
    if (roll1 + roll2 == 7 || roll1 + roll2 == 11)
    {
        return "Win! ";
    }
    else if (roll1 + roll2 == 2 || roll1 + roll2 == 3 || roll1 + roll2 == 12)
    {
        return "Craps... ";
    }
    else
    {
        return "";
    }
}

static string DoublesorOdd(int roll1, int roll2)
{
    if (roll1 == roll2)
    {
        return $"Double {roll1}'s! Way to go! ";
    }
    else if ((roll1 + roll2)%2 != 0)
    {
        return "Sum is odd! ";
    }
    else
    {
        return "";
    }
}
