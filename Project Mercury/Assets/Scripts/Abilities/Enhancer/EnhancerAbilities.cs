using UnityEngine;

namespace Assets.Scripts.Abilities.Enhancer
{
    public enum EnhancerAbilityList
    {
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class EnhancerAbilities
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
