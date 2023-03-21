using Task_Day09.Models;

namespace Task_Day09.RepoServices
{
    public interface ITraineeRepository
    {
        public List<Trainee> GetAll();
        public Trainee GetDetails(int id);
        public void Insert (Trainee trinee);
        public void UpdateTrainee (int id, Trainee trinee);
        public void DeleteTrainee (int id);

    }
}
