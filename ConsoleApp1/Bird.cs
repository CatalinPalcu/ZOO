using System;
using System.Collections.Generic;
using System.Text;

namespace ModelZoo
{
    class Bird : Animal
    {
        public enum Type
        {
            Crane,
            Gull,
            Heron,
            Kingfisher,
            Nightjar,
            Ostriche,
            Owl,
            Parrot,
            Penguin,
            PerchingBird,
            Pheasant,
            Pigeon,
            Turaco,
            Vulture,
            Waterfowl,
            Woodpecker
        }

        private readonly Type type;

        public string GetType
        {
            get { return this.type.ToString(); }
        }

        public Bird(int _idNumber, AGender _gender, Type _type) : base(_idNumber, _gender)
        {
            this.type = _type;
        }

        public Bird(int _idNumber, AGender _gender, Type _type, int _spaceRequired, string _favouriteFood = "", string _habitatCondition = "", string _name = "[no name]")
            : base(_idNumber, _gender, _spaceRequired, _favouriteFood, _habitatCondition, _name)
        {
            this.type = _type;
        }

        public override string ToString()
        {
            return String.Format($"{Name} with the ID : {IdNumber} is a {Gender} Bird, type {GetType}\n" +
                $"\t - needs at least {SpaceRequired} square metters to live properly\n" +
                $"\t - the special habitat conditions are {SpecialHabitatConditions}\n" +
                $"\t - the favourite food is : {FavouriteFood}");
        }
    }
}
