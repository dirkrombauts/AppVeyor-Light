using System;
using System.Collections.Generic;

using RestSharp;

namespace AppVeyorServices
{
    public class AppVeyorGateway
    {
        private readonly string apiToken;

        private readonly RestClient client;

        public AppVeyorGateway(string apiToken)
        {
            this.apiToken = apiToken;
            this.client = new RestClient(new Uri("https://ci.appveyor.com/api"));
        }

        public List<Project> GetProjects()
        {
            var request = new RestRequest("projects", Method.GET);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", string.Format("Bearer {0}", apiToken));

            IRestResponse<List<Project>> response = this.client.Execute<List<Project>>(request);

            if (response.ErrorException != null) throw response.ErrorException;

            return response.Data;
        }
    }
}