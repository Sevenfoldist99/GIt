using System.Collections.Generic;

namespace Covidapi.Models
{
    public class Country : AreaGeografica
    {
        public string CountryName { get; set; }
        public List<City> Cities { get; internal set; }
    }
}
