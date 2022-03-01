SchoolingCategory school = new();

Courses c = new(school);

Console.WriteLine("pick education course");
Console.WriteLine("1: Programmering course");
Console.WriteLine("2: Support course");
Console.WriteLine("3: Infrastructur course");

Console.WriteLine("Vælg: 1, 2 eller 3");

var choice = Console.ReadKey();

switch (choice.Key)
{
    case ConsoleKey.D1:
        c.SchoolingName = SchoolingCategory.Programmeringslinje;
        c.SetCourses();
        break;
    case ConsoleKey.D2:
        c.SchoolingName = SchoolingCategory.Supportlinje;
        c.SetCourses();
        break;
    case ConsoleKey.D3:
        c.SchoolingName = SchoolingCategory.Infrastrukturlinje;
        c.SetCourses();
        break;
    default:
        Console.WriteLine("The typed format is wrong. Try agian.");
        break;
}

Console.Clear();

foreach (string temp in c.SchoolingCourses)
    Console.WriteLine($"{temp}");
Console.WriteLine("-----------------");

foreach (string temp in c.Courses)
    Console.WriteLine($"{temp}");
