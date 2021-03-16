using System;
using Traveller.Helper;
using Traveller.Data;
using System.Collections.Generic;

namespace Traveller.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Size { get; set; }
        public int Atmosphere { get; set; }
        public int Hydrology { get; set; }
        public int Population { get; set; }
        public int Government { get; set; }
        public int Law_Level { get; set; }
        public int Starport { get; set; }
        public int Technology_Level { get; set; }
        public bool Pirate_Base { get; set; }
        public bool TAS_Base { get; set; }
        public bool Naval_Base { get; set; }
        public bool Scout_Base { get; set; }
        public bool Research_Base { get; set; }
        public bool Imperial_Base { get; set; }

        public string Surface_CSS {get; set; }
        public string Size_CSS {get; set; }

        public string SetSurfaceTexture()
        {
            List<string> HighHydrologyImages = new List<string>{ "/assets/2k_earth_clouds_blue-min.jpg", "/assets/2k_earth_clouds_blue_light-min.jpg", "assets/Ocean_Planet-min.png" };
            List<string> MidHydrologyImages = new List<string>{ "/assets/Alpine-min.png", "/assets/Savannah-min.png", "/assets/2k_earth_daymap-min.jpg", "/assets/Tropical-min.png", "/assets/Terrestrial1-min.png", "/assets/Terrestrial2-min.png", "/assets/Terrestrial3-min.png", "/assets/Terrestrial4-min.png"};
            List<string> LowHydrologyImages = new List<string>{ "/assets/2k_ceres_fictional-min.jpg", "/assets/2k_eris_fictional-min.jpg", "/assets/2k_moon-min.jpg", "/assets/2k_haumea_fictional-min.jpg"};

            // ExoticAtmosphereImages = "/assets/Swamp.png"
            // Change LowHydrology to NoHydrology and create a new list for low.

            string SurfaceImage = "";
            var rand = new Random();

            if (Hydrology > 7)
            {
                // Water world.
                SurfaceImage = HighHydrologyImages[rand.Next(0, HighHydrologyImages.Count)];
            } else if (Hydrology > 3)
            {
                // Continents and islands. Earth-like.
                SurfaceImage = MidHydrologyImages[rand.Next(0, MidHydrologyImages.Count)];
            }
            else {
                // Barren or dry.
                SurfaceImage = LowHydrologyImages[rand.Next(0, LowHydrologyImages.Count)];
            }
            return "background-image: url(" + SurfaceImage + ");";
        }

        public string SetSizeCSS()
        {
            float SizeAsPercent = (((float)Size + 1)/11) * 250;
            string sizeCSS = "width:" + SizeAsPercent + "px; height:" + SizeAsPercent + "px;";
            return sizeCSS;
        }

        public char GetStarportRank()
        {
            char rank = '?';
            switch (Starport)
            {
                case 0:
                case 1:
                case 2:
                    rank = 'X';
                    break;
                case 3:
                case 4:
                    rank = 'E';
                    break;
                case 5:
                case 6:
                    rank = 'D';
                    break;
                case 7:
                case 8:
                    rank = 'C';
                    break;
                case 9:
                case 10:
                    rank = 'B';
                    break;
                case 11:
                case 12:
                    rank = 'A';
                    break;
            }
            return rank;
        }

        public string GetTravellerRestrictions()
        {
            if (Planet_Reference.law_restrictions_travellers.TryGetElement(Law_Level))
            {
                return Planet_Reference.law_restrictions_travellers[Law_Level];
            } else {
                return "No restrictions.";
            }
        }

        public string GetSizeAsKm()
        {
            return Size.GetDescription(Planet_Reference.size_as_km) + "km";
        }

        public string GetHydrologyDescription()
        {
            return Hydrology.GetDescription(Planet_Reference.hydrographic_description);
        }

        public string GetAtmosphereDescription()
        {
            return Atmosphere.GetDescription(Planet_Reference.atmosphere_description);
        }

        public string GetPopulationDescription()
        {
            return Population.GetDescription(Planet_Reference.population_description);
        }

        public string GetGovernmentDescription()
        {
            return Government.GetDescription(Planet_Reference.government_description);
        }

        public string GetGovernmentTitle()
        {
            return Government.GetDescription(Planet_Reference.government_title);
        }

        public string GetTechnologyDescription()
        {
            return Technology_Level.GetDescription(Planet_Reference.technology_level_description);
        }

        public string GetSurfaceGravityAsDouble()
        {
            return Size.GetDescription(Planet_Reference.surface_gravity) + "gs";
        }

        public Planet()
        {
            Title = HelperFunctions.GenerateRandomAlphanum(6);
            Size = HelperFunctions.RollDice(2) - 2;


            Atmosphere = Math.Max(0, HelperFunctions.RollDice(2) - 7 + Size);
            
            // NEED TO ADD PLANET TEMPERATURE FEATURES

            if (Size < 2)
            {
                Hydrology = 0;
            } else {
                Hydrology = HelperFunctions.RollDice(2) - 7 + Size;
                // Absent or irregular atmosphere means no water on the planet.
                switch(Atmosphere)
                {
                    case 0:
                    case 1:
                    case 10:
                    case 11:
                    case 12:
                        Hydrology -= 4;
                        break;
                }
                Hydrology = Math.Max(0, Hydrology);
                Hydrology = Math.Min(10, Hydrology);
            }

            Population = HelperFunctions.RollDice(2) - 2;
            // Low population or no population worlds
            if (Population == 0)
            {
                Government = 0;
                Law_Level = 0;
                Starport = 0;
                Technology_Level = 0;
            }
            else
            {
                Government = Math.Max(0, HelperFunctions.RollDice(2) - 7 + Population);
                Government = Math.Min(13, Government);

                Law_Level = Math.Max(0, HelperFunctions.RollDice(2) - 7 + Government);
                Law_Level = Math.Min(9, Law_Level);
                // This may be intended to go higher than 9. The chart says 9+.

                Starport = HelperFunctions.RollDice(2);

                // Generate bases depending on the Starport
                int TASTarget = 13;
                int ImperialTarget = 13;
                int NavalTarget = 13;
                int ResearchTarget = 13;
                int ScoutTarget = 13;
                int PirateTarget = 13;
                switch (GetStarportRank())
                {
                    case 'A':
                        TASTarget = 4;
                        ImperialTarget = 6;
                        NavalTarget = 8;
                        ResearchTarget = 8;
                        ScoutTarget = 10;
                        break;
                    case 'B':
                        TASTarget = 6;
                        ImperialTarget = 8;
                        NavalTarget = 8;
                        ResearchTarget = 10;
                        ScoutTarget = 8;
                        PirateTarget = 12;
                        break;
                    case 'C':
                        TASTarget = 10;
                        ImperialTarget = 10;
                        PirateTarget = 10;
                        ResearchTarget = 10;
                        ScoutTarget = 8;
                        break;
                    case 'D':
                        PirateTarget = 12;
                        ScoutTarget = 7;
                        break;
                    case 'E':
                        PirateTarget = 12;
                        break;
                    default:
                        break;
                }

                TAS_Base = (HelperFunctions.RollDice(2) >= TASTarget);
                Pirate_Base = (HelperFunctions.RollDice(2) >= PirateTarget);
                Research_Base = (HelperFunctions.RollDice(2) >= ResearchTarget);
                Naval_Base = (HelperFunctions.RollDice(2) >= NavalTarget);
                Imperial_Base = (HelperFunctions.RollDice(2) >= ImperialTarget);
                Scout_Base = (HelperFunctions.RollDice(2) >= ScoutTarget);

                Technology_Level = HelperFunctions.RollDice(1);
                // Nicer starport means nicer technology.
                switch (Starport)
                {
                case 2:
                    Technology_Level -= 4;
                    break;
                case 7:
                case 8:
                    Technology_Level += 2;
                    break;
                case 9:
                case 10:
                    Technology_Level += 4;
                    break;
                case 11:
                case 12:
                    Technology_Level += 6;
                    break;
                }
                // Small planets require more tech to survive.
                switch (Size)
                {
                case 0:
                case 1:
                    Technology_Level += 2;
                    break;
                case 2:
                case 3:
                case 4:
                    Technology_Level += 1;
                    break;
                }
                // No atosphere or abnormally dense atmosphere require more technology.
                switch (Atmosphere)
                {
                case 0:
                case 1:
                case 2:
                case 3:
                    Technology_Level += 1;
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Technology_Level += 1;
                    break;
                }
                Technology_Level = Math.Max(0, Technology_Level);
                Technology_Level = Math.Min(16, Technology_Level);

            // Need to add trade codes
            }

            Surface_CSS = SetSurfaceTexture();
            Size_CSS = SetSizeCSS();             

        }
    }
}