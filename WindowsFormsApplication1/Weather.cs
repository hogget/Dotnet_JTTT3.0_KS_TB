using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    class Weather : IWykonaj
    {
        public double Temp { get; set; }
        public string Message { get; set; }
        public int Stopnie { get; set; }
        public string Miasto { get; set; }

        public Weather(string miasto, int temp)
        {
            Miasto = miasto;
            Temp = temp;
        }

        public override string Wykonaj()
        {
            string json = "http://api.openweathermap.org/data/2.5/weather?q=" + Miasto  + "&APPID=6f9ae208ecaee66e0cee0961a021fa18";
            var textFromFile = (new WebClient()).DownloadString(json);
            JSONWeather.RootObject weather = JsonConvert.DeserializeObject<JSONWeather.RootObject>(textFromFile);

            Temp = weather.main.temp - 273;
            return Temp.ToString();
        }

        public void Wyswietl()
        {
            var Message = $"We {Miasto} jest {Stopnie} stopni";
            MessageBox.Show(Message);
        }
    }
}
