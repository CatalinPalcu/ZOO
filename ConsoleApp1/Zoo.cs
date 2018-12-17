using System;
using System.Collections.Generic;
using System.Text;

namespace ModelZoo
{
    class Zoo
    {
        private List<Animal> listOfAnimals;

        private static List<int> animalCodes;

        private string name;
        private string adress;
        
        public string Name
        {
            get { return this.name; }
        }


        public static int GenerateNewAnimalID()
        {
            Random r = new Random();
            int id = 0;
            do
            {
                id = r.Next(1000, 10000) * 10000 + r.Next(0, 10000);
            } while (animalCodes.Contains(id));

            return id;
        }

        static Zoo ()
        {
            animalCodes = new List<int>();
        }

        public Zoo (string _name, string _adress)
        {
            this.name = _name;
            this.adress = _adress;
            listOfAnimals = new List<Animal>();
        }

        public int HaveAnimal(int id)
        {
            for (int i=0;i<listOfAnimals.Count;i++)
            {
                if (listOfAnimals[i].IdNumber == id)
                    return i;
            }
            return -1;
        }

        public void NextDay()
        {
            Console.WriteLine("Is a new day at the zoo {0}",this.name);
            foreach (Animal a in listOfAnimals)
                a.Eat();
        }

        public void AddNewAnimal(Animal a)
        {
            if (Zoo.animalCodes.IndexOf(a.IdNumber) < 0)
            {
                Zoo.animalCodes.Add(a.IdNumber);
                this.listOfAnimals.Add(a);
                Console.WriteLine($"Zoo {name} recive a new animal\n{a}");
            }
            else
            {
                Console.WriteLine("This animal belongs to another zoo");
            }

        }

        public void TransferAnimal(Zoo zoo, Animal a)
        {
            int index = zoo.HaveAnimal(a.IdNumber);
            if (index < 0)
            {
                Console.WriteLine("This transfer is not possible");
            } 
            else
            {
                Console.WriteLine($"{zoo.Name} do you agree with this transfer? y/n");
                string response = Console.ReadLine();
                if ("yY".IndexOf(response) <0)
                {
                    Console.WriteLine("This transfer is not possible");
                }
                else
                {
                    this.listOfAnimals.Add(a);
                    zoo.listOfAnimals.RemoveAt(index);
                }
            }
        }
    }
}
