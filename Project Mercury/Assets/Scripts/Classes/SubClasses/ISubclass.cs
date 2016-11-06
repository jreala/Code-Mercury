using Assets.Scripts.Player;

namespace Assets.Scripts.Classes.SubClasses
{
    public interface ISubclass
    {
        void AbilityOne();
        void AbilityTwo();
        void AbilityThree();

        Attributes GetAttributes();
    }
}
