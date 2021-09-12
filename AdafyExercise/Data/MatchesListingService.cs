using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Collections.Generic;

namespace AdafyExercise.Data {
    public class MatchesListingService {

        private readonly IHttpClientFactory _clientFactory;
        private IEnumerable<MatchesListing> matches = Array.Empty<MatchesListing>();

        public object ClientFactory { get; private set; }

        public MatchesListingService(IHttpClientFactory clientFactory) {
            _clientFactory = clientFactory;
        }
        public async Task<MatchesListing[]> FetchData() {
            //TODO: Can the result be cached, if it isn't already?
            var request = new HttpRequestMessage(HttpMethod.Get, "https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode) {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                matches = await JsonSerializer.DeserializeAsync<IEnumerable<MatchesListing>>(responseStream);
            }

            return matches.ToArray();
        }
    }
}
