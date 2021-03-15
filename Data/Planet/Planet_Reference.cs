using System;
using System.Collections.Generic;

namespace Traveller.Data
{
    public static class Planet_Reference
    {

        public static List<Double> size_as_km = new List<Double> {
            800,
            1600,
            3200,
            4800,
            6400,
            8000,
            9600,
            11200,
            12800,
            14400,
            16000
        };

        public static List<Double> surface_gravity = new List<Double> {
            0.0,
            0.05,
            0.15,
            0.25,
            0.35,
            0.45,
            0.7,
            0.9,
            1.0,
            1.25,
            1.4
        };
        
        public static List<string> atmosphere_description = new List<string> {
            "None (Vacc Suit)",
            "Trace (Vacc Suit)",
            "Very Thin, Tainted (Respirator, Filter)",
            "Very Thin (Respirator)",
            "Thin, Tainted (Filter)",
            "Thin",
            "Standard",
            "Standard, Tainted (Filter)",
            "Dense",
            "Dense, Tainted (Filter)",
            "Exotic (Air Supply)",
            "Corrosive (Vacc Suit)",
            "Insidious (Vacc Suit)",
            "Dense, High (Surface pressure deadly.)",
            "Thin, Low (Breathable atmosphere in valleys.)",
            "Unusual (Further analysis required.)"
        };

        public static List<string> hydrographic_description = new List<string> {
            "Desert world (0-5%)",
            "Dry world (6-15%)",
            "A few small seas (16-25%)",
            "Small seas and oceans (26-35%)",
            "Wet world (36-45%)",
            "Large oceans (56-55%)",
            "Large oceans (56-65%)",
            "Earth-like world (66-75%)",
            "Water world (76-85%)",
            "Only a few small islands and archipelagos (86-95%)",
            "Almost entirely water (96-100%)"
        };

        public static List<string> population_description = new List<string> {
            "None",
            "A tiny famstead or a single family (dozens)",
            "A village (hundreds)",
            "A mid-sized village (thousands)",
            "A small town (tens of thousands)",
            "An average city (hundreds of thousands)",
            "An above average city (millions)",
            "A large city (tens of millions)",
            "Several large cities (hundreds of millions)",
            "Present day Earth (billions)",
            "Crowded world (tens of billions)",
            "Incredibly crowded world (hundreds of billions)",
            "World-city (trillions)"
        };

        public static List<string> government_title = new List<string> {
            "None",
            "Company/corporation",
            "Participating democracy",
            "Self-perpetuating oligarchy",
            "Representative democracy",
            "Feudal technocracy",
            "Captive government",
            "Balkanisation",
            "Civil service bureaucracy",
            "Impersonal Bureaucracy",
            "Charismatic dictator",
            "Non-charismatic leader",
            "Charismatic oligarchy",
            "Religious dictatorship"
        };

        public static List<string> government_description = new List<string> {
            "No government structure. In many cases, family bonds predominate.",
            "Ruling functions are assumed by a company or managerial elite, and most citizenry are company employees or dependants.",
            "Ruling functions are reached by the advice and consent of the citizenry directly.",
            "Ruling functions are performed by a restricted minority, with little or no input from the mass of citizenry.",
            "Ruling functions are performed by elected representatives.",
            "Ruling functions are performed by specific individuals for persons who agree to be ruled by them. Relationships are based on the performance of technical activities which are mutually beneficial.",
            "Ruling functions are performed by an imposed leadership answerable to an outside group.",
            "No central authority exists; rival governments compete for control. Law level refers to the government nearest the starport.",
            "Ruling functions are performed by government agencies employing individuals selected for their expertise.",
            "Ruling functions are performed by agencies which have become insulated from the governed citizens.",
            "Ruling functions are performed by agencies directed by a single leader who enjoys the overwhelming confidence of the citizens.",
            "A previous charismatic dictator has been replaced by a leader through normal channels.",
            "Ruling functions are performed by a select group of members of an organisation or class which enjoys the overwhelming confidence of the citizenry.",
            "Ruling functions are performed by a religious organisation without regard to the specific individual needs of the citizenry."
        };

