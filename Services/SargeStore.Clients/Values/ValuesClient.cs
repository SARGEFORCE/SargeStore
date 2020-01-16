using Microsoft.Extensions.Configuration;
using SargeStore.Clients.Base;
using SargeStore.Interfaces.Api;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SargeStore.Clients.Values
{
    class ValuesClient : BaseClient, IValuesService
    {
        public ValuesClient(IConfiguration config)
            : base(config, "api/values")
        {
        }

        public IEnumerable<string> Get() => GetAsync().Result;

        public async Task<IEnumerable<string>> GetAsync()
        {
            var response = await _Client.GetAsync(_ServiceAddress);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<List<string>>();

            return Array.Empty<string>();
        }
        public string Get(int id) => GetAsync(id).Result;

        public async Task<string> GetAsync(int id)
        {
            var response = await _Client.GetAsync($"{_ServiceAddress}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<string>();

            return string.Empty;
        }
        public Uri Post(string value)
        {
            throw new NotImplementedException();
        }

        public Task<Uri> PostAsync(string value)
        {
            throw new NotImplementedException();

        }

        public HttpStatusCode Delete(int id)
        {
            throw new NotImplementedException();
        }

        public HttpStatusCode DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        

        public HttpStatusCode Put(int id, string value)
        {
            throw new NotImplementedException();
        }

        public Task<HttpStatusCode> PutAsync(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
