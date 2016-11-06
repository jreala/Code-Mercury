using System;
using UnityEngine;

using Assets.Scripts.Player;

namespace Assets.Scripts.Classes.BaseClasses
{
    public class Brawler : IBaseClass
    {
        private const int _health = 200;
        private const int _energy = 100;
        private const int _attack = 125;
        private const int _defense = 125;
        private const int _speed = 100;

        public void AbilityOne()
        {
            Debug.Log("BRAWLER Ability One Pressed");
        }

        public void AbilityTwo()
        {
            Debug.Log("BRAWLER Ability Two Pressed");
        }

        public void AbilityThree()
        {
            Debug.Log("BRAWLER Ability Three Pressed");
        }

        public Attributes GetAttributes()
        {
            return new Attributes
            {
                Health = _health,
                Energy = _energy,
                Attack = _attack,
                Defense = _defense,
                Speed = _speed
            };
        }
    }
}
