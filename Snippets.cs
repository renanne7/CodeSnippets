namespace CodeSnippets
{
    public class Snippets
    {
        public void FlagsEnumExample()
        {
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);
            // Monday, Wednesday, Friday

            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            // Join a meeting by phone on Friday

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            // Is there a meeting on Tuesday: False

            var a = (Days)37;
            Console.WriteLine(a);
            // Monday, Wednesday, Saturday

            Days day = Days.Friday;
            Console.WriteLine($"Integral value of {day} is {(int)day}");
            //Integral value of Friday is 16
        }
        public void SwitchEnumExample(Days day)
        {
            switch(day)
            {
                case Days.Monday:
                {
                    Console.WriteLine($"{Days.Monday} blues");
                    break;
                }
                case Days.Tuesday:
                {
                    Console.WriteLine($"{Days.Tuesday} crying");
                    break;
                }
                case Days.Wednesday:
                {
                    Console.WriteLine($"{Days.Wednesday} half awake");
                    break;
                }
                case Days.Thursday:
                {
                    Console.WriteLine($"{Days.Wednesday} maximum energy");
                    break;
                }
                case Days.Friday:
                {
                    Console.WriteLine($"{Days.Friday} party");
                    break;
                }
                default: break;
            }
        }
        public List<T> GetInitializedList<T>(T value, int count)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
            return list;
        }
    }
}