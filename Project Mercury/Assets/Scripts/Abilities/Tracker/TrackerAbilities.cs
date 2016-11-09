using UnityEngine;

namespace Assets.Scripts.Abilities.Tracker
{
    public enum TrackerAbilityList
    {
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class TrackerAbilities
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
