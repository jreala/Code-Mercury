using UnityEngine;

namespace Assets.Scripts.Abilities.Enhancer
{
    public enum EnhancerAbilityList
    {
        Reflex,
        SteeledBody,
        Boost
    }

    public class EnhancerAbilities
    {
        public void Reflex()
        {
            Debug.Log("-Chance to counter attack-");
        }

        public void SteeledBody()
        {
            Debug.Log("-Temporarily immune to physical damage-");
        }

        public void Boost()
        {
            Debug.Log("-Power increased-");
        }
    }
}
