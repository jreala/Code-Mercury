namespace Assets.Scripts.Abilities.Conjurer
{
    public class ConjurerAbilityFactory
    {
        public static void ActivateAbility(ConjurerAbilityList ability)
        {
            var useAbility = new ConjurerAbilities();
            switch(ability)
            {
                case ConjurerAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case ConjurerAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case ConjurerAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
