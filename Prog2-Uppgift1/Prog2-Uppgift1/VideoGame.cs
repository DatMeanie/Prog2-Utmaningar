using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Uppgift1
{
    class VideoGame : Media
    {
        string gameEngine;
        public VideoGame(string gameEngine, string name, string maker, string releaseDate, string type, long price) : base(name, maker, releaseDate, type, price)
        {
            this.gameEngine = gameEngine;
        }
        public override string ToString()
        {
            return $"Namn: {name}\nSkapare: {maker}\nSpelmotor: {gameEngine}\nSläppdatum: {releaseDate}\nTyp: {type}\nPris: {price}";
        }
    }
}
