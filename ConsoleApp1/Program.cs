using System;

namespace ModelZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo1 = new Zoo("Barlad", "adress1");
            Zoo zoo2 = new Zoo("Bucuresti", "adress2");

            Reptile americanAlligator = new Reptile(Zoo.GenerateNewAnimalID(), AGender.Male, Reptile.Type.Aligator,30,"frogs antelope","need a lake","John");
            Reptile greenIguana = new Reptile(Zoo.GenerateNewAnimalID(), AGender.Female, Reptile.Type.Lizard, 25, "snakes", "dry space", "Iguana");

            Bird cattleEgret = new Bird(Zoo.GenerateNewAnimalID(), AGender.Female, Bird.Type.Heron, 12, "fish", "need access to the water", "Cattle Egret");
            Bird kookaburra = new Bird(Zoo.GenerateNewAnimalID(),AGender.Male,Bird.Type.Kingfisher,15,"snails","warm space","Kookaburra");

            Mammal platypus = new Mammal(Zoo.GenerateNewAnimalID(), AGender.Female, Mammal.Type.EggLayngMamal, 5, "fish bugs", "need access to the water", "Platypus");
            Mammal hippopotamus = new Mammal(Zoo.GenerateNewAnimalID(), AGender.Male, Mammal.Type.HoofedMamals, 500, "grass", "need a lake", "Hippopotamus");

            Mammal horse = new Mammal(Zoo.GenerateNewAnimalID(), AGender.Male, Mammal.Type.HoofedMamals, 200, "grass");

            zoo1.AddNewAnimal(americanAlligator);
            zoo2.AddNewAnimal(americanAlligator);
            zoo2.AddNewAnimal(greenIguana);
            zoo1.AddNewAnimal(cattleEgret);
            zoo2.AddNewAnimal(kookaburra);
            zoo1.AddNewAnimal(platypus);
            zoo2.AddNewAnimal(hippopotamus);
            zoo1.AddNewAnimal(horse);

            zoo1.NextDay();
            zoo2.NextDay();

            zoo1.TransferAnimal(zoo2, americanAlligator);

            zoo1.TransferAnimal(zoo2, hippopotamus);
            zoo2.TransferAnimal(zoo1, cattleEgret);

            zoo1.NextDay();
            zoo2.NextDay();
        }
    }
}
