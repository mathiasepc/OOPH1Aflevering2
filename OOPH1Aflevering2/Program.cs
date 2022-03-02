//Vi har valgt ikke at bruge nogen exception handler andet end i vores switch da det er hardcoded data.

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
            Console.WriteLine("The typed format is wrong try agian. Press enter to continue");
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
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (c.SchoolingName == SchoolingCategory.Programmingcourse && temp.Contains("programming"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (c.SchoolingName == SchoolingCategory.Supportcourse && temp.Contains("server"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (c.SchoolingName == SchoolingCategory.infrastructure && temp.Contains("ethernet"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Teacher:");

        c.Teachers.Sort();
        foreach (var item in c.Teachers)
        {
            if (c.SchoolingName == item.UddannelsesLinje)
            {
                if (item.FullName == "Niels Olsen")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (item.FullName == "Bo Hansen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{item.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{item.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{item.FullName}");
            }
        }

        Console.ReadKey();
    }
    Console.Clear();
}