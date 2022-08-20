namespace CountriesApp
{

    public class Countres
    {
        public Country[] Property1 { get; set; }
    }

    public class Country
    {
        public Name name { get; set; }
        public Currencies currencies { get; set; }
        public Idd idd { get; set; }
        public string[] capital { get; set; }
        public string[] altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public Languages languages { get; set; }
        public float[] latlng { get; set; }
        public bool landlocked { get; set; }
        public string[] borders { get; set; }
        public float area { get; set; }
        public string flag { get; set; }
        public Maps maps { get; set; }
        public int population { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public Nativename nativeName { get; set; }
    }

    public class Nativename
    {
        public Aym aym { get; set; }
        public Que que { get; set; }
        public Spa spa { get; set; }
    }

    public class Aym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Que
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Spa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Currencies
    {
        public PEN PEN { get; set; }
    }

    public class PEN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Idd
    {
        public string root { get; set; }
        public string[] suffixes { get; set; }
    }

    public class Languages
    {
        public string? ara { get; set; }
        public string? ber { get; set; }
        public string? ces { get; set; }
        public string? cym { get; set; }
        public string? deu { get; set; }
        public string? est { get; set; }
        public string? fin { get; set; }
        public string? fra { get; set; }
        public string? hrv { get; set; }
        public string? hun { get; set; }
        public string? ita { get; set; }
        public string? jpn { get; set; }
        public string? kor { get; set; }
        public string? nld { get; set; }
        public string? per { get; set; }
        public string? prs { get; set; }
        public string? pus { get; set; }
        public string? pol { get; set; }
        public string? por { get; set; }
        public string? rus { get; set; }
        public string? slk { get; set; }
        public string? spa { get; set; }
        public string? swe { get; set; }
        public string? urd { get; set; }
        public string? zho { get; set; }
        public string? aym { get; set; }
        public string? que { get; set; }
        public string? pap { get; set; }
        public string? eng { get; set; }
        public string? tvl { get; set; }
        public string? tsn { get; set; }
        public string? tuk { get; set; }
        public string? ind { get; set; }
        public string? mey { get; set; }
        public string? ell { get; set; }
        public string? som { get; set; }
        public string? dan { get; set; }
        public string? fao { get; set; }
        public string? bel { get; set; }
        public string? heb { get; set; }
        public string? mya { get; set; }
    }

    public class Maps
    {
        public string googleMaps { get; set; }
        public string openStreetMaps { get; set; }
    }

    public class Gini
    {
        public float _2019 { get; set; }
    }

    public class Car
    {
        public string[] signs { get; set; }
        public string side { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Coatofarms
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Capitalinfo
    {
        public float[] latlng { get; set; }
    }

    public class Postalcode
    {
        public string format { get; set; }
        public string regex { get; set; }
    }
}