        public static List<string> technology_level_description = new List<string> {
            "Primitive (Simple stone tools)",
            "Primitive (Simple metalworking)",
            "Primitive (Renaissance era sciences)",
            "Primitive (Steam power and gunpowder)",
            "Industrial (Plastics and radio)",
            "Industrial (Electricity and internal combustion)",
            "Industrial (Mainframe computers and early fission)",
            "Pre-Stellar (Satellites and common computers)",
            "Pre-Stellar (Local system space travel and early fussion)",
            "Pre-Stellar (Early gravity tech and one-way Jump drives)",
            "Early Stellar (Orbital facilities and Jump travel)",
            "Early Stellar (Early artificial intelligence and Jump-2 travel)",
            "Average Stellar (Weather control and plasma weapons)",
            "Average Stellar (Battle Dress and organ cloning)",
            "Average Stellar (Jump-5 travel and man-portable fusion)",
            "High Stellar (Black globe generators and anagathics)",
            "High Stellar (Future tech)"
        };

        public static List<string> law_restrictions_weapons = new List<string> {
            "No restrictions.",
            "Poison gas, explosives, undetectable weapons, and WMD restricted. All firearms permitted.",
            "Portable energy weapons (except ship-mounted) restricted.",
            "Heavy weapons restricted.",
            "Light assault weapons and submachine guns restricted.",
            "All firearms except shotgun, pistols, and stunners restricted. No concealed weapons.",
            "All firearms except shotguns and stunners; carrying weapons discouraged.",
            "All firearms, including shotguns and single-fire weapons.",
            "All firearms, bladed weapons, stunners.",
            "All weapons restricted."
        };

        public static List<string> law_restrictions_drugs = new List<string> {
            "No restrictions.",
            "Highly addictive and dangerous narcotics restricted.",
            "Highly addictive narcotics restricted.",
            "Combat drugs and highly addictive narcotics restricted.",
            "Combat drugs and addictive narcotics restricted.",
            "Anagathics, addictive narcotics, and combat drugs restricted.",
            "Fast, Slow, Anagathics, combat drugs, and addictive narcotics restricted.",
            "Fast, Slow, Anagathics, combat drugs, and narcotics restricted.",
            "All drugs restricted. Medicinal drugs tightly controlled.",
            "All drugs restricted (including medicinal)."
        };

        public static List<string> law_restrictions_information = new List<string> {
            "No restrictions.",
            "Intellect programs restricted.",
            "Agent and Intellect programs restricted.",
            "Intrusion, Agent, and Intellect programs restricted.",
            "Security, Intrusion, Agent, and Intellect programs restricted.",
            "All non-library programs restricted.",
            "Recent news from offworld and all non-library programs restricted.",
            "All programs, unfiltered data about other worlds restricted. Free speech curtailed.",
            "Information technology and any non-critical offworld personal media restricted.",
            "Any data from offworld restricted. No free press."
        };

        public static List<string> law_restrictions_technology = new List<string> {
            "No restrictions.",
            "Dangerous technologies such as nanotechnology.",
            "Alien technology.",
            "TL 15+ items.",
            "TL 13+ items.",
            "TL 11+ items.",
            "TL 9+ items.",
            "TL 7+ items.",
            "TL 5+ items.",
            "TL 3+ items."
        };

        public static List<string> law_restrictions_travellers = new List<string> {
            "No restrictions.",
            "Visitors must contact planetary authorities by radio, landing is permitted anywhere.",
            "Visitors must report passenger manifest, landing is permitted anywhere.",
            "Landing only at starport or other authorised sites.",
            "Landing only at starport.",
            "Citizens must register offworld travel, visitors must register all business.",
            "Visits discouraged; excessive contact with citizens forbidden.",
            "Citizens may not leave planet; visitors may not leave starport.",
            "Landing permitted only to imperial agents.",
            "No offworlders permitted."
        };

        public static List<string> law_restrictions_psionics = new List<string> {
            "No restrictions.",
            "Dangerous talents must be registered.",
            "All psionic powers must be registered; use of dangerous powers forbidden.",
            "Use of telepathy restricted to government-approved telepaths.",
            "Use of teleportation and clairvoyance restricted.",
            "Use of all psionic powers restricted to government psionicists.",
            "Possession of psionic drugs banned. Government-approved psionicists only.",
            "Use of psionics forbidden.",
            "Psionic-related technology banned. Use of psionics forbidden.",
            "Being psionic (even without use) is a crime."
        };


    }
}