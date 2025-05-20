namespace LockObject;

public static class Demo
{
	private static readonly object _lockOld = new();
	private static readonly Lock _lockNew = new();

	public static void Run()
	{
		lock (_lockOld)  // = Monitor.Enter(_lockOld), Monitor.Exit(_lockOld)
		{
			Console.WriteLine("Locked");
		}


		// new optimized Lock class (EnterScope + Dispose)
		using (_lockNew.EnterScope())
		{
			Console.WriteLine("Locked");
		}


		// C# 13 support for lock keyword with Lock object
		lock (_lockNew)  // = using (_lock.EnterScope()) { ... }
		{
			Console.WriteLine("Locked");
		}
	}
}

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#new-lock-object
// https://github.com/dotnet/csharplang/blob/main/proposals/lock-object.md
// https://github.com/dotnet/runtime/issues/34812 - Add first class System.Threading.Lock type
// "Locking on any class has overhead from the dual role of the syncblock as both lock field and hashcode et al. "
// "Adding a first class lock type that didn't allow alternative uses and only acted as a lock would allow for a simpler and faster lock as well as be less ambiguous on type and purpose in source code."
// https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Threading/Lock.cs