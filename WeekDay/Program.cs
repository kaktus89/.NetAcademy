namespace WeekDayCounter
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello write a number and press ENTER to get a day of the week");
            var dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine(DayOfWeek.Monday);
                    break;
                case 2:
                    Console.WriteLine(DayOfWeek.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(DayOfWeek.Wednesday);
                    break;
                case 4:
                    Console.WriteLine(DayOfWeek.Thursday);
                    break;
                case 5:
                    Console.WriteLine(DayOfWeek.Friday);
                    break;
                case 6:
                    Console.WriteLine(DayOfWeek.Saturday);
                    break;
                case 7:
                    Console.WriteLine(DayOfWeek.Sunday);
                    break;
                default:
                    Console.WriteLine("Next time type a number between 1 and 7");
                    break;
            }
        }
    }
}