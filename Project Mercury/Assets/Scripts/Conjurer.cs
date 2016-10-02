using UnityEngine;

namespace Assets.Scripts
{
    public class Conjurer : ISubclass
    {
        void ISubclass.AbilityOne()
        {
            Debug.Log("CONJURER Ability One Pressed");
        }

        void ISubclass.AbilityTwo()
        {
            Debug.Log("CONJURER Ability Two Pressed");
        }

        void ISubclass.AbilityThree()
        {
            Debug.Log("CONJURER Ability Three Pressed");
        }
    }
}