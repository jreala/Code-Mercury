using UnityEngine;

namespace Assets.Scripts.Player
{
    public class Attributes : MonoBehaviour
    {
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        private IBasePlayer _basePlayer;

        void Start()
        {
            _basePlayer = GetComponent<PlayableCharacter>().player;
            CalculateAttributePoints();
            Debug.Log(ToString());
        }

        public static Attributes operator +(Attributes a, Attributes b)
        {
            if (b == null) return a;

            return new Attributes
            {
                Health = a.Health + b.Health,
                Energy = a.Energy + b.Energy,
                Attack = a.Attack + b.Attack,
                Defense = a.Defense + b.Defense,
                Speed = a.Speed + b.Speed
            };
        }

        private void CalculateAttributePoints()
        {
            var attributes = _basePlayer.SecondaryClass != null
                            ? _basePlayer.TertiaryClass != null
                            ? _basePlayer.BaseClass.GetAttributes() + _basePlayer.SecondaryClass.GetAttributes() + _basePlayer.TertiaryClass.GetAttributes()
                            : _basePlayer.BaseClass.GetAttributes() + _basePlayer.SecondaryClass.GetAttributes()
                            : _basePlayer.BaseClass.GetAttributes();

            Health = attributes.Health;
            Energy = attributes.Energy;
            Attack = attributes.Attack;
            Defense = attributes.Defense;
            Speed = attributes.Speed;
        }

        public override string ToString()
        {
            return "Health: " + Health + "-- Energy: " + Energy + " -- Attack: " + Attack + "-- Defense: " + Defense + "-- Speed: " + Speed;
        }
    }
}