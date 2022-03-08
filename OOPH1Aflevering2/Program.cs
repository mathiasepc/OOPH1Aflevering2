// Projekt branch

Course? c = null;
string? errorMessage = null;

while (true)
{
    // ---------------------------------------------------------------------------------------
    // Lager fejl besked i errorMessage parameter hvor de må opstå, og break ud af applikationen.
    // while loop sørger for at applikation starter igen fra starten når man breaker ud af
    // applikationen. Udskriv fejl besked ud til bruger her, så brugeren ved hvorfor applikation
    // må vende tilbage til start igen.
    if (errorMessage != null)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(errorMessage);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;

        errorMessage = null;
    }

    // ---------------------------------------------------------------------------------------
    // Istantiere Course.cs klassen alt efter hvad bruger har valgt af uddannelseslinje.
    // Implementer en fejl besked til bruger hvis bruger vælger forkert.
    Console.WriteLine("Vælg uddannelseslinje: ");
    Console.WriteLine("1) Programmering");
    Console.WriteLine("2) Support");
    Console.WriteLine("3) Infrastruktur");
    Console.WriteLine();
    Console.Write("Vælg 1, 2 eller 3: ");
    try
    {
        switch ((Console.ReadKey()).Key)
        {
            case ConsoleKey.D1:
                c = new(SchoolingCategory.Programmingcourse);
                break;
            case ConsoleKey.D2:
                c = new(SchoolingCategory.Supportcourse);
                break;
            case ConsoleKey.D3:
                c = new(SchoolingCategory.infrastructure);
                break;
            default:
                throw new Exception("Forkert valgt, prøv igen!");
        }
    }
    catch (Exception ex)
    {
        errorMessage = ex.Message;
    }

    // ---------------------------------------------------------------------------------------
    // Går kun vider hvis Course.cs klasse er istantieret.
    // (Er kun istantieret hvis bruger ikke har valgt forkert i bruger select-menu foroven.)
    if (c != null)
    {
        Console.Clear();

        // ---------------------------------------------------------------------------------------
        // Udskriv app's titel 
        Console.WriteLine();
        Console.WriteLine(c.ToString());

        // ---------------------------------------------------------------------------------------
        // Udskriv titel for list af fag inden list af fagene udskrives 
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.Write($"Af alle fag, har");
        if (c.SchoolingName == SchoolingCategory.Programmingcourse) { Console.ForegroundColor = ConsoleColor.Green; }
        else if (c.SchoolingName == SchoolingCategory.Supportcourse) { Console.ForegroundColor = ConsoleColor.Yellow; }
        else { Console.ForegroundColor = ConsoleColor.Red; }
        Console.Write($" {c.SchoolingName} ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("følgende fag vist med");
        if (c.SchoolingName == SchoolingCategory.Programmingcourse)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" grøn:");
        }
        else if (c.SchoolingName == SchoolingCategory.Supportcourse)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" gul:");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" rød:");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("--------------------------------------------------------------------------");

        // ---------------------------------------------------------------------------------------
        // Udskriv selve liste af fagene (Udskrivning skal sættes til at være alfabetisk sortert).
        c.Courses.Sort();
        foreach (string item in c.Courses)
        {
            string? match = c.SchoolingCourses.FirstOrDefault(a => a == item);

            if (match != null)
            {
                if (c.SchoolingName == SchoolingCategory.Programmingcourse) { Console.ForegroundColor = ConsoleColor.Green; }
                else if (c.SchoolingName == SchoolingCategory.Supportcourse) { Console.ForegroundColor = ConsoleColor.Yellow; }
                else { Console.ForegroundColor = ConsoleColor.Red; }

                Console.WriteLine(item);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine(item);
            }
        }

        // ---------------------------------------------------------------------------------------
        // Udskriv liste af lærere (Udskrivning skal sættes til at være alfabetisk sortert).
        Console.WriteLine();
        Console.WriteLine($"Lærer : ");

        if (c.Teachers != null)
            c.Teachers.Sort();

        if (c.Teachers != null)
        {
            foreach (TECPerson teacher in c.Teachers)
            {
                if (teacher.FullName == c.GetTeacher())
                {
                    if (c.SchoolingName == SchoolingCategory.Programmingcourse) { Console.ForegroundColor = ConsoleColor.Green; }
                    else if (c.SchoolingName == SchoolingCategory.Supportcourse) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else { Console.ForegroundColor = ConsoleColor.Red; }

                    Console.WriteLine(teacher.FullName);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(teacher.FullName);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}