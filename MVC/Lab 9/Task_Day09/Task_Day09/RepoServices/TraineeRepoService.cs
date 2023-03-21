using Microsoft.EntityFrameworkCore;
using Task_Day09.Models;

namespace Task_Day09.RepoServices
{
    public class TraineeRepoService : ITraineeRepository
    {
        public MainDbContext Context { get; }
        List<Trainee> TraineeLst;
        public TraineeRepoService(MainDbContext context)
        {
            Context = context;
            TraineeLst = Context.trainees.Include("TrTrack").Include("course").ToList();
        }
        public void DeleteTrainee(int id)
        {
            Trainee trainee = Context.trainees.Find(id);
            Context.trainees.Remove(trainee);
            Context.SaveChanges();
        }

        public List<Trainee> GetAll()
        {
            return TraineeLst;
        }

        public Trainee GetDetails(int id)
        {
            Trainee trainee = (Trainee)TraineeLst.Where(trainee => trainee.TraineeId == id).FirstOrDefault();
            return trainee;
        }

        public void Insert(Trainee trinee)
        {
            Context.trainees.Add(trinee);
            Context.SaveChanges();
        }

        public void UpdateTrainee(int id, Trainee trinee)
        {
            Trainee UpdatedTr = Context.trainees.Find(id);
            UpdatedTr.TraineeId = trinee.TraineeId;
            UpdatedTr.TraineeName = trinee.TraineeName;
            UpdatedTr.Birthdate = trinee.Birthdate;
            UpdatedTr.TrackID = trinee.TrackID;
            UpdatedTr.CourseID = trinee.CourseID;
            UpdatedTr.Email = trinee.Email;
            UpdatedTr.Gender = trinee.Gender;
            UpdatedTr.PhoneNumber = trinee.PhoneNumber;
            Context.SaveChanges();
        }
    }
}
