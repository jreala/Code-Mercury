using UnityEngine;

namespace Assets.Scripts.Abilities.Defender
{
    public enum DefenderAbilityList
    {
        None,
        IronStance,
        Retaliate,
        BulkUp
    }

    public class DefenderAbilities
    {
        public void IronStance()
        {
            Debug.Log("-Hardens body-");
        }

        public void Retaliate()
        {
            Debug.Log("CLINK AAAAAARRRGGGGGGGGGHHHH");
        }

        public void BulkUp()
        {
            Debug.Log("-Muscles grow larger-");
        }
    }
}
