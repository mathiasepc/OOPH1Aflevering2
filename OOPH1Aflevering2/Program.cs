SchoolingCategory school = new();
List<TECPerson> persons = new();

Course c = new(school);

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Education course");
    Console.WriteLine("1: Programming course");
    Console.WriteLine("2: Support course");
    Console.WriteLine("3: Infrastructur course");

    Console.WriteLine("Pick: 1, 2 eller 3");

    var choice = Console.ReadKey();
    switch (choice.Key)
    {
        case ConsoleKey.D1:
            c.SchoolingName = SchoolingCategory.Programmingcourse;
            c.SetCourses();
            break;
        case ConsoleKey.D2:
            c.SchoolingName = SchoolingCategory.Supportcourse;
            c.SetCourses();
            break;
        case ConsoleKey.D3:
            c.SchoolingName = SchoolingCategory.infrastructure;
            c.SetCourses();
            break;
        default:
            Console.Clear();
            Console.WriteLine("The typed format is wrong. Press enter to try agian.");
            Console.ReadKey();
            break;
    }

    Console.Clear();

    if (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.D2 || choice.Key == ConsoleKey.D3)
    {
        Console.WriteLine($"{c.ToString()}");
        Console.WriteLine("------------------------------------");

        if (c.SchoolingName == SchoolingCategory.Programmingcourse)
        {

            Console.Write("Off all courses have ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Programming");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" with the following extension.");


        }
        else if (c.SchoolingName == SchoolingCategory.Supportcourse)
        {

            Console.Write("Off all courses have ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Support");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" with the following extension.");
        }
        else
        {
            Console.Write("Off all courses have ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Infrastructure");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" with the following extension.");
        }

        Console.WriteLine("------------------------------------");

        foreach (string temp in c.Courses)
            Console.WriteLine($"{temp}");

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Teacher:");
        c.GetTeacher();

        Console.ReadKey();
    }
    Console.Clear();
}