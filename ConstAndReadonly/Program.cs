class Car{
	public readonly int year;
	public const string brand = "Toyota" ;
	public Car(int year) {
		this.year = year;
	}
}
class Program{
	static void Main() {
		Car car;
		car = new Car(2008);
		car = new Car(2009);
	}
}
