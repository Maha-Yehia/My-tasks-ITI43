using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Builder
    public interface IPlayGroundBuilder
    {
        public void BuildGallery();
        public void BuildGroundSurface();
        public void BuildAudience();
        public PlayGround GetResult();
    }
}
