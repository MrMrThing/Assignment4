using DataLayer;
using DataLayer.Model;
using Npgsql;

var ds = new DataService();

var categories = ds.GetCategories();

var products = ds.GetProducts();

var orders = ds.GetOrders();

foreach (var category in categories)
{
    //Console.WriteLine(category.Name);
}

foreach (var product in products)
{
    //Console.WriteLine(product.Name);
}

foreach (var order in orders)
{
    try
    {
        Console.WriteLine(order.Id);
    }
    catch (NpgsqlException ex) {
        Console.WriteLine(ex.Message);
    }
}