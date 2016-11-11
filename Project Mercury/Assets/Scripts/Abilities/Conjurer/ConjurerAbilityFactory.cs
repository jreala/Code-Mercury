namespace Assets.Scripts.Abilities.Conjurer
{
    public class ConjurerAbilityFactory
    {
        private static ConjurerAbilities useAbility;
        
        public static void ActivateAbility(ConjurerAbilityList ability)
        {
            if(useAbility == null)
            {
                useAbility = new ConjurerAbilities();
            }

            switch(ability)
            {
                case ConjurerAbilityList.MirrorWall:
                    useAbility.MirrorWall();
                    break;
                case ConjurerAbilityList.Meteor:
                    useAbility.Meteor();
                    break;
                case ConjurerAbilityList.Root:
                    useAbility.Root();
                    break;
            }
        }
    }
}
