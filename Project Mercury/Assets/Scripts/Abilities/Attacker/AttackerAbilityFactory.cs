namespace Assets.Scripts.Abilities.Attacker
{
    public class AttackerAbilityFactory
    {
        public static void ActivateAbility(AttackerAbilityList ability)
        {
            var useAbility = new AttackerAbilities();
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
