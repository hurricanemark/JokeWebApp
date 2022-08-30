using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApp.Models
{
    public class Joke
    {
        /* kbrd-shortcut: prop+tab+tab */
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        /* kbrd-shortcut: ctor+tab+tab */
        public Joke()
        {

        }
    }
}
