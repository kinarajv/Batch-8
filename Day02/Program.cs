using Day02;

class Program
{
	static void Main()
	{
		Cat cimol = new Cat(2, "domestic", "white");
		Console.WriteLine(cimol.age);
		Console.WriteLine(cimol.colour);
		
		Cat bolu = new Cat(1, "domestic", "grey");
		Console.WriteLine(bolu.age);
		Console.WriteLine(bolu.colour);

		Cat brownies = new Cat(species : "domestic", age : 2);
	}
}