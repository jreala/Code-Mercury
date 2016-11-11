namespace Assets.Scripts.Abilities.Defender
{
    public class DefenderAbilityFactory
    {
        private static DefenderAbilities useAbility;
        
        public static void ActivateAbility(DefenderAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new DefenderAbilities();
            }

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
