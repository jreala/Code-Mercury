using Assets.Scripts.Dto;
using Assets.Scripts.Abilities;

namespace Assets.Scripts.Classes.SubClasses
{
    public interface ISubclass : IActivateAbilities
    {
        AttributesDto GetAttributes();
        ClassName GetClassName();
    }
}
