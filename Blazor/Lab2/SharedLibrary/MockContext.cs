using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class MockContext
    {
        public static List<Track> Tracks = new List<Track>
            {
                new Track {TrackID = 1, Name = "SWA", Description="Software Architecture"},
                new Track {TrackID = 2, Name = "PD", Description="Proffestional Web"},
                new Track { TrackID = 3, Name = "Mobile" , Description="Cross Platform"},
                new Track { TrackID = 4, Name = "UI" , Description = "User Interface"},
                new Track { TrackID = 5, Name = "Testing" , Description = ""}
            };

        public static List<Trainee> Trainees = new List<Trainee>()
        {
            new Trainee
            {
                TraineeID = 1,
                TrackID = 1,
                Track = Tracks.Find(t => t.TrackID == 1),
                BirthDate = new DateTime(1999, 11, 16),
                Email = "eman@test.com",
                Name = "Eman",
                Gender = Gender.Female,
                MobileNo = "01000101010",
                IsGraduated = true
            },

            new Trainee
            {
                TraineeID = 2,
                TrackID = 2,
                Track = Tracks.Find(t => t.TrackID == 2),
                BirthDate = new DateTime(1989, 3, 11),
                Email = "ahmed@test.com",
                Name = "Ahmed",
                Gender = Gender.Male,
                MobileNo = "01000101010",
                IsGraduated = false
            }
        };
    }
}
