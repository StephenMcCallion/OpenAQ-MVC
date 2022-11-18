using System;
using DeptTechnicaTest_OPenAQ.Interfaces;

namespace DeptTechnicaTest_OPenAQ.Models.DataModels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CountryResult
    {
        public string code { get; set; }
        public string name { get; set; }
        public int locations { get; set; }
        public DateTime firstUpdated { get; set; }
        public DateTime lastUpdated { get; set; }
        public List<string>? parameters { get; set; }
        public long count { get; set; }
        public int cities { get; set; }
        public int sources { get; set; }
    }

    public class CountryRoot
    {
        public Meta meta { get; set; }
        public List<CountryResult> results { get; set; }
    }

}

