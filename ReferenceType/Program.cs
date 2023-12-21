class Program 
{
	static void Main()
	{
		Car car = new Car(3);
		Console.WriteLine("Price before : " + car.price);
		Increaser(car);
		Console.WriteLine("Price after : " + car.price);	
	}
	static void Increaser(Car car) 
	{
		car.price += 4;
	}
}
class Car
{
	public int price;
	public Car(int price) 
	{
		this.price = price;
	}
}