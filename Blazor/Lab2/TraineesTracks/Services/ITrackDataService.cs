using SharedLibrary;

namespace TraineesTracks.Services
{
    public interface ITrackDataService
    {
        Task<IEnumerable<Track>> GetAllTracks();
        Task<Track> GetTrackDetails(int TrackId);
    }
}
