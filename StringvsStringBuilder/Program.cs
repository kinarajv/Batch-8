using System.Diagnostics;
using System.Text;
class Program{
	static void Main() {
		int iteration = 100000;
		string a = String.Empty;
		Stopwatch sw = new Stopwatch();
		sw.Start();
		for(int i = 0; i < iteration; i++) {
			a += "a";
			a += "b";
			a += "c";
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
		StringBuilder sb = new StringBuilder();
		sw.Reset();
		for (int i = 0; i < iteration; i++)
		{
			sb.Append("a");
			sb.Append("b");
			sb.Append("c");
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
	}
}