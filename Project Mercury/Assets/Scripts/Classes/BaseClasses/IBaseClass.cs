using Assets.Scripts.Player;

namespace Assets.Scripts.Classes.BaseClasses
{
    public interface IBaseClass : IActivateAbilities
    {
        Attributes GetAttributes();
        ClassName GetClassName();
    }
}