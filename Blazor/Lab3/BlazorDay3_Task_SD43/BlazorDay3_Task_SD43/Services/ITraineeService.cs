using SharedLibrary;

namespace BlazorDay3_Task_SD43.Services
{
    public interface ITraineeService
    {

        Task<IEnumerable<Trainee>> GetAllTrainee();
        Task<Trainee> GetTraineeDetails(int TraineeId);
        Task AddTrainee(Trainee Trainee);
        Task UpdateTrainee(Trainee Trainee);
        Task DeleteTrainee(int TraineeId);
    }
}
