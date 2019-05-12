using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Uppgift1
{
    class Website : Media
    {
        string link;
        public Website(string link, string name, string maker, string releaseDate, string type, long price) : base(name, maker, releaseDate, type, price)
        {
            this.link = link;
        }
        public override string ToString()
        {
            return $"Namn: {name}\nSkapare: {maker}\nLänk: {link}\nSläppdatum: {releaseDate}\nTyp: {type}\nPris: {price}";
        }
    }
}
