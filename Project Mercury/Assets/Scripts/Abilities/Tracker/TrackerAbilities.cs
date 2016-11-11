using UnityEngine;

namespace Assets.Scripts.Abilities.Tracker
{
    public enum TrackerAbilityList
    {
        EagleEyes,
        HyenasHowl,
        CheetahStance
    }

    public class TrackerAbilities
    {
        public void EagleEyes()
        {
            Debug.Log("Enhanced vision & double damage chance");
        }

        public void HyenasHowl()
        {
            Debug.Log("-Cackle fills the air, instilling fear-");
        }

        public void CheetahStance()
        {
            Debug.Log("Increased Speed");
        }
    }
}
