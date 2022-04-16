import requests, json
import math
import pytz
from datetime import datetime

API_KEY = "238d2ea9bbcc36ddb60ea4b143d8c391"    # Our API Key for OpenWeatherMapAPI

zipcode = open("ZipCode.txt")   # Gets Zip Code File
ZIP_CODE = zipcode.readline()

countrycode = open("CountryCode.txt")   # Gets Country Code File
COUNTRY_CODE = countrycode.readline()

# Main API URL Code
MAIN_URL = f"http://api.openweathermap.org/data/2.5/weather?zip={ ZIP_CODE },{ COUNTRY_CODE }&appid={ API_KEY }&units=imperial"

# OpenWeatherMapAPI Main Response Variable
response = requests.get(MAIN_URL)

# Initial Response Check
if response.status_code == 200:

    # Data Variables
    data = response.json()
    
    coordinates = data['coord']
    lon = coordinates['lon']
    lat = coordinates['lat']
    
    report = data['weather']
    description = report[0]['description']
    
    main = data['main']
    temp = main['temp']
    #humidity = main['humidity']
    #pressure = main['pressure']

    wind = data['wind']
    speed = wind['speed']
    degree = wind['deg']


    # Write Data to each Corresponding txt File
    with open("pythonLon.txt", "w") as longitude:
        longitude.writelines(str(lon))
    
    with open("pythonLat.txt", "w") as latitude:
        latitude.writelines(str(lat))

    with open("temperature.txt", "w") as temperature:
        temperature.writelines(str(math.floor(temp)))

    with open("WindSpeed.txt", "w") as windspeed:
        windspeed.writelines(str(math.floor(speed)))

    with open("WeatherDescription.txt", "w") as desc:
        desc.writelines(description)

    with open("CityName.txt", "w") as cityname:
        cityname.writelines(data['name'])

    with open("TimezoneTime.txt", "w") as timezonetime:
        tz_IN = pytz.timezone('US/St.Louis')
        datetime_IN = datetime.now(tz_IN)
        timezonetime.writelines(datetime_IN.strftime("%H:%M"))
    
def closeFiles():
    longitude.close()
    latitude.close()
    temperature.close()
    windspeed.close()
    desc.close()
    cityname.close()
    zipcode.close()
    countrycode.close()
    timezonetime.close()

    # Close Out all the Opened Files
    closeFiles()

    
