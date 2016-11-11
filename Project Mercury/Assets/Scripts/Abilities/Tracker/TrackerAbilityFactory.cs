namespace Assets.Scripts.Abilities.Tracker
{
    public class TrackerAbilityFactory 
    {
        private static TrackerAbilities useAbility;
        
        public static void ActivateAbility(TrackerAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new TrackerAbilities();
            }

            switch(ability)
            {
                case TrackerAbilityList.CheetahStance:
                    useAbility.CheetahStance();
                    break;
                case TrackerAbilityList.EagleEyes:
                    useAbility.EagleEyes();
                    break;
                case TrackerAbilityList.HyenasHowl:
                    useAbility.HyenasHowl();
                    break;
            }
        }
    }
}
