using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Uppgift1
{
    class Book : PrintedMedia
    {
        string publisher;

        public Book(string publisher, int pages, bool havePictures, string name, string maker, string releaseDate, string type, long price) : base(pages, havePictures, name, maker, releaseDate, type, price)
        {
            this.publisher = publisher;
        }
        public override string ToString()
        {
            string result = havePictures ? "Ja" : "Nej";
            return $"Namn: {name}\nFörfattare: {maker}\nBokförlag: {publisher}\nSläppdatum: {releaseDate}\nGenre: {type}\nAntal sidor: {pages}\nHar bilder: {result}\nPris: {price}";
        }
    }
}
