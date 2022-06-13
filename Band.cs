using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    public class Band : ICreation
    {
        Artist implementation;

        public Band(int numberOfMusic, int numberOfAlbum) {
            implementation = new Artist(numberOfMusic, numberOfAlbum);
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
