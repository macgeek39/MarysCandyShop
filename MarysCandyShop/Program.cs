﻿PrintHeader();

var usersChoice = Console.ReadLine().Trim().ToUpper();


switch (usersChoice)
{
    case "A":
        ViewProduct("User choose A");
        break;
    case "V":
        AddProduct("User choose V");
        break;
    case "D":
        DeleteProduct("User choose D");
        break;
    case "U":
        UpdateProduct("User choose U");
        break;
    default:
        Console.WriteLine("Invalid choice. Please choose one of the above");
        break;
}

void ViewProduct(string message)
{
    Console.WriteLine(message);
}
void AddProduct(string message)
{
    Console.WriteLine(message);
}
void DeleteProduct(string message)
{
    Console.WriteLine(message);
}
void UpdateProduct(string message)
{
    Console.WriteLine(message);
}

string GetMenu()
{
    return "Choose one option:\n"
    + 'V' + " to view products \n"
    + 'A' + " to add products \n"
    + 'D' + " to delete products \n"
    + 'U' + " to update products \n";
}

int GetDaysSinceOpening()
{
    var openingDate = new DateTime(2024, 1, 1);
    TimeSpan timeDifference = DateTime.Now - openingDate;

    return timeDifference.Days;
}

void PrintHeader()
{
    // Method
    var title = "Mary's Candy Shop";
    var divide = "----------------------------------";
    var dateTime = DateTime.Now;
    var daysSinceOpening = GetDaysSinceOpening();
    var todaysProfit = 5.5m;
    var targetAchieved = false;
    var menu = GetMenu();

    Console.WriteLine(@$"{title}
{divide}
Today's date: {dateTime}
Days since opening: {daysSinceOpening}
Today's profit: {todaysProfit} $
Today's target achieved: {targetAchieved}
{divide}
{menu}");
}