using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You invented a new groundbreaking technology to predict the weather, using numerology.
You will be given a number from the console and with it, you can predict tomorrow’s weather.
Your system works in the following way:
- If the number can fit in sbyte (for C#) or byte (for Java) – the weather will be “Sunny”
- If the numbers can fit in int – the weather will be “Cloudy”
- If the number fits in long – the weather will be “Windy”
- If it is floating point number – the weather will be “Rainy”
Always print the smallest possible option.
*/

namespace WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            string weather = null;
            if (number % 1 != 0)
            {
                weather = "Rainy";
            }
            else
            {
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    weather = "Sunny";
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    weather = "Cloudy";
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    weather = "Windy";
                }
            }
            Console.WriteLine(weather);
        }
    }
}
