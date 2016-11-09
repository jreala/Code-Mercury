namespace Assets.Scripts.Abilities.Manipulator
{
    public class ManipulatorAbilityFactory
    {
        public static void ActivateAbility(ManipulatorAbilityList ability)
        {
            var useAbility = new ManipulatorAbilities();
            switch(ability)
            {
                case ManipulatorAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case ManipulatorAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case ManipulatorAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
