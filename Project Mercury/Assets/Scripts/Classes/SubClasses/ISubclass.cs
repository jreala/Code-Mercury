using Assets.Scripts.Player;

namespace Assets.Scripts.Classes.SubClasses
{
    public interface ISubclass : IActivateAbilities
    {
        Attributes GetAttributes();
    }
}
