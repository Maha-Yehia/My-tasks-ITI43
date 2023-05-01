using Microsoft.AspNetCore.Components;
using SharedLibrary;

namespace TraineesTracks.Pages
{
    public partial class TraineeDetails
    {
        [Parameter]
        public int TraineeID { get; set; }
        //public string TraineeID { get; set; }
        public Trainee CurrTrainee { get; set; }

        protected override Task OnInitializedAsync()
        {
            CurrTrainee = MockContext.Trainees.FirstOrDefault(t => t.TraineeID == TraineeID);
            return base.OnInitializedAsync();
        }
    }
}
