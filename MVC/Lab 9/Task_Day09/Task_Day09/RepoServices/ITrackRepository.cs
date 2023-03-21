using Task_Day09.Models;

namespace Task_Day09.RepoServices
{
    public interface ITrackRepository
    {
        public List<Track> GetAll();
        public Track GetDetails(int id);
        public void Insert(Track track);
        public void UpdateTrack(int id, Track track);
        public void DeleteTrack(int id);
    }
}
