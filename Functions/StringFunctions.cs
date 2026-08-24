public static class StringFunctions
{
	public static string Reverse(string input)
	{
		char[] characters = input.ToCharArray();
		Array.Reverse(characters);
		return new string(characters);
	}
	public static void PrintLineByLine(string input)
	{
		foreach (char c in input)
		{
			Console.WriteLine(c);
		}
	}
}
