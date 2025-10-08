string? readResult;
string menuSelection = "";
int dailyGoal = 0;
int glassesDrunk = 0;

do
{
    Console.Clear();
    Console.WriteLine("Welcome to Sip and Glow✨");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1) Set daily goal");
    Console.WriteLine("2) Log a glass of water");
    Console.WriteLine("3) View progress");
    Console.WriteLine("4) Reset progress");
    Console.WriteLine("5) Exit");
    Console.WriteLine();
    Console.Write("Select an option (1-5): ");

    readResult = Console.ReadLine();

    if (readResult != null) menuSelection = readResult.ToLower();

    switch (menuSelection)
    {
        
    }

} while (menuSelection != "5");