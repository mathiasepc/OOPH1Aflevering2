//OOPH1 Eksamen

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

    Console.WriteLine("Pick: 1, 2 or 3");

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
            Console.WriteLine("The typed format is wrong try again. Press enter to continue");
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
            Console.WriteLine(" the following extension.");
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
        foreach (string displayCourseExtension in course.SchoolingCourses)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (course.SchoolingName == SchoolingCategory.Programmingcourse && displayCourseExtension.Contains("programming"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{displayCourseExtension}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else if (course.SchoolingName == SchoolingCategory.Supportcourse && displayCourseExtension.Contains("server"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{displayCourseExtension}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (course.SchoolingName == SchoolingCategory.infrastructure && displayCourseExtension.Contains("ethernet"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{displayCourseExtension}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{displayCourseExtension}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Teacher:");

        course.Teachers.Sort();
        foreach (var displayName in course.Teachers)
        {
            if (course.SchoolingName == displayName.UddannelsesLinje && displayName.FullName == "Niels Olsen")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{displayName.FullName}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (course.SchoolingName == displayName.UddannelsesLinje && displayName.FullName == "Bo Hansen")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{displayName.FullName}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (course.SchoolingName == displayName.UddannelsesLinje && displayName.FullName == "Ole Nielsen")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{displayName.FullName}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{displayName.FullName}");
            }
        }
        Console.ReadKey();
    }
    Console.Clear();
}