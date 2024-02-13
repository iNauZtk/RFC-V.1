Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Welcome");
Console.WriteLine();
Console.Write("Today we will obtain your RFC ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Federal Taxpayer Registry");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Click to continue");
Console.ReadKey();
Console.Clear();
String[] RFC = new string[7];
Console.ForegroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
do
{
    Console.WriteLine("Personal Information");
    Console.Write("Enter your name: ");
    Console.ForegroundColor = ConsoleColor.Green;
    RFC[0] = Console.ReadLine();
    Console.WriteLine();
    foreach (char LETTER in RFC[0])
    {
        if (char.IsNumber(LETTER))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numbers are not accepted in this field");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            RFC[0] = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(RFC[0]));
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Enter your last name: ");
    Console.ForegroundColor = ConsoleColor.Green;
    RFC[1] = Console.ReadLine();
    Console.WriteLine();
    foreach (char LETTER in RFC[1])
    {
        if (char.IsNumber(LETTER))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numbers are not accepted in this field");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            RFC[1] = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(RFC[1]));
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Enter your mother's maiden name: ");
    Console.ForegroundColor = ConsoleColor.Green;
    RFC[2] = Console.ReadLine();
    Console.WriteLine();
    foreach (char LETTER in RFC[2])
    {
        if (char.IsNumber(LETTER))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numbers are not accepted in this field");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            RFC[2] = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(RFC[2]));
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.WriteLine();
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Enter your date of birth");
Console.Write("Day: ");
Console.ForegroundColor = ConsoleColor.Green;
RFC[3] = Convert.ToString(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Month: ");
Console.ForegroundColor = ConsoleColor.Green;
RFC[4] = Convert.ToString(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Year: ");
Console.ForegroundColor = ConsoleColor.Green;
RFC[5] = Convert.ToString(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ReadKey();
Console.Clear();
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Name: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[0]);
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Last Name: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[1]);
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Mother's Maiden Name: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[2]);
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Date of Birth: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[3] + " / " + RFC[4] + " / " + RFC[5]);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Your RFC is: ");
RFC[1] = RFC[1].Substring(0, 2);
RFC[1] = RFC[1].Replace("a", "x");
RFC[1] = RFC[1].Replace("e", "x");
RFC[1] = RFC[1].Replace("i", "x");
RFC[1] = RFC[1].Replace("o", "x");
RFC[1] = RFC[1].Replace("u", "x");
RFC[1] = RFC[1].ToUpper();
RFC[2] = RFC[2].Substring(0, 1);
RFC[2] = RFC[2].ToUpper();
RFC[0] = RFC[0].Substring(0, 1);
RFC[0] = RFC[0].ToUpper();
RFC[5] = RFC[5].Substring(2, 2);
RFC[6] = RFC[1] + RFC[2] + RFC[0] + RFC[5] + RFC[4] + RFC[3];
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[6]);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("This is not a complete RFC as it needs a homoclave");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();