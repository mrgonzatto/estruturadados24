using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilhas
{
    public enum Gender{
        Porno, Romance, Terror
    }

    public class Livro
    {
        public string Nome { get; set; }
        public List<Gender> Genero { get; set; }
    }
}