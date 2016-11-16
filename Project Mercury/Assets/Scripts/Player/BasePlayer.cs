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
         
        public static IBasePlayer GetInstance()
        {
            if(_instance == null)
            {
                _instance = new BasePlayer();
            }
            return _instance;
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
            SecondaryClass.UseAbilityOne();
        }
        
        public void SecondaryAbilityTwo()
        {
            SecondaryClass.UseAbilityTwo();
        }

        public void SecondaryAbilityThree()
        {
            SecondaryClass.UseAbilityThree();
        }

        public void TertiaryAbilityOne()
        {
            TertiaryClass.UseAbilityOne();
        }

        public void TertiaryAbilityTwo()
        {
            TertiaryClass.UseAbilityTwo();
        }

        public void TertiaryAbilityThree()
        {
            TertiaryClass.UseAbilityThree();
        }

        public override string ToString()
        {
            var player = "Base Class : " + BaseClass + "\t Instance: " + _instance;
            return player;
        }
    }
}