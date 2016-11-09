using UnityEngine;

namespace Assets.Scripts.Abilities.Invoker
{
    public enum InvokerAbilityList
    {
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class InvokerAbilities
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
