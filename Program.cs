using System;
using System.Collections.Generic;

class Meteo
{
    public string DayOfWeek { get; set; }
    public int Temperature { get; set; }
    public int Precipitation { get; set; }

    public Meteo(string dayOfWeek, int temperature, int precipitation)
    {
        DayOfWeek = dayOfWeek;
        Temperature = temperature;
        Precipitation = precipitation;
    }

    public override string ToString()
    {
        return $"{DayOfWeek}: Температура {Temperature}°C, Опади {Precipitation} мм";
    }
}

class Program
{
    static void Main()
    {
        List<Meteo> days = new List<Meteo>
        {
            new Meteo("День1", -1, 10),
            new Meteo("День2", 2, 5),
            new Meteo("День3", 0, 15),
            new Meteo("День4", -2, 0),
            new Meteo("День5", 3, 20)
        };

        // Виведення списку на екран
        Console.WriteLine("Список днів:");
        foreach (var day in days)
        {
            Console.WriteLine(day);
        }

        // Підрахунок днів з снігом
        int snowDays = 0;
        foreach (var day in days)
        {
            if (day.Temperature == 0 && day.Precipitation > 0)
            {
                snowDays++;
            }
        }
        Console.WriteLine($"\nКількість днів з снігом: {snowDays}");

        // Підрахунок загальної кількості опадів
        int totalPrecipitation = 0;
        foreach (var day in days)
        {
            totalPrecipitation += day.Precipitation;
        }
        Console.WriteLine($"Загальна кількість опадів: {totalPrecipitation} мм");
    }
}


