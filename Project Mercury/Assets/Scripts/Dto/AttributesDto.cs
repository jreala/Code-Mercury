namespace Assets.Scripts.Dto
{
    public class AttributesDto
    {
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public static AttributesDto operator +(AttributesDto a, AttributesDto b)
        {
            if (b == null) return a;

            return new AttributesDto
            {
                Health = a.Health + b.Health,
                Energy = a.Energy + b.Energy,
                Attack = a.Attack + b.Attack,
                Defense = a.Defense + b.Defense,
                Speed = a.Speed + b.Speed
            };
        }
    }
}