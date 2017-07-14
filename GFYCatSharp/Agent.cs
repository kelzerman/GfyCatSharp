using System;
using System.Net.Http;
using System.Text;
using GFYCatSharp.Exceptions;
using GFYCatSharp.Objects;
using Newtonsoft.Json;

namespace GFYCatSharp
{
    public class Agent
    {
        public Session Session { get; }

        public bool Activated => !string.IsNullOrEmpty(Session?.access_token);

        public string BaseUrl => "https://api.gfycat.com/v1/";

        public Agent(string clientId, string clientSecret)
        {
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrEmpty(clientSecret)) throw new ArgumentNullException(nameof(clientSecret));

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;
                using (StringContent authString = new StringContent($@"{{ ""grant_type"":""client_credentials"",""client_id"":""{clientId}"",""client_secret"":""{clientSecret}""}}", Encoding.UTF8, "application/json"))
                    response = client.PostAsync("https://api.gfycat.com/v1/oauth/token", authString).Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    Session = JsonConvert.DeserializeObject<Session>(result);
                }
                else
                {
                    ErrorResponse err = JsonConvert.DeserializeObject<ErrorResponse>(response.Content.ReadAsStringAsync().Result);
                    throw new OathException(err.errorMessage.code, new Exception(err.errorMessage.description));
                }
            }
        }

        public T Execute<T>(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Session.access_token);
                HttpResponseMessage response  = client.GetAsync(BaseUrl + path).Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(result);
                }

                string errorCode;
                string errorMessage;
                try
                {
                    ErrorMessage err = JsonConvert.DeserializeObject<ErrorMessage>(response.Content.ReadAsStringAsync().Result);
                    errorMessage = "No info";
                    errorCode = err.errorMessage;
                }
                catch
                {
                    ErrorResponse err = JsonConvert.DeserializeObject<ErrorResponse>(response.Content.ReadAsStringAsync().Result);
                    errorMessage = err.errorMessage.description;
                    errorCode = err.errorMessage.code;
                }

                throw new ImageException(errorCode, new Exception(errorMessage));

            }
        }
    }
}