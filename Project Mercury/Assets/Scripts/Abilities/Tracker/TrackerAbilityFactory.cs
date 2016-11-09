namespace Assets.Scripts.Abilities.Tracker
{
    public class TrackerAbilityFactory
    {
        public static void TrackerAbility(TrackerAbilityList ability)
        {
            var useAbility = new TrackerAbilities();
            switch(ability)
            {
                case TrackerAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case TrackerAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case TrackerAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
