using System;

namespace Assets.Scripts
{
    public class BasePlayer : IBasePlayer
    {
        private static BasePlayer _Instance;
        public IBaseClass BaseClass { get; set; }
        public ISubclass SecondaryClass { get; set; }
        public ISubclass TertiaryClass { get; set; }

        private BasePlayer()
        {
        }

        public static BasePlayer GetInstance()
        {
            return _Instance != null ? _Instance : new BasePlayer();
        }

        public void BaseAbilityOne()
        {
            BaseClass.AbilityOne();
        }

        public void BaseAbilityTwo()
        {
            BaseClass.AbilityTwo();
        }

        public void BaseAbilityThree()
        {
            BaseClass.AbilityThree();
        }
        
        public void SecondaryAbilityOne()
        {
            SecondaryClass.AbilityOne();
        }
        
        public void SecondaryAbilityTwo()
        {
            SecondaryClass.AbilityTwo();
        }

        public void SecondaryAbilityThree()
        {
            SecondaryClass.AbilityThree();
        }

        public void TertiaryAbilityOne()
        {
            TertiaryClass.AbilityOne();
        }

        public void TertiaryAbilityTwo()
        {
            TertiaryClass.AbilityTwo();
        }

        public void TertiaryAbilityThree()
        {
            TertiaryClass.AbilityThree();
        }
    }
}