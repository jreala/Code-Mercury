namespace Assets.Scripts.Abilities.Ravager
{
    public class RavagerAbilityFactory
    {
        private static RavagerAbilities useAbility;
        
        public static void ActivateAbility(RavagerAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new RavagerAbilities();
            }

            switch(ability)
            {
                case RavagerAbilityList.DestructiveForce:
                    useAbility.DestructiveForce();
                    break;
                case RavagerAbilityList.Bloodweapon:
                    useAbility.Bloodweapon();
                    break;
                case RavagerAbilityList.Overdrive:
                    useAbility.Overdrive();
                    break;
            }
        }
    }
}
