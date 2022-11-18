using System;
using DeptTechnicaTest_OPenAQ.Models.DataModels;

namespace DeptTechnicaTest_OPenAQ.Models.ViewModels
{
	public class Home
	{
		public LatestRoot latestData { get; set; }

		public Home(LatestRoot latest)
		{
			this.latestData = latest;
		}


	}
}

