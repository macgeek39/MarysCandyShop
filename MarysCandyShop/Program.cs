// Switch
var title = "Mary's Candy Shop";
var divide = "----------------------------------";
var dateTime = DateTime.Now;
var daysSinceOpening = 1;
var todaysProfit = 5.5m;
var targetAchieved = false;
var menu = "Choose one option:\n"
    + 'V' + " to view products \n"
    + 'A' + " to add products \n"
    + 'D' + " to delete products \n"
    + 'U' + " to update products \n";

Console.WriteLine(@$"{ title}
{divide}
Today's date: {dateTime}
Days since opening: {daysSinceOpening}
Today's profit: {todaysProfit} $
Today's target achieved: {targetAchieved}
{divide}
{menu}");

var usersChoice = Console.ReadLine().Trim().ToUpper();


switch (usersChoice)
{
    case "A":
        Console.WriteLine("User choose A");
        break;
    case "V":
        Console.WriteLine("User choose V");
        break;
    case "D":
        Console.WriteLine("User choose D");
        break;
    case "U":
        Console.WriteLine("User choose U");
        break;
    default:
        Console.WriteLine("Invalid choice. Please choose one of the above");
        break;
}