namespace Assets.Scripts.Abilities.Ravager
{
    public class RavagerAbilityFactory
    {
        public static void ActivateAbility(RavagerAbilityList ability)
        {
            var useAbility = new RavagerAbilities();
            switch(ability)
            {
                case RavagerAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case RavagerAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case RavagerAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
