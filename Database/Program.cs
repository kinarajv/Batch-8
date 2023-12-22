
using Database;
using Microsoft.EntityFrameworkCore;

class Program 
{
	static void Main() 
	{
		using(Northwind db = new Northwind()) 
		{
			// List<Category> categories = db.Categories.Include(c => c.Products).ToList();
			// foreach(var c in categories) 
			// {
			// 	Console.WriteLine(c.CategoryName);
			// 	Console.WriteLine(c.Products.Count);
			// 	foreach(var p in c.Products) 
			// 	{
			// 		Console.WriteLine("\t" + p.ProductName);
			// 	}
			// }
			var products = db.Products.Where(p => p.UnitPrice > 1000);
			foreach(var p in products) 
				{
					Console.WriteLine("\t" + p.ProductName + " price " + p.UnitPrice);
				}
		}
	}
}