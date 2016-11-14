using Assets.Scripts.Dto;
using Assets.Scripts.Abilities.Brawler;

namespace Assets.Scripts.Classes.BaseClasses
{
    public class Brawler : IBaseClass, IHaveAbilities<BrawlerAbilityList>
    {
        private const int _health = 200;
        private const int _energy = 100;
        private const int _attack = 125;
        private const int _defense = 125;
        private const int _speed = 100;
        
        public BrawlerAbilityList AbilityOne { get; set; }
        public BrawlerAbilityList AbilityTwo { get; set; }
        public BrawlerAbilityList AbilityThree { get; set; }
        
        public AttributesDto GetAttributes()
        {
            return new AttributesDto
            {
                Health = _health,
                Energy = _energy,
                Attack = _attack,
                Defense = _defense,
                Speed = _speed
            };
        }

        public ClassName GetClassName()
        {
            return ClassName.Brawler;
        }

        public void UseAbilityOne()
        {
            BrawlerAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            BrawlerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            BrawlerAbilityFactory.ActivateAbility(AbilityThree);
        }
    }
}
