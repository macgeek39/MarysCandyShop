string docPath = @"C:\Users\taiwe\Documents\cSharp\MarysCandyShopApp\MarysCandyShop\history.txt";
string[] candyNames =
{
    "Snickers","Kit Kat","Twix", "M&M's", "Reese's Peanut Butter Cups", "Hershey's Milk Chocolate"
};
var isMenuRunning = true;
var products = new List<string>();


while (isMenuRunning)
{
    PrintHeader();

    var usersChoice = Console.ReadLine().Trim().ToUpper();
    var menuMessage = "Press Any Key To Go Back to Menu";

    switch (usersChoice)
    {
        case "A":
           AddProduct();
            break;
        case "V":
            ViewProduct("User choose V");
            break;
        case "D":
            DeleteProduct("User choose D");
            break;
        case "U":
            UpdateProduct("User choose U");
            break;
        case "Q":
            menuMessage = "Good Bye!";
            SaveProducts();
            isMenuRunning = false;
            break;
        default:
            Console.WriteLine(menuMessage);
            break;
    }
    Console.WriteLine(menuMessage);
    Console.ReadLine();
    Console.Clear();
}


void ViewProduct(string message)
{
    Console.WriteLine(message);
}
void AddProduct()
{
    Console.WriteLine("Product Name: ");
    var product = Console.ReadLine();
    products.Add(product);
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
    + 'U' + " to update products \n"
    + 'Q' + " to quit the program  \n";
}

int GetDaysSinceOpening()
{
    var openingDate = new DateTime(2024, 1, 1);
    TimeSpan timeDifference = DateTime.Now - openingDate;

    return timeDifference.Days;
}

void SaveProducts()
{
    using (StreamWriter outputFile = new StreamWriter(docPath))
    {
        foreach(string product in products)
        {
            outputFile.WriteLine(product);
        }
    }
    Console.WriteLine("Products saved.");
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