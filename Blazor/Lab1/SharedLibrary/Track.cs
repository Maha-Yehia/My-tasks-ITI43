using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Track
    {
        public int TrackID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Trainee> Trainees { get; set;}
    }
}
