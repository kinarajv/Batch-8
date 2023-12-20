class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Animal Make Sound");
	}
}
class Dog : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Bark");
	}
}
class Puppies : Dog 
{
	public override void MakeSound()
	{
		
	}
	
}
class Program
{
	static void Main()
	{
		Dog dog = new Dog();
		dog.MakeSound(); //Bark
		Animal animal = dog;
		animal.MakeSound(); //Bark

		Animal animal2 = new Puppies();
	}
}