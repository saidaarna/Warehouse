using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherDLL
{
    public class Hava
    {
        public string get()
        {
            var client = new HttpClient();

            string api = "e02edaf4b35cdf6ec83ba7e06520b828";

            string connection = "https://api.openweathermap.org/data/2.5/weather?lat=40.409264&lon=49.867092&mode=xml&units=metric&lang=az&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var temp = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var havaDurumu = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            var rutubet = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            return "Bakıda Temperatur: " + temp + "; " + havaDurumu + "\n" + "Rütubət: " + rutubet;

        }
    }
}
