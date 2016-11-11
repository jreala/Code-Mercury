namespace Assets.Scripts.Abilities.Invoker
{
    public class InvokerAbilityFactory
    {
        private static InvokerAbilities useAbility;
        
        public static void ActivateAbility(InvokerAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new InvokerAbilities();
            }

            switch (ability)
            {
                case InvokerAbilityList.Barrier:
                    useAbility.Barrier();
                    break;
                case InvokerAbilityList.HyperthermalCombustion:
                    useAbility.HyperthermalCombustion();
                    break;
                case InvokerAbilityList.ShadeStep:
                    useAbility.ShadeStep();
                    break;
            }
        }
    }
}
