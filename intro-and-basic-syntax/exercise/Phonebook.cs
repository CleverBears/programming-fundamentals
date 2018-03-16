using System;
using System.Collections.Generic;

class Phonebook
{
	static void Main()
	{
		var dict = new Dictionary<string, string>();

		while (true)
		{
			var inp = Console.ReadLine().Split(' ');

			switch (inp[0])
			{
				case "A":
					if (dict.ContainsKey(inp[1]))
					{
						dict[inp[1]] = inp[2];
					}
					else
					{
						dict.Add(inp[1],inp[2]);
					}
					break;
				case "S":
					if (dict.ContainsKey(inp[1]))
					{
						Console.WriteLine($"{inp[1]} -> {dict[inp[1]]}");
					}
					else
					{
						Console.WriteLine($"Contact {inp[1]} does not exist.");
					}
					break;
				case "END":
					return;
				default:
					break;
			}
		}
	}
}
