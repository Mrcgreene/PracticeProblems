using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class WeatherEnums
    {
        enum daysOfTheWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum forecastTypes { Rain, Cloudy, Snow, Sunny, Windy };

        public void SevenDayForecast()
        {
            //int firstDay = (int)daysOfTheWeek.Sunday;
            //int dayCondition = (int)forecastTypes.Rain;

            Console.WriteLine(daysOfTheWeek.Sunday + " will be " + forecastTypes.Sunny);
            Console.WriteLine(daysOfTheWeek.Monday + " will be " + forecastTypes.Windy);
            Console.WriteLine(daysOfTheWeek.Tuesday + " will be " + forecastTypes.Cloudy);
            Console.WriteLine(daysOfTheWeek.Wednesday + " will have " + forecastTypes.Rain);
            Console.WriteLine(daysOfTheWeek.Thursday + " will have " + forecastTypes.Rain);
            Console.WriteLine(daysOfTheWeek.Friday + " will have " + forecastTypes.Snow);
            Console.WriteLine(daysOfTheWeek.Saturday + " will have " + forecastTypes.Snow);

            Console.ReadLine();
        }
    }
}
