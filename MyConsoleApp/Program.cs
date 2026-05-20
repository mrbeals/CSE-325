DateTime datetime1 = DateTime.Now;
DateTime christmas = new DateTime(2026, 12, 25);
TimeSpan untilChristmas = christmas - datetime1;
Console.WriteLine("Hello, World!");



Console.WriteLine($"The time is {datetime1}");
Console.WriteLine($"There are {untilChristmas.Days} days until Christmas");