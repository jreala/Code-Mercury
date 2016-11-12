using UnityEngine;

namespace Assets.Scripts.Abilities.Speedster
{
    public enum SpeedsterAbilityList
    {
        None,
        Dash,
        Feint,
        Backstab
    }

    public class SpeedsterAbilities
    {
        public void Dash()
        {
            Debug.Log("-Lunges in a certain direction-");
        }

        public void Feint()
        {
            Debug.Log("-Side steps and stabs-");
        }

        public void Backstab()
        {
            Debug.Log("-Jumps behind the enemy and stabs-");
        }
    }
}
