class Program 
{
	static void Main() 
	{
		int a = 2;
		Console.WriteLine("Initial value " + a);
		Multiplier(ref a);
		Console.WriteLine("Final value " + a);

		Car car = new Car(10);
		Console.WriteLine("Initial value of Car " + car.price);
		Multiplier(car);
		Console.WriteLine("Final value of Car " + car.price);

	}
	static void Multiplier(ref int input) 
	{
		input *= input;
	}	
	static void Multiplier(Car input) 
	{
		input.price *= input.price;
	}
}
class Car
{
	public int price;
	public Car(int x) 
	{
		price = x;
	}
}