using UnityEngine;

namespace Assets.Scripts.Abilities.Ravager
{
    public enum RavagerAbilityList
    {
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class RavagerAbilities
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
