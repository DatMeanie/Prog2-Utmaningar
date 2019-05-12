using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Uppgift1
{
    class Media
    {
        protected string name;
        protected string maker;
        protected string type;
        protected string releaseDate;
        protected long price;

        public Media(string name, string maker, string releaseDate, string type, long price)
        {
            this.name = name;
            this.maker = maker;
            this.releaseDate = releaseDate;
            this.type = type;
            this.price = price;
        }
        public string ReturnName()
        {
            return name;
        }
    }
}
