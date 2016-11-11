namespace Assets.Scripts.Abilities.Speedster
{
    public class SpeedsterAbilityFactory
    {
        private static SpeedsterAbilities useAbility;
        
        public static void ActivateAbility(SpeedsterAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new SpeedsterAbilities();
            }

            switch(ability)
            {
                case SpeedsterAbilityList.Dash:
                    useAbility.Dash();
                    break;
                case SpeedsterAbilityList.Feint:
                    useAbility.Feint();
                    break;
                case SpeedsterAbilityList.Backstab:
                    useAbility.Backstab();
                    break;
            }
        }
    }
}
