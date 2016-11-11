namespace Assets.Scripts.Abilities.Brawler
{
    public class BrawlerAbilityFactory
    {
        private static BrawlerAbilities useAbility;
        
        public static void ActivateAbility(BrawlerAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new BrawlerAbilities();
            }

            switch (ability)
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
