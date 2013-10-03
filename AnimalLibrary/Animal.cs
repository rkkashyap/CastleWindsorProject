using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public class Animal : IAnimal
    {

        public string Speak()
        {
           return  "Hey I am Animal";
        }
    }
}
