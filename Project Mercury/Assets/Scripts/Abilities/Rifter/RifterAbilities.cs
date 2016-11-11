using UnityEngine;

namespace Assets.Scripts.Abilities.Rifter
{
    public enum RifterAbilityList
    {
        Backstab,
        Warp,
        Phase
    }

    public class RifterAbilities
    {
        public void Backstab()
        {
            Debug.Log("Teleports behind target and attacks");
        }

        public void Warp()
        {
            Debug.Log("-Warps to targeted location-");
        }

        public void Phase()
        {
            Debug.Log("-Guaranteed dodge-");
        }
    }
}
