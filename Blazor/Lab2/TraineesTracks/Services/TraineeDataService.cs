using SharedLibrary;
using System.Net.Http.Json;

namespace TraineesTracks.Services
{
    public class TraineeDataService : ITraineeDataService
    {
        public HttpClient HttpClient { get; }
        public TraineeDataService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public async Task AddTrainee(Trainee trainee)
        {
            await HttpClient.PostAsJsonAsync("/api/Trainees/", trainee);
        }

        public async Task DeleteTrainee(int TraineeId)
        {
            await HttpClient.DeleteAsync("/api/Trainees/" + TraineeId);
        }

        public async Task<IEnumerable<Trainee>> GetAllTrainees()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Trainee>>("/api/Trainees");
        }

        public async Task<Trainee> GetTraineeDetails(int TraineeId)
        {
            return await HttpClient.GetFromJsonAsync<Trainee>("/api/Trainees/" + TraineeId);
        }

        public async Task UpdateTrainee(Trainee trainee)
        {
            await HttpClient.PutAsJsonAsync("/api/Trainees/"+trainee.TraineeID, trainee);
        }
    }
}
