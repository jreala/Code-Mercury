namespace Assets.Scripts.Abilities.Enhancer
{
    public class EnhancerAbilityFactory
    {
        private static EnhancerAbilities useAbility;
        
        public static void ActivateAbility(EnhancerAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new EnhancerAbilities();
            }

            switch(ability)
            {
                case EnhancerAbilityList.Reflex:
                    useAbility.Reflex();
                    break;
                case EnhancerAbilityList.SteeledBody:
                    useAbility.SteeledBody();
                    break;
                case EnhancerAbilityList.Boost:
                    useAbility.Boost();
                    break;
            }
        }
    }
}
