namespace Day03;

public class Cat : Animal
{
	public string colour;
	public Cat(int age, string name, string colour) : base(age, name)
	{
		this.name = name;
		this.age = age;
		this.colour = colour;
	}
}
