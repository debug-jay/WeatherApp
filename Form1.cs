using Newtonsoft.Json;
using RestSharp;

namespace WinApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
        }
        
        private async void btn_Main_Click(object sender, EventArgs e)
        {

            var API_KEY = "238d2ea9bbcc36ddb60ea4b143d8c391";
            var ZIP_CODE = txt_ZipCode.Text;
            var COUNTRY_CODE = txt_CountryCode.Text;

            var MAIN_URL = $"https://api.openweathermap.org/data/2.5/weather?zip={ZIP_CODE},{COUNTRY_CODE}&appid={API_KEY}&units=imperial";

            var request = new RestRequest(MAIN_URL);
            var client = new RestClient(MAIN_URL);

            if (request != null)
            {
                var response = client.ExecuteGetAsync(request).Result;
                
                if (response.IsSuccessful == false)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {

                    Weather.root root = JsonConvert.DeserializeObject<Weather.root>(response.Content.ToString());


                    txt_Longitude.Text = $"{root.coord.lon}";
                    txt_Latitude.Text = $"{root.coord.lat}";

                    txt_Temp.Text = $"{Math.Floor(root.main.temp)}°F";

                    txt_Description.Text = $"{root.weather[0].description}";

                    getBackround();
                   
                }
            }
        }

        private void getBackround()
        {
            if (txt_Description.Text == "overcast clouds")
            {
                this.BackgroundImage = Properties.Resources.overcastClouds;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            if (txt_Description.Text == "clear sky")
            {
                this.BackgroundImage = Properties.Resources.clearSky;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
        }

    }
}