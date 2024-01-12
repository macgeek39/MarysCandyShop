// Variables
string title = "Mary's Candy Shop";
string divide = "----------------------------------";
DateTime dateTime = DateTime.Now;
int daysSinceOpening = 1;
decimal todaysProfit = 5.5m;
bool targetAchieved = false;
string menu = "Choose one option:\n"
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