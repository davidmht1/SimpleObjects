using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockMusic
{
    public class RockMusic
    {
        public Band band;
        public RockMusic()
        {
            band = new Band();
        }

        static void Main(string[] args)
        {

            RockMusic genre = new RockMusic();

            genre.band.bandName = "Van Halen";

            Band beatles = new Band();
            Band ledZeppelin = new Band();

            beatles.Info();

            genre.band.Info();
        }
    }

    
}
