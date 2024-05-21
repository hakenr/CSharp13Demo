using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitIndexAccess;

public static class Demo
{
	public static void Run()
	{
		// C# 12
		var f = new Foo
		{
			Buffer =
			{
				[4] = 1,
				[3] = 2,
				[2] = 3,
				[1] = 4,
				[0] = 5,
			}
		};

		// C# 13 - The implicit "from the end" index operator, ^,
		// is now allowed in an object initializer expression.
		var f2 = new Foo
		{
			Buffer =
			{
				[^1] = 1,
				[^2] = 2,
				[^3] = 3,
				[^4] = 4,
				[^5] = 5,
			}
		};

	}


	public class Foo
	{
		public byte[] Buffer { get; set; } = new byte[5];
	}
}
