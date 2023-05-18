using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoC
{
    internal class Person
        {
        /* private Velo velo; 
         private Bus bus; */
        private IMoyenDeDeplacement moyenDeDeplacement;
    
        public Person(string prenom,IMoyenDeDeplacement moyenDeDeplacement) 
        {
            this.Prenom = prenom;
            this.moyenDeDeplacement = moyenDeDeplacement;

           /* this.velo = velo;
            this.bus = bus;*/
        }

        public void AllerAuTravail(Destination destination)
        {
            Console.WriteLine($"{this.Prenom}, je vais ici : {destination.Address}");
            //this.velo.Emmener(this, destination);
            //this.bus.Emmener(this, destination);
            this.moyenDeDeplacement.Emmener(this,destination);

        }
        public string Prenom { get; set; }
    }
}
