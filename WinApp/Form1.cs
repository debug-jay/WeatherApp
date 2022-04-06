using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting.Hosting;

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

            // Variables that well be working with for our Calls
            var API_KEY = "238d2ea9bbcc36ddb60ea4b143d8c391";
            var TIMEZONE_API_KEY = "meEeN6N8s13UQyrsWm31DJYlVa7SITZoPRS2eLQAafygLX1RaHg3tfhf8MIhFWOS";
            string[] ZIP_CODE = { $"{txt_ZipCode.Text}" };

            // Check if our Entered Country code is nothing, or has a country entered. if it doesnt, its defaulted to "US"
            if(txt_CountryCode.Text == "")
            {
                txt_CountryCode.Text = "US";
            }
            string[] COUNTRY_CODE = { $"{txt_CountryCode.Text}" };
            var CITY_NAME = txt_CityName.Text;  // Current Displayed City of Entered ZipCode

            // OpenWeatherMapAPI & Zippo API calls
            var MAIN_URL = $"http://api.openweathermap.org/data/2.5/weather?zip={ZIP_CODE[0]},{COUNTRY_CODE[0]}&appid={API_KEY}&units=imperial";
            var ZIPPO_URL = $"http://api.zippopotam.us/{ COUNTRY_CODE[0] }/{ ZIP_CODE[0] }";
            var TIMEZONE_URL = $"https://www.zipcodeapi.com/rest/{ TIMEZONE_API_KEY }/info.json/{ ZIP_CODE[0] }/degrees";

            // OpenWeatherMapAPI Request and Client
            var request = new RestRequest(MAIN_URL);
            var client = new RestClient(MAIN_URL);

            // Zippo Request And Client
            var zippo_request = new RestRequest(ZIPPO_URL);
            var zippo_client = new RestClient(ZIPPO_URL);

            // ZipCodeAPI Request and Client
            var timezone_request = new RestRequest(TIMEZONE_URL);
            var timezone_client = new RestClient(TIMEZONE_URL);


            if (request != null && zippo_request != null && timezone_request != null)   // Check if our requests are valid
            {
                var response = client.ExecuteGetAsync(request).Result;
                var zippo_response = zippo_client.ExecuteGetAsync(zippo_request).Result;
                var timezone_response = timezone_client.ExecuteGetAsync(timezone_request).Result;
                
                if (response.IsSuccessful == false
                    || zippo_response.IsSuccessful == false
                    || timezone_response.IsSuccessful == false)     // Check if our responses are valid
                {
                    MessageBox.Show("ERROR");
                }
                else    // If our repsonses are Valid this will be called
                {
                    // the 'Getter' for the Entered Zip Code's Weather Conditions
                    Weather.root root = JsonConvert.DeserializeObject<Weather.root>(response.Content.ToString());

                    // the 'Getter' for the Entered Zip Code's Country & State
                    StateClass.root state_root = JsonConvert.DeserializeObject<StateClass.root>(zippo_response.Content.ToString());

                    // the 'Getter' for the Timezone of Entered Zip Code
                    TimeZone.root timezone_root = JsonConvert.DeserializeObject<TimeZone.root>(timezone_response.Content.ToString());

                    
                    
                    // Read Location Coordinates From Python File
                    try
                    {
                        string[] lon = { $"{ root.coord.lon }" };
                        string[] lat = { $"{ root.coord.lat }" };

                        // Set Current Longitude & Latitude
                        SetCoordinates(ZIP_CODE[0], COUNTRY_CODE[0]);   // Set Coordinates in Text Boxes (Specifically)
                        
                        // More to Come
                        
                    }
                    catch (Exception ex)
                    {
                        txt_Longitude.Text = ex.Message.ToString();
                        txt_Latitude.Text = ex.Message.ToString();
                    }



                    // Set City Name
                    txt_CityName.Text = $"{root.name}";

                    // Set Temp and Weather Description
                    txt_Temp.Text = $"{Math.Floor(root.main.temp)}°F";
                    txt_Description.Text = $"{root.weather[0].description}";

                    // Set Current Date And Time
                    txt_CURRENT_DATE.Text = DateTime.Today.ToString("MM/dd/yyyy");
                    txt_UTC_TIME.Text = DateTime.Now.ToString("h:mm:ss tt");


                    // Set Current Country And State
                    txt_Country.Text = state_root.country_abbreviation.ToString();
                    txt_State.Text = $"{state_root.places[0].state_abbreviaton}";

                    // Set Current TimeZone of Entered ZipCode
                    txt_TimeZone.Text = $"{timezone_root.timezone.timezone_abbr}";


                    // These Functions are Declared in the "Form1.Designer.cs" file
                    getBackround();     
                    DeleteFiles();      
                    
                }
            } 
        }

        
    }
}