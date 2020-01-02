using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Familiaris.Models;
using Newtonsoft.Json;

namespace Familiaris
{
    public class QueryApi
    {
        public static async Task<List<ApiModel>> MonsterHunterData(string url, CancellationToken cancellationToken)
        {
            using (var client = new HttpClient())
            using(var request = new HttpRequestMessage(HttpMethod.Get, url))
            using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead,
                cancellationToken))
            {
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode == false)
                {
                    throw new ApiException
                    {
                        StatusCode = (int) response.StatusCode,
                        Content = content
                    };
                }

                return JsonConvert.DeserializeObject<List<ApiModel>>(content, Familiaris.Models.Converter.Settings);
            }
        }
    }
}