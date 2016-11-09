namespace Assets.Scripts.Abilities.Enhancer
{
    public class EnhancerAbilityFactory
    {
        public static void ActivateAbility(EnhancerAbilityList ability)
        {
            var useAbility = new EnhancerAbilities();
            switch(ability)
            {
                case EnhancerAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case EnhancerAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case EnhancerAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
