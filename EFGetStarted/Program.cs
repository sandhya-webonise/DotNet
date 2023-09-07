
using EFGetStarted.Data;
using EFGetStarted.Models;

using Context context = new Context();

var cornSpecial = context.Products
    .Where(p => p.Name == "Corn Special Pizza")
    .FirstOrDefault();
if (cornSpecial is Product)
{
    cornSpecial.Price = 10.99M;
    context.Remove(cornSpecial);
}

context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;

foreach (Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}