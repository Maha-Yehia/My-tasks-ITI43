using Microsoft.AspNetCore.Components;
using SharedLibrary;
using TraineesTracks.Services;

namespace TraineesTracks.Pages
{
    public partial class TraineeDetails
    {
        [Parameter]
        public int TraineeID { get; set; }
        //public string TraineeID { get; set; }
        public Trainee? CurrTrainee { get; set; }
        public IEnumerable<Track>? tracks { get; set; }

        [Inject]
        public ITraineeDataService? traineeDataService { get; set; }

        [Inject]
        public ITrackDataService? trackDataService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            tracks = await trackDataService.GetAllTracks();
            CurrTrainee = await traineeDataService.GetTraineeDetails(TraineeID);
        }

    }
}
