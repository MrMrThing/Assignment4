using DataLayer.Model;
using Npgsql;

namespace DataLayer
{
    public class DataService
    {
        public IList<Category> GetCategories()
        {
            using var db = new NorthwindContext();

            return db.Categories.ToList();
        }

        public IList<Product> GetProducts()
        {
            using var db = new NorthwindContext();

            return db.Products.ToList();
        }

        public IList<Order> GetOrders()
        {
            using var db = new NorthwindContext();

            return db.Orders.ToList();

        }
    }
}