using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsMvc.Models
{
    public interface IData
    {
        public List<Animal> AnimalsList { get; set; }
        public List<Animal> AnimalsInitializeData();
        public Animal GetAnimalById(int? id);
    }
}
