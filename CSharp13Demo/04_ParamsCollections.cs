namespace ParamsCollections;

public class Demo
{
	// C# 12 - array type only
	public static void DoSomething(params int[] values) { }

	// C# 13 - "any" collection type/interface + IEnumerable with Add method
	public static void DoSomething2(params List<int> values) { }
	public static void DoSomething3(params Span<int> values) { }
	public static void DoSomething4(params IEnumerable<int> values) { }

	// calling side - same compiler logic as collection expressions
	public static void CallDoSomething()
	{
		DoSomething4(1, 2, 3);
	}
}

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#params-collections
// https://github.com/dotnet/csharplang/blob/main/proposals/params-collections.md
