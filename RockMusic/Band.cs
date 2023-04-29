using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockMusic
{
    public class Band
    {
        public string bandName;
        public string singer;
        public string guitarist;
        public string bassist;
        public string drummer;
        
        public Band()
        {
            return;
        }

        public Band(string name, string member1, string member2, string member3, string member4)
        {
            this.bandName = name;
            this.singer = member1;
            this.guitarist = member2;
            this.bassist = member3;
            this.drummer = member4;
        }

        public void Info()
        {
            Console.WriteLine("Band Name: {0}\nSinger: {1}\nGuitarist: {2}\nBassist: {3}\nDrummer: {4}\n",bandName, singer, guitarist, bassist, drummer);
        }

 
    }
}
