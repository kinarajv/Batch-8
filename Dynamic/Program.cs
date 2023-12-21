class Program
{
	static void Main() {
		//Forbidden
		dynamic a = 3;
		a = 4;
		a = true;
		a = false;
		a = new Car();
		a = "hello";

		Console.WriteLine(a);
		a.Save();
		a.Simpan();
		a.NitipPakRT();
		a.Pergi();
	}
}
class Car { 
}