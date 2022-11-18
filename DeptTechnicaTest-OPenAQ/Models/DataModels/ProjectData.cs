using System;
namespace DeptTechnicaTest_OPenAQ.Models.DataModels
{
	public class ProjectData
	{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

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
            public string name { get; set; }
            public string subtitle { get; set; }
            public bool isMobile { get; set; }
            public bool isAnalysis { get; set; }
            public string entity { get; set; }
            public string sensorType { get; set; }
            public int locations { get; set; }
            public List<int> locationIds { get; set; }
            public List<string> countries { get; set; }
            public List<Parameter> parameters { get; set; }
            public List<double> bbox { get; set; }
            public int measurements { get; set; }
            public DateTime firstUpdated { get; set; }
            public DateTime lastUpdated { get; set; }
            public List<Source> sources { get; set; }
        }

        public class Root
        {
            public Meta meta { get; set; }
            public List<Result> results { get; set; }
        }

        public class Source
        {
            public string id { get; set; }
            public string name { get; set; }
            public string readme { get; set; }
            public string data_avg_dur { get; set; }
            public string organization { get; set; }
            public string lifecycle_stage { get; set; }
        }


    }
}

