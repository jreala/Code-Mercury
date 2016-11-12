using Assets.Scripts.Player;
using Assets.Scripts.Abilities;

namespace Assets.Scripts.Classes.BaseClasses
{
    public interface IBaseClass : IActivateAbilities
    {
        Attributes GetAttributes();
        ClassName GetClassName();
    }
}