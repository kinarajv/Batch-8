class Program 
{
	static void Main() 
	{
		int a = 3;
		Console.WriteLine("Initial value " + a);
		Multiplier(in a);
		Console.WriteLine("Final value " + a);
	}
	static void Multiplier(in int input) 
	{
		int result = input + 3;
	}
}