namespace Assets.Scripts.Abilities.Speedster
{
    public class SpeedsterAbilityFactory
    {
        public static void ActivateAbility(SpeedsterAbilityList ability)
        {
            var useAbility = new AttackerAbilities();
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
