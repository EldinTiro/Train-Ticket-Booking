using eZeljeznice.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZeljeznice.WinUI
{
    class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private string _route = null;

#if DEBUG
        private string _apiUrl = "http://localhost:50186/api";
#endif
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>()
        {
            var url = $"{_apiUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }

        public async Task<T> GetTopRelations<T>()
        {
            var url = $"{_apiUrl}/{_route}/TopRelations";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }

        public async Task<T> GetLoyality<T>()
        {
            var url = $"{_apiUrl}/{_route}/Loyalty";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            if(search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

        }

        public async Task<T> Update<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

        }

        public async Task<T> Authenticiraj<T>(string username, string password)
        {
            var url = $"{_apiUrl}/{_route}/Authenticiraj/{username},{password}";

            return await url.GetJsonAsync<T>();
        }
    }
}
