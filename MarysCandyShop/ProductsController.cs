namespace MarysCandyShop;

internal class ProductsController
{
    internal List<string> GetProducts()
    {
        var products = new List<string>();
        try
        {
            using (StreamReader reader = new(Configuration.docPath))
            {
                var line = reader.ReadLine();


                while (line != null)
                {
                    string[] parts = line.Split(',');
                    products.Add(line);
                    line = reader.ReadLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(UserInterface.divide);
        }

        return products;
    }
    internal void AddProduct()
    {
        Console.WriteLine("Product Name: ");
        var product = Console.ReadLine();
        try
        {
            using (StreamWriter outputFile = new StreamWriter(Configuration.docPath))
            {
                outputFile.WriteLine(product.Trim(), true);
            }
            Console.WriteLine("Products saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error saving products: " + ex.Message);
            Console.WriteLine(UserInterface.divide);
        }
    }
    internal void AddProducts(List<string> products)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(Configuration.docPath))
            {
                foreach (string product in products)
                {
                    outputFile.WriteLine(product.Trim());
                }   
            }
            Console.WriteLine("Products saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error saving products: " + ex.Message);
            Console.WriteLine(UserInterface.divide);
        }
    }
    internal void DeleteProduct(string message)
    {
        Console.WriteLine(message);
    }
    internal void UpdateProduct(string message)
    {
        Console.WriteLine(message);
    }


}
