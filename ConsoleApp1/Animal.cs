using System;
using System.Collections.Generic;
using System.Text;

namespace ModelZoo
{
    public enum AGender
    {
        Male = 1,
        Female
    }
    class Animal
    {
        private string favouriteFood;
        private readonly int idNumber;
        private int spaceRequired = 1;
        private readonly AGender geder;

        public string Name { get; set;}
        public string SpecialHabitatConditions { get; set; }

        public int IdNumber
        {
            get { return this.idNumber; }
        }

        public string Gender
        {
            get { return this.geder.ToString(); }
        }

        public string FavouriteFood
        {
            get { return this.favouriteFood; }
            set { this.favouriteFood = value; }
        }

        public int SpaceRequired
        {
            get { return this.spaceRequired; }
            set { this.spaceRequired = (value >= 1 ? value : this.spaceRequired); }
        }

        public Animal(int _idNumber,AGender _gender) : this(_idNumber,_gender, 1)
        {

        }

        public Animal (int _idNumber,AGender _gender, int _spaceRequired, string _favouriteFood = "" ,string _habitatCondition="",string _name="[no name]")
        {
            this.idNumber = _idNumber;
            this.geder = _gender;
            this.SpaceRequired = _spaceRequired;
            this.FavouriteFood = _favouriteFood;
            this.SpecialHabitatConditions = _habitatCondition;
            this.Name = _name;
        }

        public void AddFavouriteFood(string newFavouriteFood)
        {
            this.favouriteFood +=String.Format(" {0}", newFavouriteFood);
        }

        public void RemoveFoodFromList(string food)
        {
            this.favouriteFood = this.favouriteFood.Replace(String.Format(" {0}", food),String.Empty).Replace(food,String.Empty);
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eats now {favouriteFood}");
        }

    }
}
