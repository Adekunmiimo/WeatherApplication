using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weatherapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "47ea9a67954d2a5494312d32b35289a2";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    LabCondition.Text = Info.weather[0].main;
                    LabDetail.Text = Info.weather[0].description;
                    LabSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                    LabSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                    LabWindSpeed.Text = Info.wind.speed.ToString();
                    LabPressure.Text = Info.main.pressure.ToString();
                }
                catch (WebException ex)
                {
                    // Handle the exception
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;

        }

    }
}
