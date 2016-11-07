namespace Assets.Scripts.Abilities.Brawler
{
    public class BrawlerAbilityFactory
    {
        public static void ActivateAbility(BrawlerAbilityList ability)
        {
            var useAbility = new BrawlerAbilities();
            switch(ability)
            {
                case BrawlerAbilityList.BattleCry:
                    useAbility.BattleCry();
                    break;
                case BrawlerAbilityList.HeavySlash:
                    useAbility.HeavySlash();
                    break;
                case BrawlerAbilityList.Taunt:
                    useAbility.Taunt();
                    break;
            }
        }
    }
}
