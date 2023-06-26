using BlazorApp.Models;

namespace BlazorApp.Pages
{
    public partial class Holds
    {
        public List<HoldModel> HoldData { get; set; }
        
        public Holds()
        {
            HoldData = new List<HoldModel>
            {
                new HoldModel
                {
                    HoldName = "Falkreath Hold",
                    HoldImageSRC = "images/Holds/Falkreath_Hold.png",
                    HoldDesc = "Falkreath Hold, Falkreath, New Falkreath, or Newkreath is a dense forest region located in the southern portion of Skyrim.",
                    HoldRegion = "Southern Skyrim",
                    HoldCapital = "Falkreath",
                    HoldDetailsURL = "#",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Falkreath_Hold"
                },
                new HoldModel
                {
                    HoldName = "Eastmarch",
                    HoldImageSRC = "images/Holds/Eastmarch_Wallp.png",
                    HoldDesc = "Eastmarch or the Eastmarch Hold makes up the volcanic tundra of the Old Holds, within the province of Skyrim; it is one of the nine holds of the province. Eastmarch is largely a rural area, with sulfur pools that stretch the inner wastes.",
                    HoldRegion = "Northeastern Skyrim",
                    HoldCapital = "Windhelm",
                    HoldDetailsURL = "#",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Eastmarch"
                }
            };
        }
    }    
}

