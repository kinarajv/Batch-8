

class Program //Class //PascalCase
{
	static void Main() //Methode / Function
	{
		Jarot jarot = new Jarot();
		Yanto yanto = new Yanto();
		Joni joni = new Joni();
		int x = 3;
		string y = "Hello";
		Cimol kucingku = new Cimol();
		kucingku.Meow();
		kucingku.gender = "male";
		kucingku.age = 2;
		kucingku.species = "domestic";

		string myResult = kucingku.gender;
		Console.WriteLine(myResult);
		Console.WriteLine(kucingku.gender);

		kucingku.Eat("nasi");
	}
}
