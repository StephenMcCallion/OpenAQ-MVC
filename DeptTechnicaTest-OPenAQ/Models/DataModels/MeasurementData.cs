using System;
namespace DeptTechnicaTest_OPenAQ.Models.DataModels
{
	public class MeasurementData
	{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Coordinates
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class Date
        {
            public DateTime utc { get; set; }
            public DateTime local { get; set; }
        }

        public class Result
        {
            public int locationId { get; set; }
            public string location { get; set; }
            public string parameter { get; set; }
            public double value { get; set; }
            public Date date { get; set; }
            public string unit { get; set; }
            public Coordinates coordinates { get; set; }
            public string country { get; set; }
            public object city { get; set; }
            public bool isMobile { get; set; }
            public object isAnalysis { get; set; }
            public string entity { get; set; }
            public string sensorType { get; set; }
        }

        public class Root
        {
            public Meta meta { get; set; }
            public List<Result> results { get; set; }
        }


    }
}

