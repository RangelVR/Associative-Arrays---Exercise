using System.Security.Cryptography.X509Certificates;

int numOfStudents = int.Parse(Console.ReadLine());

var students = new Dictionary<string, List<double>>();

for (int i = 0; i < numOfStudents; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<double>());
    }

    students[name].Add(grade);
}

foreach (var name in students)
{
    if (name.Value.Average() >= 4.50)
    {
        Console.WriteLine($"{name.Key} -> {name.Value.Average():f2}");
    }
}


//foreach (var name in students.Where(grade => grade.Value.Average() >= 4.50))
//{
//    Console.WriteLine($"{name.Key} -> {name.Value.Average():f2}");
//}


//students = students.Where(grade => grade.Value.Average() >= 4.50).ToDictionary(x => x.Key, x => x.Value);
//foreach (var name in students)
//{
//    Console.WriteLine($"{name.Key} -> {name.Value.Average():f2}");
//}



