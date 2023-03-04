var resources = new Dictionary<string, int>();

while (true)
{
    string item = Console.ReadLine();

	if (item == "stop")
	{
		break;
	}

	int quantity = int.Parse(Console.ReadLine());

	if (!resources.ContainsKey(item))
	{
		resources.Add(item, 0);
	}

    resources[item] += quantity;
}

foreach (var item in resources)
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}