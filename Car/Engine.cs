namespace CarComponent;

public class Engine
{
	public int cylinder;
	public virtual void EngineRun() 
	{
		Console.WriteLine($"Engine with {cylinder} Run");
	}
}
