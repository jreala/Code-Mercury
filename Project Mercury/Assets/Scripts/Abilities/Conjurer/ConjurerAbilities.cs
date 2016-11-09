using UnityEngine;

namespace Assets.Scripts.Abilities.Conjurer
{
    public enum ConjurerAbilityList
    {
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class ConjurerAbilities
    {
        public void BattleCry()
        {
            Debug.Log("RAWWWRRRRRR!!!");
        }

        public void HeavySlash()
        {
            Debug.Log("-Slings sword through the air-");
        }

        public void Taunt()
        {
            Debug.Log("HAHAHAHAHA YOU CALL THAT A PUNCH");
        }
    }
}
