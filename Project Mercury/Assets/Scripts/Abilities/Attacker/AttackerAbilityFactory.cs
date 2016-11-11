namespace Assets.Scripts.Abilities.Attacker
{
    public class AttackerAbilityFactory
    {
        private static AttackerAbilities useAbility;
        
        public static void ActivateAbility(AttackerAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new AttackerAbilities();
            }

            switch(ability)
            {
                case AttackerAbilityList.Pierce:
                    useAbility.Pierce();
                    break;
                case AttackerAbilityList.Berserk:
                    useAbility.Berserk();
                    break;
                case AttackerAbilityList.Bloodthirst:
                    useAbility.Bloodthirst();
                    break;
            }
        }
    }
}
