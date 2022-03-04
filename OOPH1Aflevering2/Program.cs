//Vi har valgt ikke at bruge nogen exception handler andet end i vores switch da det er hardcoded data.

SchoolingCategory school = new();
List<TECPerson> persons = new();

Course course = new(school);

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
            course.SchoolingName = SchoolingCategory.Programmingcourse;
            course.SetCourses();
            break;
        case ConsoleKey.D2:
            course.SchoolingName = SchoolingCategory.Supportcourse;
            course.SetCourses();
            break;
        case ConsoleKey.D3:
            course.SchoolingName = SchoolingCategory.infrastructure;
            course.SetCourses();
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
        Console.WriteLine($"{course.ToString()}");
        Console.WriteLine("------------------------------------");

        if (course.SchoolingName == SchoolingCategory.Programmingcourse)
        {
            Console.Write("Off all courses have ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Programming");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" the following extension.");
        }
        else if (course.SchoolingName == SchoolingCategory.Supportcourse)
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
            Console.WriteLine(" the following extension.");
        }

        Console.WriteLine("------------------------------------");

        course.SchoolingCourses.Sort();
        foreach (string temp in course.SchoolingCourses)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (course.SchoolingName == SchoolingCategory.Programmingcourse && temp.Contains("programming"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else if (course.SchoolingName == SchoolingCategory.Supportcourse && temp.Contains("server"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (course.SchoolingName == SchoolingCategory.infrastructure && temp.Contains("ethernet"))
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

        course.Teachers.Sort();
        foreach (var item in course.Teachers)
        {
            if (course.SchoolingName == item.UddannelsesLinje)
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