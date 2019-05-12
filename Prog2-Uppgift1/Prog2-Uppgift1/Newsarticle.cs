using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Uppgift1
{
    class Newsarticle : PrintedMedia
    {
        string newspaper;
        public Newsarticle(string newspaper, int pages, bool havePictures, string name, string maker, string releaseDate, string type, long price) : base(pages, havePictures, name, maker, releaseDate, type, price)
        {
            this.newspaper = newspaper;
        }
        public override string ToString()
        {
            string result = havePictures ? "Ja" : "Nej";
            return $"Namn: {name}\nFörfattare: {maker}\nTidning: {newspaper}\nSläppdatum: {releaseDate}\nGenre: {type}\nAntal sidor: {pages}\nHar bilder: {result}\nPris: {price}";
        }
    }
}
