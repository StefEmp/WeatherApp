using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    class Weather
    {
        public Object getWeatherForecast()
        {
            string url = "https://api.edamam.com/search?q=apple&app_id=a4e57804&app_key=5cd9b1cf4de086d7718f9f95c16ccdb7";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}