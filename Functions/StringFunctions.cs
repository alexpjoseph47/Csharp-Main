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
	public static void stringcount()
	{
		Console.Write("Enter a string: ");
		string input = Console.ReadLine() ?? string.Empty;
		Dictionary<char, int> count = new Dictionary<char, int>();
		int s = input.Length;
		for(int i = 0; i < s; ++i)
		{
			char c=input[i];
			if (count.ContainsKey(c))
			{
				count[c]++;
			}
			else
			{
				count.Add(c,1);
			}
			
		}
		foreach(var item in count){
				
				Console.WriteLine(item.Key +" : "+ item.Value);
			}
		
	}
}
