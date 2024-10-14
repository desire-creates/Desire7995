while (true)
{
    Console.WriteLine("Enter a date (MM/DD/YYYY) or type 'exit' to quit:");

    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        break;
    }

    if (DateTime.TryParse(input, out DateTime enteredDate))
    {
        DateTime currentDate = DateTime.Now;

        DateTime aprilFools = new DateTime(currentDate.Year, 4, 1);
        if (enteredDate == aprilFools)
        {
            TimeSpan difference = currentDate - aprilFools;
            int daysSinceAprilFools = difference.Days;
            Console.WriteLine($"It has been {daysSinceAprilFools} day(s) since April Fools' Day.");
        }
        else if (enteredDate.Month == 1 && enteredDate.Day == 1)
        {
            DateTime newYear = new DateTime(currentDate.Year + 1, 1, 1);
            TimeSpan difference = newYear - currentDate;
            int daysUntilNewYear = difference.Days;
            Console.WriteLine($"There are {daysUntilNewYear} day(s) left until New Year's Day.");
        }
        else
        {
            // Regular date comparison
            TimeSpan difference = enteredDate - currentDate;
            int daysDifference = difference.Days;

            if (daysDifference > 0)
            {
                Console.WriteLine($"The entered date is {daysDifference} day(s) in the future.");
            }
            else if (daysDifference < 0)
            {
                Console.WriteLine($"The entered date was {Math.Abs(daysDifference)} day(s) ago.");
            }
            else
            {
                Console.WriteLine("The entered date is today.");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid date format. Please try again.");
    }

    Console.WriteLine();
}

Console.WriteLine("Program exited.");
