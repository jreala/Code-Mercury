namespace Assets.Scripts.Abilities.Rifter
{
    public class RifterAbilityFactory
    {
        public static void RifterAbility(RifterAbilityList ability)
        {
            var useAbility = new RifterAbilities();
            switch(ability)
            {
                case RifterAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case RifterAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case RifterAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
