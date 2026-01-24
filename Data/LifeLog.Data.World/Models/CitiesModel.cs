namespace LifeLog.Data.World.Models;

public class CitiesModel
{
    public int id { get; set; }
    public string name { get; set; }
    public int state_id { get; set; }
    public string state_code { get; set; }
    public string state_name { get; set; }
    public int country_id { get; set; }
    public string country_code { get; set; }
    public string country_name { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }
    public string wikiDataId { get; set; }
    public string CodeName => $"{id} ({name})";

}
