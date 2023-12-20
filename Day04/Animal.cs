namespace Day04;

public class Animal
{
	public string name;
	public int age;
	public Animal() 
	{
		Console.WriteLine("Parent Animal");
	}
	public void Eat(string food) 
	{
		Console.WriteLine($"Eat {food}");
	}
}
