using System.Collections.Generic;
using System.ServiceModel;
using Weather_Forecast_Models;

namespace WCF_Service_Weather_Forecast
{
    [ServiceContract]
    public interface IForecastGenerationService
    {
        [OperationContract]
        List<WeatherForecastViewModel> GenerateForecast(int numberOfDays);
    }
}
