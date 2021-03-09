namespace OpenWeather.API.DTO
{
    public class OpenWeatherEntityModel
    {
        public string visibility { get; set; }
        public string dt { get; set; }
        public string timezone { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cod { get; set; }

        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; } 
        }

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
        }

        public class clouds
        {
            public double all { get; set; }
        }

        public class sys
        {
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; }
            public string sunrise { get; set; }
            public string sunset { get; set; }
        }
    }
}
