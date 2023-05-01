using SharedLibrary;
using System.Net.Http.Json;

namespace BlazorDay3_Task_SD43.Services
{
    public class TraineeServiceRepo : ITraineeService
    {
        private readonly HttpClient httpClient;

        public TraineeServiceRepo(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task AddTrainee(Trainee Trainee)
        {
            await httpClient.PostAsJsonAsync<Trainee>("/api/Trainees/", Trainee);
        }

        public async Task DeleteTrainee(int TraineeId)
        {
            await httpClient.DeleteAsync("/api/Trainees/" + TraineeId);
        }

        public async Task<IEnumerable<Trainee>> GetAllTrainee()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Trainee>>("/api/Trainees");
        }

        public async Task<Trainee> GetTraineeDetails(int TraineeId)
        {
            return await httpClient.GetFromJsonAsync<Trainee>("/api/Trainees/" + TraineeId);
        }

        public async Task UpdateTrainee(Trainee Trainee)
        {
            await httpClient.PutAsJsonAsync("/api/Trainees/" + Trainee.TraineeId, Trainee);
        }
    }
}
