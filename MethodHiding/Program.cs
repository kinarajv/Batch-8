class Animal
{
	public void MakeSound()
	{
		Console.WriteLine("Animal Make Sound");
	}
}
class Dog : Animal
{
	public new void MakeSound() {
		Console.WriteLine("Bark");
	}
}
class Program
{
	static void Main()
	{
		Dog dog = new Dog();
		dog.MakeSound(); //Bark
		Animal animal = dog;
		animal.MakeSound(); //Animal MakeSound
	}
}