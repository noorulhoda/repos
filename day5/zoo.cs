using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace day5
{
    class zoo
    {
        List<animal> animals=new List<animal>();
        List<mammal> mammals=new List<mammal>();
        List<bird>birds= new List<bird>();

        public IEnumerable<animal> Animals
        {
            get
            {
                return animals;
            }
        }
        public IEnumerable<mammal> Mammals
        {
            get
            {
                return mammals;
            }
        }
        public IEnumerable<bird> Birds
        { 
             get
             {
                return birds;
              }
        }
        public void add(animal a)
        {
            if (a.age < 10)
            {

                animals.Add(a);
                if (a.type == "bird")
                {
                    birds.Add(a as bird);

                }
                if (a.type == "mammal")
                {
                    mammals.Add( a as mammal);  
                }
            }
            a.animalZoo += removeDied;

        }
        public void removeDied(animal a)
        {
            if (a.IsDied == true)
            {
                animals.Remove(a);
                if (a.type == "bird")
                {
                    birds.Remove(a as bird);
                }
                if (a.type == "mammal")
                {
                    mammals.Remove(a as mammal);
                }
            }
        }
    }
}
