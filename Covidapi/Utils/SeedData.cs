using Covidapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Covidapi.Configuration.AreaGeoContext;

namespace Covidapi.Utils
{
    public static class SeedData
    {
        public static async Task SeedDatabase(DatabaseCxt dbCtx)
        {

            List<City> citiesItalia = new List<City>()
            {
                new City() { NomeCity = "Roma", NAbitanti = 28730000, Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Cagliari", NAbitanti = 154083 , Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Torino", NAbitanti = 886837 , Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Firenze", NAbitanti = 382258 , Area ="" , PosizioneGeo = "", NPositivi = 10000 }
            };
            List<City> citiesGermania = new List<City>()
            {
                new City() { NomeCity = "Berlino", NAbitanti = 3645000, Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Amburgo", NAbitanti = 18410000, Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Francoforte", NAbitanti = 753056 , Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Dusseldorf", NAbitanti = 619294  , Area ="" , PosizioneGeo = "", NPositivi = 10000 }
            };
            List<City> citiesFrancia = new List<City>()
            {
                new City() { NomeCity = "Parigi", NAbitanti = 2161000 , Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Lione", NAbitanti = 513275, Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Marsiglia", NAbitanti = 861635 , Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Nizza", NAbitanti = 342522 , Area ="" , PosizioneGeo = "", NPositivi = 10000 }
            };
            List<City> citiesRegnoUnito = new List<City>()
            {
                new City() { NomeCity = "Londra", NAbitanti =  8982000, Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Manchester", NAbitanti = 553230 , Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Edimburgo", NAbitanti = 464990 , Area ="" , PosizioneGeo = "", NPositivi = 10000},
                new City() { NomeCity = "Liverpool", NAbitanti = 496784, Area ="" , PosizioneGeo = "", NPositivi = 10000 }
            };

            List<Country> countries = new List<Country>()
            {
                new Country() { CountryName = "Italia", NAbitanti = 59550000, Area ="" , PosizioneGeo = "", NPositivi = 10000, Cities = citiesItalia},
                new Country() { CountryName = "Germania", NAbitanti = 83240000, Area ="" , PosizioneGeo = "", NPositivi = 10000, Cities = citiesGermania},
                new Country() { CountryName = "Francia", NAbitanti = 67390000, Area ="" , PosizioneGeo = "", NPositivi = 10000, Cities = citiesFrancia},
                new Country() { CountryName = "Regno Unito", NAbitanti = 67220000, Area ="" , PosizioneGeo = "", NPositivi = 10000, Cities = citiesRegnoUnito }
            };

            Continent continent1 = new Continent()
            {
                NomeContinent = "Europa",
                NAbitanti = 74640000,
                Area = "",
                PosizioneGeo = "",
                NPositivi = 2,
                Countries = countries,




            };


            dbCtx.Continent.Add(continent1);



            try
            {
                await dbCtx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            if (dbSet.Any())
            {
                dbSet.RemoveRange(dbSet.ToList());
            }
        }
    }
}
