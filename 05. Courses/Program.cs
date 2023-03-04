
var courses = new Dictionary<string, List<string>>();

while (true)
{
    string[] inputInfo = Console.ReadLine()
    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

    string courseName = inputInfo[0];

    if (courseName == "end")
    {
        break;
    }

    string student = inputInfo[1];


    if (!courses.ContainsKey(courseName))
    {
        courses.Add(courseName, new List<string>());
    }

    courses[courseName].Add(student);
}

foreach (var courseName in courses)
{
    Console.WriteLine($"{courseName.Key}: {courseName.Value.Count}");

    foreach (var student in courseName.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}