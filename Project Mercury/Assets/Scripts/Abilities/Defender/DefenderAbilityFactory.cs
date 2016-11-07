namespace Assets.Scripts.Abilities.Defender
{
    public class DefenderAbilityFactory
    {
        public static void ActivateAbility(DefenderAbilityList ability)
        {
            var useAbility = new DefenderAbilities();
            switch(ability)
            {
                case DefenderAbilityList.IronStance:
                    useAbility.IronStance();
                    break;
                case DefenderAbilityList.BulkUp:
                    useAbility.BulkUp();
                    break;
                case DefenderAbilityList.Retaliate:
                    useAbility.Retaliate();
                    break;
            }
        }
    }
}
