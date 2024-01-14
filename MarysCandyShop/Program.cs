using MarysCandyShop;

Product product = new Product("Chocolate Cake");

Configuration configuration = new Configuration();

string[] candyNames =
{
    "Snickers","Kit Kat","Twix", "M&M's", "Reese's Peanut Butter Cups", "Hershey's Milk Chocolate"
};
var products = new Dictionary<int, string>();
var divide = "----------------------------------";
// SeedData();

if (File.Exists(docPath))
{
    LoadData();
};


var isMenuRunning = true;



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
            ViewProducts();
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
            Console.WriteLine("Invalid choice. Please choose one of the above");
            break;
    }
    Console.WriteLine(menuMessage);
    Console.ReadLine();
    Console.Clear();
}

void SeedData()
{
    for (int i = 0; i < candyNames.Length; i++)
    {
        products.Add(i, candyNames[i]);
    }
}

void ViewProducts()
{
    Console.WriteLine(divide);
    foreach (var product in products)
    {
        Console.WriteLine($"{product.Key}.{product.Value}");
    }
    Console.WriteLine(divide);
}
void AddProduct()
{
    Console.WriteLine("Product Name: ");
    var product = Console.ReadLine();
    var index = products.Count();
    products.Add(index, product.Trim());
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
    try
    {
        using (StreamWriter outputFile = new StreamWriter(Configuration.docPath))
        {
            foreach (KeyValuePair<int, string> product in products)
            {
                outputFile.WriteLine($"{product.Key},{product.Value}");
            }
        }
        Console.WriteLine("Products saved.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was an error saving products: " + ex.Message);
        Console.WriteLine(divide);
    }
    
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

void LoadData()
{
    try
    {
        using (StreamReader reader = new(Configuration.docPath))
        {
            var line = reader.ReadLine();


            while (line != null)
            {
                string[] parts = line.Split(',');
                products.Add(int.Parse(parts[0]), parts[1]);
                line = reader.ReadLine();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(divide);
    }
    
}