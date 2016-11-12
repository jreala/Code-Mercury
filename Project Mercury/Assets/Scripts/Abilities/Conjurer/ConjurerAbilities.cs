using UnityEngine;

namespace Assets.Scripts.Abilities.Conjurer
{
    public enum ConjurerAbilityList
    {
        None,
        MirrorWall,
        Meteor,
        Root
    }

    public class ConjurerAbilities
    {
        public void MirrorWall()
        {
            Debug.Log("Creates a wall infront of self, deflecting everything back");
        }

        public void Meteor()
        {
            Debug.Log("-Calls to the heavens to launch a meteor down on target-");
        }

        public void Root()
        {
            Debug.Log("Binds everything in target area");
        }
    }
}
