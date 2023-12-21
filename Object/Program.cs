class Program
{
	static void Main()
	{
		float result = (float)Adder(3.0f, 2.0f);

		//Boxing
		int a = 3;
		object x = a;
		//Unboxing
		int resultint = (int)x;
	}
	static object Adder(object a, object b)
	{
		//Pattern Matching
		if (a is float myFloatA && b is float myFloatB)
		{
			return myFloatA + myFloatB;
		}
		if (a is string myStringA && b is string myStringB)
		{
			return myStringA + myStringB;
		}
		return null;
	}
}
class Car { }