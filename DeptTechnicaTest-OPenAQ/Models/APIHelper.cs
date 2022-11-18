using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using DeptTechnicaTest_OPenAQ.Interfaces;
using Microsoft.AspNetCore.WebUtilities;

namespace DeptTechnicaTest_OPenAQ.Models
{
    /// <summary>
    /// This class is responsible for sending requests to OpenAQ
    /// Base URL is always https://api.openaq.org/v2/
    /// the client is instantiated and injected into this class at runtime
    /// and is reused throughout the lifecycle of the app.
    /// </summary>
    public class APIHelper : IAPIHelper
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<APIHelper> _logger;

        public APIHelper(HttpClient client, ILogger<APIHelper> logger)
        {
            this._httpClient = client;
            this._logger = logger;
        }

        /// <summary>
        /// send request to OpenAQ endpoint 
        /// </summary>
        /// <param name="endPoint">Endpoint of the Request</param>
        public async Task<string?> sendRequest(string endPoint)
        {
            string responseBody = "";
            try
            {
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await _httpClient.GetAsync(endPoint);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
                return responseBody; // Return json
            }
            catch (Exception ex)
            {
                // Need to log error
                _logger.LogError($"Error while requesting {endPoint} from OpenAQ.");
                Console.WriteLine(ex.ToString());
            }
            return responseBody;
        }

        /// <summary>
        /// Overload method to include paramters that are passed to an endpoint.
        /// </summary>
        /// <param name="endPoint">Endpoint of the Request</param>
        /// <param name="param">additional parameter to be appended to the query string</param>
        public async Task<string?> sendRequest(string endPoint, Dictionary<string, string> param)
        {
            string responseBody = "";
            try
            {
                string uri = _httpClient.BaseAddress + endPoint;
                string request = QueryHelpers.AddQueryString(uri, param);
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await _httpClient.GetAsync(request);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                return responseBody; // Return json
            }
            catch (Exception ex)
            {
                // Need to log error
                _logger.LogError($"Error while requesting {endPoint} with param {param} from OpenAQ.");
                Console.WriteLine(ex.ToString());
            }
            return responseBody;

        }
    }
}

