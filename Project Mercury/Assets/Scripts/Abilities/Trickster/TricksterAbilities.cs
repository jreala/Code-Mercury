using UnityEngine;

namespace Assets.Scripts.Abilities.Trickster
{
    public enum TricksterAbilityList
    {
        None,
        Dash,
        Feint,
        Backstab
    }

    public class TricksterAbilities
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
