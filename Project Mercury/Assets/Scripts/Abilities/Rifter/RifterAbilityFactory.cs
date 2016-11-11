namespace Assets.Scripts.Abilities.Rifter
{
    public class RifterAbilityFactory
    {
        private static RifterAbilities useAbility;
        
        public static void ActivateAbility(RifterAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new RifterAbilities();
            }

            switch(ability)
            {
                case RifterAbilityList.Backstab:
                    useAbility.Backstab();
                    break;
                case RifterAbilityList.Warp:
                    useAbility.Warp();
                    break;
                case RifterAbilityList.Phase:
                    useAbility.Phase();
                    break;
            }
        }
    }
}
