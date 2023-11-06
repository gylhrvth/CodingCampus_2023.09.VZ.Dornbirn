namespace DarioLuis.Week06
{
    public class EnumExamples
    {
        public enum WeekDays
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY,
        }
        public static void Start()
        {
            WeekDays w = WeekDays.MONDAY;
            for (int i = 0; i < 7; i++)
            {
                Printname();
                ++w;    
            }
        }
        public static void Printname() 
        {
            WeekDays w = WeekDays.MONDAY;
            Console.WriteLine(w++);
            ++w;
            
        }
    }
}
