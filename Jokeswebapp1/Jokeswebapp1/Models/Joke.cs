using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokeswebapp1.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestions { get; set; }
        public string JokeAnswers { get; set; }

        public Joke() {

        }
    }
}
