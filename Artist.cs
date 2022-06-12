using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    public class Artist : ICreation
    {
        int numberOfMusic;
        int numberOfAlbum;

        public Artist(int numberOfMusic, int numberOfAlbum) {
            this.numberOfMusic = numberOfMusic;
            this.numberOfAlbum = numberOfAlbum;
        }

        public int NumberOfAlbum()
        {
            throw new NotImplementedException();
        }

        public int NumberOfMusic()
        {
            throw new NotImplementedException();
        }
    }
}
