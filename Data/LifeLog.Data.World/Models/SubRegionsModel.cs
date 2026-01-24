namespace LifeLog.Data.World.Models;

public class SubRegionsModel
{
    public int id { get; set; }
    public string name { get; set; }
    public int region_id { get; set; }
    public TranslationsModel translations { get; set; }
    public string wikiDataId { get; set; }
}

