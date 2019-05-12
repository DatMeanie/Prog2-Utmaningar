using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Uppgift1
{
    class PrintedMedia : Media
    {
        protected int pages;
        protected bool havePictures;

        public PrintedMedia(int pages, bool havePictures, string name, string maker, string releaseDate, string type, long price) : base(name, maker, releaseDate, type, price)
        {
            this.pages = pages;
            this.havePictures = havePictures;
        }
    }
}
