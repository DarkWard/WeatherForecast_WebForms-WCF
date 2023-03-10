using System;
using System.Web.UI;
using Web_Forms_Weather_Forecast.ForecastGenerator;

namespace Web_Forms_Weather_Forecast
{
    public partial class _Default : Page
    {
        protected void GetOneDayForecast(object sender, EventArgs e)
        {
            ForecastList.Items.Clear();

            var forecastClient = new ForecastGenerationServiceClient();
            var forecast = forecastClient.GenerateForecast(1);

            ForecastList.Items.Add($"Temperature: {forecast[0].Temperature}\tFeels {forecast[0].Feelings}\n");
        }

        protected void GetSevenDayForecast(object sender, EventArgs e)
        {
            ForecastList.Items.Clear();

            var forecastClient = new ForecastGenerationServiceClient();
            var forecast = forecastClient.GenerateForecast(7);

            foreach (var item in forecast)
            {
                ForecastList.Items.Add($"Day {item.DayNumber}:\tTemperature: {item.Temperature}\tFeels {item.Feelings}\n");
            }
        }

        protected void GetThirtyDaysDayForecast(object sender, EventArgs e)
        {
            ForecastList.Items.Clear();

            var forecastClient = new ForecastGenerationServiceClient();
            var forecast = forecastClient.GenerateForecast(30);

            foreach (var item in forecast)
            {
                ForecastList.Items.Add($"Day {item.DayNumber}:\tTemperature: {item.Temperature}\tFeels {item.Feelings}\n");
            }

        }
    }
}
