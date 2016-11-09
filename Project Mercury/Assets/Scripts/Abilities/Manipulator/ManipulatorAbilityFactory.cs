namespace Assets.Scripts.Abilities.Invoker
{
    public class InvokerAbilityFactory
    {
        public static void ActivateAbility(InvokerAbilityList ability)
        {
            var useAbility = new InvokerAbilities();
            switch(ability)
            {
                case InvokerAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case InvokerAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case InvokerAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
