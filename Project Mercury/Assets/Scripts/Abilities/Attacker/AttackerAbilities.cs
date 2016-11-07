using UnityEngine;

namespace Assets.Scripts.Abilities.Attacker
{
    public enum AttackerAbilityList
    {
        Pierce,
        Berserk,
        Bloodthirst
    }

    public class AttackerAbilities
    {
        public void Pierce()
        {
            Debug.Log("Blood drips");
        }

        public void Berserk()
        {
            Debug.Log("-Goes into a frenzy-");
        }

        public void Bloodthirst()
        {
            Debug.Log("-Bears teeth-");
        }
    }
}
