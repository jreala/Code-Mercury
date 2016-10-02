using UnityEngine;

namespace Assets.Scripts
{
    public class Brawler : IBaseClass
    {
        public void AbilityOne()
        {
            Debug.Log("BRAWLER Ability One Pressed");
        }

        public void AbilityTwo()
        {
            Debug.Log("BRAWLER Ability Two Pressed");
        }

        public void AbilityThree()
        {
            Debug.Log("BRAWLER Ability Three Pressed");
        }
    }
}
