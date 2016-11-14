using Assets.Scripts.Dto;
using Assets.Scripts.Abilities;

namespace Assets.Scripts.Classes.BaseClasses
{
    public interface IBaseClass : IActivateAbilities
    {
        AttributesDto GetAttributes();
        ClassName GetClassName();
    }
}