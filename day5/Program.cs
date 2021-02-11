using System;
using System.Collections;
using System.Collections.Generic;

namespace day5
{

    class animal
    {
        public string name;
        public int age;
        public string type;
        public bool IsDied = false;
        public event Action<animal> animalZoo;
        public animal() { }
        public animal(string n, int a, string t)
        {
            name = n;
            age = a;
            type = t;
           
        }
        public override string ToString()
        {
            return $"{type}|{name}|{age}";
        }
        //if it is static -and animal passed to it- will make error in delegate animalZoo  ??
        public  void Died()
        {
            this.IsDied = true;
            if (animalZoo != null)
                animalZoo(this);
        }

    }
    class bird : animal
    {
        public bird()
        {

        }
        public bird(string n, int a = 9) : base(n, a, "bird")
        {

        }
        public override string ToString()
        {
            return $"{type}|{name}|{age}";
        }
       
    }
    class mammal : animal
    {
        public mammal()
        {

        }
        public mammal(string n, int a = 12) : base(n, a, "mammal")
        {
           
        }
        public override string ToString()
        {
            return $"{type}|{name}|{age}";
        }

    }
    class lion : mammal
    {
        public lion()
        {
            base.name = "lion";
            base.type = "mammal";
        }
    }
    class sparrow : bird
    {
        public sparrow()
        {
            base.name = "sparrow";
            base.type = "bird";
        }
    }
    class elephant : mammal
    {
        public elephant()
        {
            base.name = "elephant";
            base.type = "mammal";
        }
    }
    class pigeon : bird
    {
        public pigeon()
        {
            base.name = "pigeo";
            base.type = "bird";
        }
    }

    class Program
    {
        static void Main(string[] args)

        {
            zoo z = new zoo();
            animal aa = new lion();
            animal aa1= new sparrow();
            animal aa2 = new elephant();
            z.add(aa); z.add(aa1); z.add(aa2);

            /*foreach (bird b in z.Birds)
            // (Birds must be a read-only collection) property return ieumrable that have type bird
            {
                Console.WriteLine(b);
            }

            foreach ( mammal m in z.Mammals)
            // (Mammals must be a read-only collection) property return ieumrable that have type bird

            {
                Console.WriteLine(m);
            }*/
            
            //foreach (animal a in z.Animals)
            //{
            //    Console.WriteLine(a);
            //}
            aa.Died();
            foreach (animal a in z.Animals)
            {
                Console.WriteLine(a);
            }




        }
    }
}
