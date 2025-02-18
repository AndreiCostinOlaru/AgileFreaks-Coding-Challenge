using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_Coding_Challenge.Services
{
    public static class DataFetcher
    {
        public static async Task<string> FetchDataAsync(string url)
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }
    }
}
