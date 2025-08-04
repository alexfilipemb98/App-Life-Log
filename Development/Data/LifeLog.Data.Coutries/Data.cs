using Countries.Models;
using LifeLog.Base.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Countries
{
    public class Data
    {
        /// <summary>
        /// Assembly of the project
        /// </summary>
        public static Assembly _Assembly => Assembly.GetExecutingAssembly();

        /// <summary>
        /// Gets all regions
        /// </summary>
        /// <returns></returns>
        public static List<RegionsModel> Regions() => FilesUtil.ReadAssemblyJsonFile<List<RegionsModel>>(_Assembly, "regions.json");

        /// <summary>
        /// Gets the sub regions, filter by region
        /// </summary>
        /// <param name="idRegion"></param>
        /// <returns></returns>
        public static List<SubRegionsModel> SubRegions(string idRegion = null)
        {
            List<SubRegionsModel> list = FilesUtil.ReadAssemblyJsonFile<List<SubRegionsModel>>(_Assembly, "subregions.json");

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
        public static List<CountriesModel> Countries(string idRegion = null, string idSubRegion = null)
        {
            List<CountriesModel> list = FilesUtil.ReadAssemblyJsonFile<List<CountriesModel>>(_Assembly, "countries.json");

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
        public static List<StatesModel> States(string idCoutry = null)
        {
            List<StatesModel> list = FilesUtil.ReadAssemblyJsonFile<List<StatesModel>>(_Assembly, "states.json");

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
        public static List<CitiesModel> Cities(string idState = null, string idCountry = null)
        {
            List<CitiesModel> list = FilesUtil.ReadAssemblyJsonFile<List<CitiesModel>>(_Assembly, "cities.json");

            if (!string.IsNullOrWhiteSpace(idState))
                list = list.Where(w => w.state_id.ToString() == idState).ToList();

            if (!string.IsNullOrWhiteSpace(idCountry))
                list = list.Where(w => w.country_id.ToString() == idCountry).ToList();

            return list;
        }
    }

}
