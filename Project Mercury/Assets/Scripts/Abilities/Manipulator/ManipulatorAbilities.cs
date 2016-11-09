using UnityEngine;

namespace Assets.Scripts.Abilities.Manipulator
{
    public enum ManipulatorAbilityList
    {
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class ManipulatorAbilities
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
