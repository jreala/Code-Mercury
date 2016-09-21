using System;

namespace Assets.Scripts
{
    public class BasePlayer : IBasePlayer
    {
        private static BasePlayer _Instance;
        private IBaseClass baseClass;
        private ISubclass secondaryClass;
        private ISubclass tertiaryClass;

        public BasePlayer()
        {
        }

        public static BasePlayer GetInstance()
        {
            return _Instance != null ? _Instance : new BasePlayer();
        }

        public void BaseAbilityOne()
        {
            baseClass.AbilityOne();
        }

        public void BaseAbilityTwo()
        {
            baseClass.AbilityTwo();
        }

        public void BaseAbilityThree()
        {
            baseClass.AbilityThree();
        }
        
        public void SecondaryAbilityOne()
        {
            secondaryClass.AbilityOne();
        }
        
        public void SecondaryAbilityTwo()
        {
            secondaryClass.AbilityTwo();
        }

        public void SecondaryAbilityThree()
        {
            secondaryClass.AbilityThree();
        }

        public void TertiaryAbilityOne()
        {
            tertiaryClass.AbilityOne();
        }

        public void TertiaryAbilityTwo()
        {
            tertiaryClass.AbilityTwo();
        }

        public void TertiaryAbilityThree()
        {
            tertiaryClass.AbilityThree();
        }
    }
}