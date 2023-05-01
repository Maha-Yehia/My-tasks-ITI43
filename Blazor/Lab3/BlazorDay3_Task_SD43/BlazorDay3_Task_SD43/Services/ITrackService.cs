using SharedLibrary;

namespace BlazorDay3_Task_SD43.Services
{
    public interface ITrackService
    {
        Task<IEnumerable<Track>> GetAllTracks();
        Task<Track> GetTrackDetails(int TrackId);
        Task AddTrack(Track Track);
        Task UpdateTrack(Track Track);
        Task DeleteTrack(int employeeId);
    }
}
