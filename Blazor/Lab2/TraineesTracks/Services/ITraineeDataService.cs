using SharedLibrary;

namespace TraineesTracks.Services
{
    public interface ITraineeDataService
    {
        Task<IEnumerable<Trainee>> GetAllTrainees();
        Task<Trainee> GetTraineeDetails(int TraineeId);
        Task AddTrainee(Trainee trainee);
        Task UpdateTrainee(Trainee trainee);
        Task DeleteTrainee(int TraineeId);
    }
}
