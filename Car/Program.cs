using CarComponent;
//Composition
class Program 
{
	static void Main() 
	{
		// Engine engine = new Engine();
		// engine.cylinder = 3;
		// Lamp lamp = new Lamp();
		// Car car = new Car(engine, lamp);
		// car.Start();

		// Car car2 = new Car(new Engine(), new Lamp());

		// Engine engine1 = new Engine();
		// engine1.cylinder = 4;
		// car.ChangeEngine(engine1);
		// car.Start();


		Lamp newLamp = new();
		Engine newEngine = new();
		ElectricEngine electricEngine = new();
		Car newCar = new Car(electricEngine,newLamp);
		newCar.Start();
	}
}