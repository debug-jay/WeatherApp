import requests, json

API_KEY = "238d2ea9bbcc36ddb60ea4b143d8c391"

zipcode = open("ZipCode.txt")
ZIP_CODE = zipcode.readline()

countrycode = open("CountryCode.txt")
COUNTRY_CODE = countrycode.readline()


MAIN_URL = f"http://api.openweathermap.org/data/2.5/weather?zip={ ZIP_CODE },{ COUNTRY_CODE }&appid={ API_KEY }&units=imperial"


response = requests.get(MAIN_URL)

if response.status_code == 200:
    data = response.json()
    
    coordinates = data['coord']
    lon = coordinates['lon']
    lat = coordinates['lat']
    
    report = data['weather']
    
    
    main = data['main']
    
    temperature = main['temp']
    
    humidity = main['humidity']
    
    pressure = main['pressure']

    with open("pythonLon.txt", "w") as longitude:
        longitude.writelines(str(lon))
    

    with open("pythonLat.txt", "w") as latitude:
        latitude.writelines(str(lat))
    
    longitude.close()
    latitude.close()
    zipcode.close()
    countrycode.close()