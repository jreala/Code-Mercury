using Assets.Scripts.Player;
using Assets.Scripts.Abilities;

namespace Assets.Scripts.Classes.SubClasses
{
    public interface ISubclass : IActivateAbilities
    {
        Attributes GetAttributes();
        ClassName GetClassName();
    }
}
