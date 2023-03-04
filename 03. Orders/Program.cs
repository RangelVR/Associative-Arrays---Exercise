
var products = new Dictionary<string, double[]>();

while (true)
{
    string[] itemInfo = Console.ReadLine().Split();

    if (itemInfo[0] == "buy")
	{
		break;
	}
	string itemName = itemInfo[0];
	double price = double.Parse(itemInfo[1]);
	double quantity = double.Parse(itemInfo[2]);

    if (!products.ContainsKey(itemName))
	{
		products.Add(itemName, new double[] { 0, 0 });	
	}

	products[itemName][0] = price;
	products[itemName][1] += quantity;
}

foreach (var item in products)
{
	Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
}