using System.ComponentModel.DataAnnotations;

namespace weather_app_crewin.Models
{
    public class weather_info
    {
        [Key]
        public int id { get; set; }

        public string temperature { get; set; }

        public string city_name { get; set; }

    }
}
