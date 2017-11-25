using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnimal.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public List<string> Hints { get; set; }
    }
}
