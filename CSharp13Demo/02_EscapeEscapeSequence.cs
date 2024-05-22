namespace EscapeEscapeSequence;

public class Demo
{
	public static void Run()
	{
		// C# 12
		Console.WriteLine("This is a character literal for ESCAPE character: \u001b");
		Console.WriteLine("This is a character literal for ESCAPE character: \x1b");

		// C# 13
		Console.WriteLine("This is a character literal for ESCAPE character: \e");
	}
}
