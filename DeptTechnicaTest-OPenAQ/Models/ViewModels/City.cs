using System;
using DeptTechnicaTest_OPenAQ.Models.DataModels;

namespace DeptTechnicaTest_OPenAQ.Models.ViewModels
{
	public class City
	{
        public CityRoot cities { get; set; }

        public City(CityRoot city)
		{
			this.cities = city;
		}

	}
}

