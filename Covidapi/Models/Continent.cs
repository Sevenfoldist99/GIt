using System.Collections.Generic;

namespace Covidapi.Models
{
    public class Continent : AreaGeografica
    {
        public string NomeContinent { get; set; }
        public List<City> Cities { get; internal set; }
        public List<Country> Countries { get; internal set; }

    }
}
