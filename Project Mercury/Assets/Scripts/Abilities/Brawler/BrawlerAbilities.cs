using UnityEngine;

namespace Assets.Scripts.Abilities.Brawler
{
    public enum BrawlerAbilityList
    {
        None,
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class BrawlerAbilities
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
