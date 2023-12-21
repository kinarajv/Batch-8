class Program 
{
	static void Main() 
	{
		int a = 3000;
		Console.WriteLine("Initial value " + a);
		Multiplier(out a);
		Console.WriteLine("Final value " + a);

		string myString = "341";
		bool statusOfParsing = int.TryParse(myString, out int result);
		Console.WriteLine(result);
		Console.WriteLine(statusOfParsing);
	}
	static void Multiplier(out int input) 
	{
		input = 200;
	}
}