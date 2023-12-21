class Car 
{
	public readonly int[] myIntReadOnly;
	public int[] myInt;
	public Car(int count) 
	{
		myInt = new int[count];
		myIntReadOnly = new int[count];
	}
}
class Program 
{
	static void Main() 
	{
		Car car = new Car(3);
		car.myIntReadOnly[0] = 1;
		Console.WriteLine(car.myIntReadOnly[0]);
		//car.myIntReadOnly = new int[3]; //It will error
		
		car.myInt[0] = 1;
		Console.WriteLine(car.myInt[0]);
		car.myInt = new int[3]; // It will not error
	}
}