using SharedLibrary;
using System.Net.Http.Json;

namespace BlazorDay3_Task_SD43.Services
{
    public class TrackServiceRepo : ITrackService
    {
        private readonly HttpClient httpClient;

        public TrackServiceRepo(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task AddTrack(Track Track)
        {
            await httpClient.PostAsJsonAsync<Track>("/api/Tracks", Track);
        }

        public async Task DeleteTrack(int TrackId)
        {
            await httpClient.DeleteAsync("/api/Tracks/" + TrackId);
        }

        public async Task<IEnumerable<Track>> GetAllTracks()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Track>>("/api/Tracks");
        }


        public async Task<Track> GetTrackDetails(int TrackId)
        {
            return await httpClient.GetFromJsonAsync<Track>("/api/Tracks/" + TrackId);
        }

        public async Task UpdateTrack(Track Track)
        {
            await httpClient.PutAsJsonAsync("/api/Tracks/" + Track.TrackId, Track);
        }
    }
}
