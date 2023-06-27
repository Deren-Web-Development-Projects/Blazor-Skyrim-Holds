using BlazorApp.Models;

namespace BlazorApp.Pages.Holds
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
                    HoldName = "Eastmarch",
                    HoldImageSRC = "images/Holds/Hold-Eastmarch.jpg",
                    HoldDesc = "Eastmarch covers much of Skyrim's eastern border with Morrowind. The surrounding holds are Winterhold to the north, The Pale and Whiterun to the west and The Rift to the south. Central/south Eastmarch is a volcanically active area, plains with steaming gas leaking in between cracks in the ground, colorful, mineral filled bodies of water, and geysers. The far west of the hold resembles much of the rest of central Skyrim, and to the north a mountainous tundra, where the hold's capital Windhelm lies. The east is composed of the Velothi mountain range, which extends down to the Rift. The province's border with Morrowind can be accessed by road a short walk up the mountains from Windhelm, though the border cannot be crossed.",
                    HoldRegion = "Northeastern Skyrim",
                    HoldCapital = "Windhelm",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:Eastmarch",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Eastmarch"
                },
                new HoldModel
                {
                    HoldName = "Falkreath Hold",
                    HoldImageSRC = "images/Holds/Hold-Falkreath.jpg",
                    HoldDesc = "It is the second southernmost hold in Skyrim, after The Rift. It borders Cyrodiil to the south and Hammerfell to the west, with a single road leading to both provinces. Other than its capital, Falkreath, the other notable town in the hold is Helgen, the first settlement in Skyrim to be attacked by a dragon during the Dragon Crisis and also where the Last Dragonborn was brought to be executed after being captured in Darkwater Crossing.",
                    HoldRegion = "Southern Skyrim",
                    HoldCapital = "Falkreath",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:Falkreath_Hold",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Falkreath_Hold"
                },
                new HoldModel
                {
                    HoldName = "Haafingar",
                    HoldImageSRC = "images/Holds/Hold-Haafingar.jpg",
                    HoldDesc = "Haafingar is the smallest Hold in area. Since the Fourth Era, the High King of Skyrim reigns from Solitude. The hold is separated from Hjaalmarch by the Karth River and The Reach by mountains. Dragon Bridge is the only access to the hold by road, crossing the Karth River. Much of the hold is rocky and mountainous with soaring snowy mountains surrounding the north and west of Solitude, though the lower lying areas including Dragon Bridge are mostly comprised of forests and hills.",
                    HoldRegion = "Northwest Skyrim",
                    HoldCapital = "Solitude",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:Haafingar",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Haafingar"
                },
                new HoldModel
                {
                    HoldName = "Hjaalmarch",
                    HoldImageSRC = "images/Holds/Hold-Hjaalmarch.jpg",
                    HoldDesc = "Hjaalmarch is located in northern Skyrim, at the mouth of the Karth River. The capital, Morthal, lies near the center of the hold. The hold borders Haafingar, separated by the Karth River to the northwest, The Reach to the west, Whiterun to the south and The Pale to the east. Hjaalmarch's most distinct terrain are its swamps and marshes, but it also has snow-covered forests, mountains, and rocky plains, making it arguably the most geographically diverse of Skyrim's holds. ",
                    HoldRegion = "Northern Skyrim",
                    HoldCapital = "Morthal",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:Hjaalmarch",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Hjaalmarch"
                },
                new HoldModel
                {
                    HoldName = "The Pale",
                    HoldImageSRC = "images/Holds/Hold-ThePale.jpg",
                    HoldDesc = "The Pale is located in the central northern area of Skyrim and extends to the northern coast where Dawnstar is situated. The hold borders Hjaalmarch to the west, Whiterun to the south, and Winterhold and Eastmarch to the east. Most of the region is treacherously cold with pine forests that stand facing the harsh winds whipping down the mountains. Only in the southernmost part of the hold towards Whiterun does the harsh terrain abate and become grassy plains.",
                    HoldRegion = "Central North Skyrim",
                    HoldCapital = "Dawnstar",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:The_Pale",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/The_Pale"
                },
                new HoldModel
                {
                    HoldName = "The Reach",
                    HoldImageSRC = "images/Holds/Hold-TheReach.jpg",
                    HoldDesc = "The Reach is infamous for harboring the Forsworn, a clan of Reachmen who are fighting a long war of independence and seek to retake Markarth from the Nords and free the Hold from Imperial authority. The Forsworn are the Reach's most common enemies and dwell in the Reach highlands. With the constant threat of Forsworn attacks looming over Markarth and its surrounding settlements, the Reach is often considered the most dangerous Hold of Skyrim, fit only for seasoned adventurers or hardened mercenaries.",
                    HoldRegion = "Western Skyrim",
                    HoldCapital = "Markarth",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:The_Reach",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/The_Reach"
                },
                new HoldModel
                {
                    HoldName = "The Rift",
                    HoldImageSRC = "images/Holds/Hold-TheRift.jpg",
                    HoldDesc = "The Rift is the most southeasterly of the nine Holds of Skyrim. It is one of the four oldest holds in Skyrim, known collectively as Old Holds.[1] Major settlements include Riften, Ivarstead, and Shor's Stone. Its coat of arms is two crossed daggers. Its capital city, Riften, is home to the Thieves Guild.",
                    HoldRegion = "Southeast Skyrim",
                    HoldCapital = "Riften",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:The_Rift",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/The_Rift_(Skyrim)"
                },
                new HoldModel
                {
                    HoldName = "Whiterun",
                    HoldImageSRC = "images/Holds/Hold-Whiterun.jpg",
                    HoldDesc = "Whiterun Hold is the central hold of Skyrim. It is named for the capital city of the hold, Whiterun. The landscape is mostly boreal plains with vast, sparse tundra and flowing rivers; however its most striking landmark is the Throat of the World, the highest peak in Tamriel. It is said among Nords that this is where mankind was first given life. High Hrothgar is an ancient monastery resting atop the mountain where the Greybeards dwell, masters of the Voice and trainers of the Dragonborn. Though High Hrothgar is located within Whiterun Hold, the Greybeards seem to have no political ties to Whiterun, instead remaining apolitical.",
                    HoldRegion = "Central Skyrim",
                    HoldCapital = "Whiterun",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:Whiterun_Hold",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Whiterun_Hold"
                },                
                new HoldModel
                {
                    HoldName = "Winterhold",
                    HoldImageSRC = "images/Holds/Hold-Winterhold.jpg",
                    HoldDesc = "Winterhold is located on the northeast corner of Skyrim. It is an intensely cold region, and most of the hold is covered in snowy tundra plains and high mountain ranges. Along the coast is a polar environment of glaciers and icebergs. The surrounding holds are Eastmarch, to the south; and The Pale, to the west. ",
                    HoldRegion = "Northeast Skyrim",
                    HoldCapital = "Winterhold",
                    HoldDetailsURL = "https://en.uesp.net/wiki/Skyrim:Winterhold_(region)",
                    HoldFandomURL = "https://elderscrolls.fandom.com/wiki/Winterhold_(Skyrim_Hold)"
                }
            };
        }
    }    
}

