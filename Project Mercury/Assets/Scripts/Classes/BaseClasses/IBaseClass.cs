using Assets.Scripts.Player;

namespace Assets.Scripts.Classes.BaseClasses
{
    public interface IBaseClass
    {
        void AbilityOne();
        void AbilityTwo();
        void AbilityThree();

        Attributes GetAttributes();
    }
}