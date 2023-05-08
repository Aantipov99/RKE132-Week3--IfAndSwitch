
int WeekDay =Convert.ToInt32 (DateTime.Now.DayOfWeek);

if(WeekDay == 0)
{
    Console.WriteLine("It is a Sunday!");
 } 
else if(WeekDay == 1)
{
    Console.WriteLine("It is a Monday!");
}
else if (WeekDay == 2)
{
    Console.WriteLine("It is Tuesday!");
}
else if (WeekDay == 3)
{
   Console.WriteLine("It is a Wednesday!");
}
else if (WeekDay == 4)
{
    Console.WriteLine("It is a Thursday!");
}
else if (WeekDay == 5)
{
    Console.WriteLine("It is a Friday!");
}
else
{
    Console.WriteLine("It is a Saturday!");
}