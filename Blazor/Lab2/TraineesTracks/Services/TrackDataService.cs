using SharedLibrary;
using System.Net.Http.Json;

namespace TraineesTracks.Services
{
    public class TrackDataService : ITrackDataService
    {
        public HttpClient HttpClient { get; }
        public TrackDataService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public async Task<IEnumerable<Track>> GetAllTracks()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Track>>("/api/Tracks");
        }

        public async Task<Track> GetTrackDetails(int TrackId)
        {
            return await HttpClient.GetFromJsonAsync<Track>("/api/Tracks/" + TrackId);
        }
    }
}
