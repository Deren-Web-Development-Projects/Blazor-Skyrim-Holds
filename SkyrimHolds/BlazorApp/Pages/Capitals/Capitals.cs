using BlazorApp.Models;

namespace BlazorApp.Pages.Capitals
{
    public partial class Capitals
    {
        public List<CapitalModel> CapitalData { get; set; }

        public Capitals()
        {
            CapitalData = new List<CapitalModel>
            {
                new CapitalModel
                {
                    CapitalName = "Windhelm",
                    CapitalHold = "Eastmarch",
                    CapitalDesc = "Lying near the coast on the very northern tip of Eastmarch, Windhelm is an extremely cold city and frequently experiences blizzards. The main gate can only be accessed by crossing a long stone bridge over the White River. The Jarl of Windhelm is Ulfric Stormcloak, who resides in the Palace of the Kings. Windhelm is home to the Stormcloak Rebellion, so most people in the city support them in the Civil War. Due in part to this, anti-foreign sentiment is common in the city from the Nord majority. Due to Stormcloak presence, Windhelm does not comply with the Imperial ban on Talos worship and features a Temple of Talos in the city.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Windhelm",
                    CapitalImage = "images/Capitals/Windhelm.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Falkreath",
                    CapitalHold = "Falkreath Hold",
                    CapitalDesc = "Falkreath is a city in Falkreath Hold, located near the border with both Cyrodiil and Hammerfell. In the past Falkreath was considered a part of Cyrodiil, but now sits firmly within the borders of Skyrim. At the time of the Dovahkiin's arrival in Skyrim, Falkreath is aligned with the Empire. Falkreath's economy is centered around lumber retrieved from the surrounding forest. Its most distinguishing feature is its large cemetery that houses generations of the dead from all over Skyrim. Many shops in town derive their names from their close proximity to so much death.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Falkreath",
                    CapitalImage = "images/Capitals/Falkreath.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Solitude",
                    CapitalHold = "Haafingar",
                    CapitalDesc = "Solitude is a major city located in Haafingar on the northwestern shore of Skyrim. In addition to being the largest city in all of Skyrim, it is also the capital of the province and seat of the High King of Skyrim. The entire city is built on a natural arch over the Sea of Ghosts and houses many important buildings, such as the headquarters of the Imperial Legion in Skyrim, the East Empire Company Warehouse, the Blue Palace, and the Bards College. As Skyrim's capital, Solitude was the seat of the High King before his death. The Thalmor Embassy is also located near Solitude.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Solitude",
                    CapitalImage = "images/Capitals/Solitude.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Morthal",
                    CapitalHold = "Hjaalmarch",
                    CapitalDesc = "Morthal, supposedly named after the great Nord hero Morihaus, is the capital of Hjaalmarch. It is a fairly small, humble town of little economic or strategic importance besides its small lumber mill. Only the mill, an apothecary, and an inn support its weak economy. Hjaalmarch is one of the poorest of the nine Holds.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Morthal",
                    CapitalImage = "images/Capitals/Morthal.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Dawnstar",
                    CapitalHold = "The Pale",
                    CapitalDesc = "Dawnstar is a city on the northern coast of Skyrim, and the capital of the Pale. It is a fishing and mining settlement which is initially controlled by the Stormcloaks. The residents will report having horrible nightmares, which some initially blame on a witch's curse. It is frequently attacked by dragons.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Dawnstar",
                    CapitalImage = "images/Capitals/Dawnstar.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Markarth",
                    CapitalHold = "The Reach",
                    CapitalDesc = "It is housed in an ancient Dwemer city, giving it architecture noticeably different from most cities in Skyrim. Much of the city is carved into the rock face which surrounds it. Jarl Igmund is the ruler of the Reach. He is having issues with a group known as the Forsworn. Though there are many races populating the city, the people of Markarth are not fond of outsiders and the guards treat them with hostility and suspicion. Half the city is owned by the Silver-Blood family. The Silver-Bloods also own Cidhna Mine, which is actually inside the city walls and used as a prison, said to be the most secure prison in Skyrim. There is an area dug into the cliff called The Warrens where most of the poor of Markarth live in extreme poverty. Many of the workers in the Warrens work in the mines and at the smelters in the area. The guards are quartered in a Dwemer dormitory carved out of the stone beneath the imposing Guard Tower at the center of the city.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Markarth",
                    CapitalImage = "images/Capitals/Markarth.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Riften",
                    CapitalHold = "The Rift",
                    CapitalDesc = "Riften is the capital city of the Rift, located in the southeast corner of the hold. The city lies near the borders of both Morrowind and Cyrodiil, and is home to the Thieves Guild, who inhabit the sewers beneath Riften known as the Ratway. Honorhall Orphanage is located in the city, as well as Mistveil Keep, the jarl's residence.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Riften",
                    CapitalImage = "images/Capitals/Riften.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Whiterun",
                    CapitalHold = "Whiterun Hold",
                    CapitalDesc = "Whiterun is a major city located in the center of Skyrim, to the northwest of the Throat of the World, the highest mountain on the entire continent of Tamriel. The capital of Whiterun Hold, Whiterun's central location makes it the province's major commercial hub. Its central location also makes it a crucial strategic point in the Civil War between the Imperial Legion loyalists and Stormcloak rebels, as control of Whiterun Hold grants access to all the surrounding areas. Initially, Whiterun is nominally aligned with The Empire, but the Jarl, Balgruuf the Greater, seems to care more about the people of Whiterun than either side of the conflict, and so the hold is effectively neutral. Whiterun comprises three districts arranged in tiers and connected by stairways. The Plains District is the lowest and contains all the shops, the city's marketplace, inns, and a few homes as well at the city gates. The Wind District is the main residential area; its more important buildings include the Temple of Kynareth and Jorrvaskr, headquarters of the Companions. The Cloud District is the location of Dragonsreach and is the highest point in Whiterun.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Whiterun",
                    CapitalImage = "images/Capitals/Whiterun.jpg"
                },
                new CapitalModel
                {
                    CapitalName = "Winterhold",
                    CapitalHold = "Winterhold",
                    CapitalDesc = "Winterhold is a city located on the northeasternmost tip of Skyrim and is home to the prominent College of Winterhold. It was once a large, bustling and prosperous city. In 4E 122, a cataclysmic event known as the \"Great Collapse\" occurred, in which most of the city fell into the Sea of Ghosts. Winterhold now only consists of a few rudimentary buildings and the College of Winterhold, one of the only original structures still standing. Many of the remaining inhabitants of Winterhold suspect that the College caused the city's destruction. The College stands by the belief that it was caused as a result of the earthquake in Vivec and subsequent eruption of Red Mountain in Morrowind. The few remaining residents of Winterhold can usually be found \"drinking their sorrows away\" in the Frozen Hearth, and most of these characters can point you to local quests. Birna at \"Birna's Oddments\" can also sell you the Coral Dragon Claw for 50 septims, which you will need to investigate Yngol Barrow further.",
                    CapitalLink = "https://en.uesp.net/wiki/Skyrim:Winterhold",
                    CapitalImage = "images/Capitals/Winterhold.jpg"
                }
            };
        }
    }    
}

