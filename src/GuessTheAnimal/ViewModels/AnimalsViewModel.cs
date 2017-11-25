using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GuessTheAnimal.Models;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace GuessTheAnimal.ViewModels
{
    public class AnimalsViewModel : ObservableCollection<Animal>
    {
        public AnimalsViewModel()
        {
            // Read the json file
            // Add the animals into collection.



        }

        public static IList<Animal> GetAnimalsFromJson(string filePath)
        {
            JObject o = JObject.Parse(File.ReadAllText(filePath));
            JArray a = (JArray) o["animals"];

            IList<Animal> animals = a.ToObject<IList<Animal>>();

            return animals;
        }
    }
}
