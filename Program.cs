namespace CodeSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            var snips = new Snippets();

            Days day = Days.None;
            switch(DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    day = Days.Monday;
                    break;
                case DayOfWeek.Tuesday:
                    day = Days.Tuesday;
                    break;
                case DayOfWeek.Wednesday:
                    day = Days.Wednesday;
                    break;
                case DayOfWeek.Thursday:
                    day = Days.Thursday;
                    break;
                case DayOfWeek.Friday:
                    day = Days.Friday;
                    break;
                default:
                    day = Days.None;
                    break;
            } 

            Console.WriteLine("A. Use enums");
            Console.WriteLine("B. Switch using enums");
            Console.WriteLine("C. Use generic class");
            Console.WriteLine("D. Use generic method");
            Console.WriteLine("E. Create interface events");
            Console.WriteLine("\nEnter option:");
            var option = Console.ReadLine();

            switch(option?.ToUpper())
            {
                case "A":
                    snips.FlagsEnumExample();
                    break;
                case "B":
                    snips.SwitchEnumExample(day);
                    break;
                case "C":
                    Test<int> test1 = new Test<int>(7);
                    test1.Write();
                    
                    Test<string> test2 = new Test<string>("cats");
                    test2.Write();
                    break;
                case "D":
                    List<bool> list1 = snips.GetInitializedList(true, 5);
                    List<string> list2 = snips.GetInitializedList<string>("Perls", 3);
                    foreach (bool item in list1)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in list2)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case "E":
                    var dictionary = new Dictionary<string, IValue>();
                    dictionary.Add("cat1.png", new Image());
                    dictionary.Add("image1.png", new Image());
                    dictionary.Add("home.html", new Content());
                    
                    // Look up interface objects and call implementations.
                    IValue value;
                    if (dictionary.TryGetValue("cat1.png", out value))
                    {
                        value.Render(); // Image.Render
                    }
                    if (dictionary.TryGetValue("home.html", out value))
                    {
                        value.Render(); // Content.Render
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }  
        }
        
    }
}
