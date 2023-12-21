class Program 
{
	static void Main()
	{
        int price = 3;
		Console.WriteLine("Price before : " + price);
		Increaser(price);
		Console.WriteLine("Price after : " + price);	
	}
	static void Increaser(int price) 
	{
		price += 4;
	}
}