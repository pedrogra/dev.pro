namespace DevPro.Code.Task2;
#region Task Description
/*
    Task 2: Inventory Management

    Context: You are developing a simple inventory management system for a small store.
    You need to create a function that takes a list of products with their names, prices, and stock levels, and returns a sorted list of products based on a given sort key (name, price, or stock) and order (ascending or descending).

   Example Input:
   products = [
   {"name": "Product A", "price": 100, "stock": 5},
   {"name": "Product B", "price": 200, "stock": 3},
   {"name": "Product C", "price": 50, "stock": 10}
   ]
   sort_key = "price"
   ascending = False

   Expected Output:
   [
   {"name": "Product B", "price": 200, "stock": 3},
   {"name": "Product A", "price": 100, "stock": 5},
   {"name": "Product C", "price": 50, "stock": 10}
   ]
 */
#endregion
public class Sorter
{
    public List<Product> sort_products(List<Product> products, string sortKey, bool ascending)
    {
        switch (sortKey.ToLowerInvariant())
        {
            case "name":
                products = products.OrderBy(product => product.Name).ToList();
                break;
            case "price":
                products = products.OrderBy(product => product.Price).ToList();
                break;
            case "stock":
                products = products.OrderBy(product => product.Stock).ToList();
                break;
            default:
                return products;
        }
        if(!ascending)
            products.Reverse();
        foreach (var product in products)
        {
            Console.WriteLine("Name: {0} - Price: {1} - Stock: {2}", product.Name, product.Price, product.Stock);
        }
        Console.WriteLine("--");
        return products;
    }
}