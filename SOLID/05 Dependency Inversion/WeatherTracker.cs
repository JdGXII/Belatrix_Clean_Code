using System;

namespace SOLID._05_Dependency_Inversion
{
    public class WeatherTracker
    {
        String currentConditions;
        private IAlertable _alerter;

        public void SetCurrentConditions(String weatherDescription)
        {
            this.currentConditions = weatherDescription;
            SetAlertMedium();
            SendAlert();
        }

        private void SetAlertMedium()
        {
            if (currentConditions == "rainy")
                _alerter = new Phone();
            if (currentConditions == "sunny")
                _alerter = new Emailer();
        }

        private void SendAlert()
        {
            Console.WriteLine(_alerter.generateWeatherAlert(currentConditions));
        }
    }

}

