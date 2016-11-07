using Assets.Scripts.Classes.BaseClasses;
using Assets.Scripts.Classes.SubClasses;

namespace Assets.Scripts.Player
{
    public class BasePlayer : IBasePlayer
    {
        private static BasePlayer _instance;
        public IBaseClass BaseClass { get; private set; }
        public ISubclass SecondaryClass { get; private set; }
        public ISubclass TertiaryClass { get; private set; }

        private BasePlayer()
        {
        }
         
        public static BasePlayer GetInstance()
        {
            return _instance != null ? _instance : new BasePlayer();
        }

        public void SetBaseClass(IBaseClass baseClass)
        {
            BaseClass = baseClass;
        }

        public void SetSecondaryClass(ISubclass secondaryClass)
        {
            SecondaryClass = secondaryClass;
        }

        public void SetTertiaryClass(ISubclass tertiaryClass)
        {
            TertiaryClass = tertiaryClass;
        }

        public void BaseAbilityOne()
        {
            BaseClass.UseAbilityOne();
        }

        public void BaseAbilityTwo()
        {
            BaseClass.UseAbilityTwo();
        }

        public void BaseAbilityThree()
        {
            BaseClass.UseAbilityThree();
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