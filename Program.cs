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
        case "1":
        SetDailyGoal();
        break;

        case "2":
        LogGlass();
        break;
    }

} while (menuSelection != "5");

Console.WriteLine("Goodbye, and stay hydrated 💧!");

#region Methods

void SetDailyGoal()
{
    Console.Write("Enter your daily water goal (in glasses): ");
    readResult = Console.ReadLine();

    if (int.TryParse(readResult, out int goal) && goal > 0)
    {
        dailyGoal = goal;
        Console.WriteLine($"Your daily goal is set to {dailyGoal} glasses of water!");
    }
    else
    {
        Console.WriteLine("Please enter a valid positive number.");
    }

    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
}

void LogGlass()
{
    if (dailyGoal == 0)
    {
        Console.WriteLine("Please set your daily goal first!");
    }
    else if (glassesDrunk < dailyGoal)
    {
        glassesDrunk++;
        Console.WriteLine($"Nice! You've logged a glass. Total: {glassesDrunk}/{dailyGoal}");
    }
    else
    {
        Console.WriteLine("Goal reached! You can't log more today 🚰");
    }

    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
}

void viewProgress()
{
    if (dailyGoal == 0)
    {
        Console.WriteLine("You haven't set a goal yet!");
    }
    else
    {
        double percentage = ((double)glassesDrunk / dailyGoal) * 100;
    }
}

#endregion