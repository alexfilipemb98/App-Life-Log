using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using WorldData.Models;

namespace WorldData
{
    public class Data
    {
        /// <summary>
        /// Gets all regions
        /// </summary>
        /// <returns></returns>
        public static List<Regions> Regions() => GET_JSON<List<Regions>>("regions.json");

        /// <summary>
        /// Gets the sub regions, filter by region
        /// </summary>
        /// <param name="idRegion"></param>
        /// <returns></returns>
        public static List<SubRegions> SubRegions(string idRegion = null)
        {
            List<SubRegions> list = GET_JSON<List<SubRegions>>("subregions.json");

            if (!string.IsNullOrWhiteSpace(idRegion))
                list = list.Where(w => w.region_id.ToString() == idRegion).ToList();

            return list;
        }

        /// <summary>
        /// Gets the countries, filtered by region and subregion
        /// </summary>
        /// <param name="idRegion"></param>
        /// <param name="idSubRegion"></param>
        /// <returns></returns>
        public static List<Countries> Countries(string idRegion = null, string idSubRegion = null)
        {
            List<Countries> list = GET_JSON<List<Countries>>("countries.json");

            if (!string.IsNullOrWhiteSpace(idRegion))
                list = list.Where(w => w.region_id == idRegion).ToList();

            if (!string.IsNullOrWhiteSpace(idSubRegion))
                list = list.Where(w => w.subregion_id == idSubRegion).ToList();

            return list;
        }

        /// <summary>
        /// Get the states, filter by country
        /// </summary>
        /// <param name="idCoutry"></param>
        /// <returns></returns>
        public static List<States> States(string idCoutry = null)
        {
            List<States> list = GET_JSON<List<States>>("states.json");

            if (!string.IsNullOrWhiteSpace(idCoutry))
                list = list.Where(w => w.country_id.ToString() == idCoutry).ToList();

            return list;
        }

        /// <summary>
        /// Gets the cities, filter by states, and country
        /// </summary>
        /// <param name="idState"></param>
        /// <param name="idCountry"></param>
        /// <returns></returns>
        public static List<Cities> Cities(string idState = null, string idCountry = null)
        {
            List<Cities> list = GET_JSON<List<Cities>>("cities.json");

            if (!string.IsNullOrWhiteSpace(idState))
                list = list.Where(w => w.state_id.ToString() == idState).ToList();

            if (!string.IsNullOrWhiteSpace(idCountry))
                list = list.Where(w => w.country_id.ToString() == idCountry).ToList();

            return list;
        }

        private static T GET_JSON<T>(string resourceName)
        {
            string resourse = Assembly.GetExecutingAssembly()
                .GetManifestResourceNames()
                .FirstOrDefault(w => w.ToLower().Contains(resourceName.ToLower()));

            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourse))
            {
                if (stream == null)
                    return default;

                using (StreamReader reader = new StreamReader(stream))
                {
                    string jsonContent = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<T>(jsonContent);
                }
            }
        }
    }

}
