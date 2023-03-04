int n = int.Parse(Console.ReadLine());
var parkingUsers = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] cmdArg = Console.ReadLine().Split();
    
    string command = cmdArg[0];
    string user = cmdArg[1];

    if (command == "register")
    {
        if (parkingUsers.ContainsKey(user))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parkingUsers[user]}");
        }
        else
        {
            string licensePlate = cmdArg[2];
            parkingUsers.Add(user, licensePlate);
            Console.WriteLine($"{user} registered {licensePlate} successfully");
        }
    }
    else if (command == "unregister")
    {
        if (!parkingUsers.ContainsKey(user))
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
        else
        {
            parkingUsers.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
    }
}

foreach (var user in parkingUsers)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}
