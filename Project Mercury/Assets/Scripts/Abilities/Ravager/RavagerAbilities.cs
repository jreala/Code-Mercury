using UnityEngine;

namespace Assets.Scripts.Abilities.Ravager
{
    public enum RavagerAbilityList
    {
        Bloodweapon,
        Overdrive,
        DestructiveForce
    }

    public class RavagerAbilities
    {
        public void Bloodweapon()
        {
            Debug.Log("Steals the health of his enemies equivalent to damage dealt");
        }

        public void Overdrive()
        {
            Debug.Log("Greatly increases power beyond natural limits");
        }

        public void DestructiveForce()
        {
            Debug.Log("Strikes the ground, paralyzing enemies with fear");
        }
    }
}
