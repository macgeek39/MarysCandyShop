namespace MarysCandyShop;

internal class DataSeed
{
    string[] candyNames =
    {
    "Snickers","Kit Kat","Twix", "M&M's", "Reese's Peanut Butter Cups", "Hershey's Milk Chocolate"
    };
    void SeedData()
    {
        var productsController = new ProductsController();
        productsController.AddProducts(candyNames.ToList());
    }
}
