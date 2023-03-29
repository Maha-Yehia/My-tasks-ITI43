using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class PlayGroundBuilder2 : IPlayGroundBuilder
    {
        PlayGround _playGround = new PlayGround();
        public void BuildAudience()
        {
            _playGround.Add("Build Audience 2");
        }

        public void BuildGallery()
        {
            _playGround.Add("Build Gallery 2");
        }

        public void BuildGroundSurface()
        {
            _playGround.Add("Build GroundSurface 2");
        }

        public PlayGround GetResult()
        {
            return _playGround;
        }
    }
}
