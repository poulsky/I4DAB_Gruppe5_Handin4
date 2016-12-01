using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HandIn4.Utility
{
    class APIGetJSON<T>
    {
        public T data;
        private string url;

        public APIGetJSON(string geturl)
        {
            url = geturl;
            data = getItems();
        }

        private T getItems()
        {
            T result = default(T);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // This allows for debugging possible JSON issues
            var settings = new JsonSerializerSettings
            {
                Error = (sender, args) =>
                {
                    if (System.Diagnostics.Debugger.IsAttached)
                    {
                        System.Diagnostics.Debugger.Break();
                    }
                }
            };

            using (HttpResponseMessage response = client.GetAsync(this.url).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    string resp = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<T>(resp, settings);
                }
            }
            return result;
        }
    }
}

