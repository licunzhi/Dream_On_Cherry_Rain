using EFCoreConsoleApp.Data;
using EFCoreConsoleApp.Models;

using ContosePizzaContext context = new ContosePizzaContext();

# region Add Products

// Create a new product
Product veggiSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.9M
};
// Save product
context.Products.Add(veggiSpecial);

Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};
context.Products.Add(deluxeMeat);

context.SaveChanges();

#endregion

#region display products
var products = context.Products
    .Where(p => p.Price > 10.0M)
    .OrderBy(p => p.Price);

Console.WriteLine("Use function method way:");
foreach (Product p in products)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}
#endregion

#region linqProduct

var productsLinq = from product in context.Products
               where product.Price >= 10.0M
               orderby product.Price descending
               select product;

Console.WriteLine("Use Linq way:");
foreach (Product p in productsLinq)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}
#endregion

#region update product
var veggiSpecialUpdate = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();

if (veggiSpecialUpdate is Product)
{
    veggiSpecialUpdate.Price = 11.11M;
}

context.SaveChanges();
#endregion