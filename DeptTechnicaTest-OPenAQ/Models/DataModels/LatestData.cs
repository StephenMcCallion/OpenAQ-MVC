using System;
namespace DeptTechnicaTest_OPenAQ.Models.DataModels
{
    public class Meta
    {
        public string name { get; set; }
        public string license { get; set; }
        public string website { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int found { get; set; }
    }

    public class LatestCoordinates
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class LatestMeasurement
    {
        public string parameter { get; set; }
        public double value { get; set; }
        public DateTime lastUpdated { get; set; }
        public string unit { get; set; }
    }

    public class LatestResult
    {
        public string location { get; set; }
        public object city { get; set; }
        public string country { get; set; }
        public LatestCoordinates coordinates { get; set; }
        public List<LatestMeasurement> measurements { get; set; }
    }

    public class LatestRoot
    {
        public Meta meta { get; set; }
        public List<LatestResult> results { get; set; }
    }
}
