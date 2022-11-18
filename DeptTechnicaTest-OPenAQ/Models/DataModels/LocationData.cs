using System;
namespace DeptTechnicaTest_OPenAQ.Models.DataModels
{
	public class LocationData
	{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Coordinates
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class Parameter
        {
            public int id { get; set; }
            public string unit { get; set; }
            public int count { get; set; }
            public double average { get; set; }
            public double lastValue { get; set; }
            public string parameter { get; set; }
            public string displayName { get; set; }
            public DateTime lastUpdated { get; set; }
            public int parameterId { get; set; }
            public DateTime firstUpdated { get; set; }
            public object manufacturers { get; set; }
        }

        public class Result
        {
            public int id { get; set; }
            public object city { get; set; }
            public string name { get; set; }
            public string entity { get; set; }
            public string country { get; set; }
            public List<Source> sources { get; set; }
            public bool isMobile { get; set; }
            public bool isAnalysis { get; set; }
            public List<Parameter> parameters { get; set; }
            public string sensorType { get; set; }
            public Coordinates coordinates { get; set; }
            public DateTime lastUpdated { get; set; }
            public DateTime firstUpdated { get; set; }
            public int measurements { get; set; }
            public object bounds { get; set; }
            public object manufacturers { get; set; }
        }

        public class Root
        {
            public Meta meta { get; set; }
            public List<Result> results { get; set; }
        }

        public class Source
        {
            public string url { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public object readme { get; set; }
            public object organization { get; set; }
            public object lifecycle_stage { get; set; }
        }


    }
}

