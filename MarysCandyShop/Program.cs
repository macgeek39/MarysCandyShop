// Variables
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

Console.WriteLine(title);
Console.WriteLine(divide);
Console.WriteLine("Today's date: " + dateTime);
Console.WriteLine("Days since opening: " + daysSinceOpening);
Console.WriteLine("Today's profit: " + todaysProfit + "$");
Console.WriteLine("Today's target achieved: " + targetAchieved);
Console.WriteLine(divide);
Console.WriteLine(menu);
Console.ReadLine();

string usersChoice = Console.ReadLine().Trim().ToUpper();

if (usersChoice == "A")
{
    Console.WriteLine("User choose A");
} 
else if (usersChoice == "V")
{
    Console.WriteLine("User choose V");
}
else if (usersChoice == "D")
{
    Console.WriteLine("User choose D");
}
else if (usersChoice == "U")
{
    Console.WriteLine("User choose U");
}
else
{
    Console.WriteLine("Invalid choice. Please choose one of the above");
}