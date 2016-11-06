namespace Assets.Scripts.Player
{
    public class Attributes
    {   
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public static Attributes operator+ (Attributes a, Attributes b)
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

        public override string ToString()
        {
            return "Health: " + Health + "-- Energy: " + Energy + " -- Attack: " + Attack + "-- Defense: " + Defense + "-- Speed: " + Speed;
        }
    }
}