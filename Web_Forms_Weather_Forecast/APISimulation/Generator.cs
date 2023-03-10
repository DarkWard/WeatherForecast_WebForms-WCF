using System;
using System.Collections.Generic;
using Web_Forms_Weather_Forecast.APISimulation.Models;

namespace Web_Forms_Weather_Forecast.APISimulation.ForecastGenerator
{
    public class Generator
    {
        public static List<WeatherForecastViewModel> GenerateForecast(int numberOfDays)
        {
            var result = new List<WeatherForecastViewModel>();
            var random = new Random();

            for (int i = 0; i < numberOfDays; i++)
            {
                var temperature = random.Next(-20, 30) + random.NextDouble();
                temperature = Math.Round(temperature, 1);

                result.Add(new
                    WeatherForecastViewModel
                {
                    DayNumber = i + 1,
                    Temperature = temperature,
                    Feelings = GenerateFeeling(temperature),
                });
            }

            return result;
        }

        public static string GenerateFeeling(double temperature)
        {
            if (temperature < -10)
            {
                return "Freezing";
            }
            else if (temperature <= 0)
            {
                return "Chilly";
            }
            else if (temperature > 0 && temperature <= 10)
            {
                return "Cool";
            }
            else if (temperature > 10 && temperature < 10)
            {
                return "Warm";
            }
            else
            {
                return "Hot";
            }
        }
    }
}
