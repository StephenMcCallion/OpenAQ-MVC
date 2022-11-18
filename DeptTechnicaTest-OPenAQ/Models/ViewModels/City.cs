using System;
using DeptTechnicaTest_OPenAQ.Models.DataModels;

namespace DeptTechnicaTest_OPenAQ.Models.ViewModels
{
	public class City
	{
		public CityRoot cities { get; set; }
		public Dictionary<string, string> cityParams {get; set;}
        public City(CityRoot city)
		{
			this.cities = city;
			populateCityParam();

        }

		private void populateCityParam()
		{
			cityParams= new Dictionary<string, string>();
			cityParams.Add("Limit", "");
            cityParams.Add("Page", "");
            cityParams.Add("Offset", "");
            cityParams.Add("Countryid", "");
            cityParams.Add("Country", "");
            cityParams.Add("City", "");
            cityParams.Add("Order-By", "");
            cityParams.Add("Entity", "");
        }

    }
}

