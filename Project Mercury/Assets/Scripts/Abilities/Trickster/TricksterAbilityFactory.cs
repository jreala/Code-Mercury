namespace Assets.Scripts.Abilities.Trickster
{
    public class TricksterAbilityFactory
    {
        private static TricksterAbilities useAbility;
        
        public static void ActivateAbility(TricksterAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new TricksterAbilities();
            }

            switch(ability)
            {
                case TricksterAbilityList.Dash:
                    useAbility.Dash();
                    break;
                case TricksterAbilityList.Feint:
                    useAbility.Feint();
                    break;
                case TricksterAbilityList.Backstab:
                    useAbility.Backstab();
                    break;
            }
        }
    }
}
