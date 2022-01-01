using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
        public void Run()
        {
            var mf = new MegaFactory();

            var df = mf.GetFactory("Dog");
            var doge = df.CreateAnimal("Hunden Bilbo");

            var cf = mf.GetFactory("Cat");
            var garfield = cf.CreateAnimal("Katten Garfield");

            
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(doge);
            animals.Add(garfield);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
