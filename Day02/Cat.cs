namespace Day02;

public class Cat
{
	public int age;
	public string species;
	public string colour;
	public Cat(int age, string species = "unknown", string colour = "unknown") 
	{
		this.age = age;
		this.species = species;
		this.colour = colour;
	}
	public Cat(string species, string colour) 
	{
		age = 1;
		this.species = species;
		this.colour = colour;
	}
	public void Meow() 
	{
		Console.WriteLine("Meow");
	}
	public void Eat(string food) 
	{
		Console.WriteLine($"Eat {food}");
	}
	public void Eat(string food,int count) 
	{
		for (int i = 0; i < count; i++)
		{
			Console.WriteLine($"Eat {food} for {i} times");
		}
	}
	public void Eat(int count) 
	{
		Console.WriteLine($"Eat for {count} times");
	}
}

