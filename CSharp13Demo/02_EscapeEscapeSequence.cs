﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
