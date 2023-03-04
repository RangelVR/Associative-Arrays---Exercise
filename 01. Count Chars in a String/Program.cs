string text = Console.ReadLine();

var characters = new Dictionary<char, int>();

foreach (var ch in text)
{
	if (ch == ' ')
	{
		continue;
	}

	if (!characters.ContainsKey(ch))
	{
		characters.Add(ch, 0);
	}

	characters[ch]++;
}

foreach (var ch in characters)
{
	Console.WriteLine($"{ch.Key} -> {ch.Value}");
}

