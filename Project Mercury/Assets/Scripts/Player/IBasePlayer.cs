using Assets.Scripts.Classes.BaseClasses;
using Assets.Scripts.Classes.SubClasses;

namespace Assets.Scripts.Player
{
    public interface IBasePlayer
    {
        void SetBaseClass(IBaseClass baseClass);
        void SetSecondaryClass(ISubclass secondaryClass);
        void SetTertiaryClass(ISubclass tertiaryClass);

        void BaseAbilityOne();
        void BaseAbilityTwo();
        void BaseAbilityThree();

        void SecondaryAbilityOne();
        void SecondaryAbilityTwo();
        void SecondaryAbilityThree();

        void TertiaryAbilityOne();
        void TertiaryAbilityTwo();
        void TertiaryAbilityThree();
    }
}
