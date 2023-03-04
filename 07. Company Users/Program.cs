var companies = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] cmdArg = input.Split(" -> ");

    string nameCompany = cmdArg[0];
    string iD = cmdArg[1];

    if (!companies.ContainsKey(nameCompany))
    {
        companies.Add(nameCompany, new List<string> { iD });
    }
    else
    {
        if (!companies[nameCompany].Contains(iD))
        {
            companies[nameCompany].Add(iD);
        }
    }

    input = Console.ReadLine();
}

foreach (var company in companies)
{
    Console.WriteLine(company.Key);

    foreach (var iD in company.Value)
    {
        Console.WriteLine($"-- {iD}");
    }
}