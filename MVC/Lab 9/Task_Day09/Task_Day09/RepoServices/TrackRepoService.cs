using Task_Day09.Models;

namespace Task_Day09.RepoServices
{
    public class TrackRepoService : ITrackRepository
    {
        public MainDbContext Context { get; }
        public TrackRepoService(MainDbContext context)
        {
            Context = context;
        }
        public void DeleteTrack(int id)
        {
            Context.tracks.Remove(Context.tracks.Find(id));
            Context.SaveChanges();
        }

        public List<Track> GetAll()
        {
            return Context.tracks.ToList();

        }

        public Track GetDetails(int id)
        {
            return Context.tracks.Find(id);

        }

        public void Insert(Track track)
        {
            Context.tracks.Add(track);
            Context.SaveChanges();
        }

        public void UpdateTrack(int id, Track track)
        {
            Track UpdatedTrack = Context.tracks.Find(id);
            UpdatedTrack.TrackId = track.TrackId;
            UpdatedTrack.Name = track.Name;
            UpdatedTrack.Description = track.Description;
            Context.SaveChanges();
        }
    }
}
