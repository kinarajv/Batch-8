

using Day04;

class Program 
{
	static void Main() 
	{
		Cat cat = new Cat();
		cat.Eat("ikan");
		cat.Meow();

		Dog dog = new Dog();
		dog.Eat("tulang");
		dog.Bark();

		Bird bird = new Bird();
		bird.Eat("biji");
		bird.Chirp();
	}
}