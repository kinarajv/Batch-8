
using Database;
using Microsoft.EntityFrameworkCore;

class Program
{
	static async Task Main()
	{
		using (Northwind db = new Northwind())
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

			// .Where() = Multiple
			// .FirtsOrDefault() = Single

			//Read
			// Product? product = await db.Products.FirstOrDefaultAsync(p => p.UnitPrice > 1000);
			// IQueryable<Product> products = db.Products.Where(p => p.UnitPrice > 1000);
			// foreach (var p in products)
			// {
			// 	Console.WriteLine("\t" + p.ProductName + " price " + p.UnitPrice);
			// }

			//CUD => SaveChanges
			//Create
			//Category
			Category category = new Category()
			{
				Description = "Ini Electronic"
			};
			await db.Categories.AddAsync(category);
			await db.SaveChangesAsync();

			//Update
			// Category category = await db.Categories.FindAsync(9);
			// Category category2 = await db.Categories
			// 							.FirstOrDefaultAsync(c => c.CategoryId == 9);
			// category.CategoryName = "Elektronik";
			// await db.SaveChangesAsync();	
			
			//Delete
			// Category category = await db.Categories.FindAsync(9);
			// db.Categories.Remove(category);
			// await db.SaveChangesAsync();	
		}
	}
}