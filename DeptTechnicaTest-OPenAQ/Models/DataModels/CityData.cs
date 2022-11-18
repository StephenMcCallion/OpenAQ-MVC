using System;
namespace DeptTechnicaTest_OPenAQ.Models.DataModels
{
    public class CityResult
    {
        public string country { get; set; }
        public string city { get; set; }
        public int count { get; set; }
        public int locations { get; set; }
        public DateTime firstUpdated { get; set; }
        public DateTime lastUpdated { get; set; }
        public List<string> parameters { get; set; }
    }

    public class CityRoot
    {
        public Meta meta { get; set; }
        public List<CityResult> results { get; set; }
    }
}

