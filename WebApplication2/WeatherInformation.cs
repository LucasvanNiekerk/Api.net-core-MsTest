using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class WeatherInformation
    {
        private int _id;
        private string _raspberryId;
        private string _temperature;
        private string _humidity;
        private string _timeStamp;

        public WeatherInformation(int id, string raspberryId, string temperature, string humidity, string timeStamp)
        {
            Id = id;
            RaspberryId = raspberryId;
            Temperature = temperature;
            Humidity = humidity;
            TimeStamp = timeStamp;
        }

        public WeatherInformation()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string RaspberryId
        {
            get => _raspberryId;
            set => _raspberryId = value;
        }

        public string Temperature { get => _temperature; set => _temperature = value; }
        public string Humidity { get => _humidity; set => _humidity = value; }
        public string TimeStamp { get => _timeStamp; set => _timeStamp = value; }
    }
}

