using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class PlayGroundBuilder1 :IPlayGroundBuilder
    {
        PlayGround _playGround = new PlayGround();
        public void BuildAudience()
        {
            _playGround.Add("Build Audience 1");
        }

        public void BuildGallery()
        {
            _playGround.Add("Build Gallery 1");
        }

        public void BuildGroundSurface()
        {
            _playGround.Add("Build GroundSurface 1");
        }

        public PlayGround GetResult()
        {
            return _playGround;
        }
    }
}
