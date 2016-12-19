namespace Assets.Scripts.Abilities.Manipulator
{
    public class ManipulatorAbilityFactory
    {
        private static ManipulatorAbilities useAbility;
        
        /// <summary>
        /// Activate Manipulator ability
        /// </summary>
        /// <param name="ability"></param>
        public static void ActivateAbility(ManipulatorAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new ManipulatorAbilities();
            }

            switch (ability)
            {
                case ManipulatorAbilityList.Animate:
                    useAbility.Animate();
                    break;
                case ManipulatorAbilityList.Release:
                    useAbility.Release();
                    break;
                case ManipulatorAbilityList.Command:
                    useAbility.Command();
                    break;
            }
        }
    }
}
