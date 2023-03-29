using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Director
    public class GameEngine
    {
        public void construct(IPlayGroundBuilder builder)
        {
            builder.BuildAudience();
            builder.BuildGroundSurface();
            builder.BuildGallery();
        }
    }
}
