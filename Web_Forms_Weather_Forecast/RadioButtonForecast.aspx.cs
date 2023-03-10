using Web_Forms_Weather_Forecast.APISimulation.ForecastGenerator;
using System;
using System.Collections.Generic;
using Web_Forms_Weather_Forecast.APISimulation.Models;

namespace Web_Forms_Weather_Forecast
{
    public partial class RadioButtonForecast : System.Web.UI.Page
    {
        protected void GetForecast(object sender, EventArgs e)
        {
            ForecastList.Items.Clear();

            var days = int.Parse(RBList.SelectedValue);
            var includeFeelings = ChBFeelings.Checked;

            var forecast = Generator.GenerateForecast(days);

            switch (includeFeelings)
            {
                case true:
                    AddForecastFeelings(forecast);
                    break;

                case false:
                    RemoveForecastFeelings(forecast);
                    break;
            }
        }
        protected void AddForecastFeelings(List<WeatherForecastViewModel> forecast)
        {
            if (forecast.Count == 1)
            {
                ForecastList.Items.Add($"Temperature: {forecast[0].Temperature}\tFeels {forecast[0].Feelings}");
            }
            else
            {
                foreach (var item in forecast)
                {
                    ForecastList.Items.Add($"Day {item.DayNumber}:\tTemperature: {item.Temperature}\tFeels {item.Feelings}");
                }
            }
        }

        protected void RemoveForecastFeelings(List<WeatherForecastViewModel> forecast)
        {
            if (forecast.Count == 1)
            {
                ForecastList.Items.Add($"Temperature: {forecast[0].Temperature}");
            }
            else
            {
                foreach (var item in forecast)
                {
                    ForecastList.Items.Add($"Day {item.DayNumber}:\tTemperature: {item.Temperature}");
                }
            }
        }
    }
}