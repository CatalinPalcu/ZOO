using System;
using System.Collections.Generic;
using System.Text;

namespace ModelZoo
{
    class Mammal:Animal
    {
        public enum Type
        {
            Anteater,
            EggLayngMamal,
            Hedgehog,
            Rabbit,
            Carnivore,
            Elephant,
            HoofedMamals,
            Monkey,
            PouchedMammal,
            Rodent,
            SeaLions,
            Seals
        }

        private readonly Type type;

        public string GetType
        {
            get { return this.type.ToString(); }
        }

        public Mammal(int _idNumber, AGender _gender, Type _type) : base(_idNumber, _gender)
        {
            this.type = _type;
        }

        public Mammal(int _idNumber, AGender _gender, Type _type, int _spaceRequired, string _favouriteFood = "", string _habitatCondition = "", string _name = "[no name]")
            : base(_idNumber, _gender, _spaceRequired, _favouriteFood, _habitatCondition, _name)
        {
            this.type = _type;
        }

        public override string ToString()
        {
            return String.Format($"{Name} with the ID : {IdNumber} is a {Gender} Mammal, type {GetType}\n" +
                $"\t - needs at least {SpaceRequired} square metters to live properly\n" +
                $"\t - the special habitat conditions are {SpecialHabitatConditions}\n" +
                $"\t - the favourite food is : {FavouriteFood}");
        }
    }
}
