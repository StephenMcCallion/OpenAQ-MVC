using System;
namespace DeptTechnicaTest_OPenAQ.Interfaces
{
	public interface IAPIHelper
	{
        Task<string?> sendRequest(string endPoint);
        Task<string?> sendRequest(string endPoint, Dictionary<string, string> param);
    }
}

