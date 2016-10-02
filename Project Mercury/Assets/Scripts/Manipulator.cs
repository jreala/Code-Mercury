using UnityEngine;

namespace Assets.Scripts
{
    public class Manipulator : ISubclass
    {
        void ISubclass.AbilityOne()
        {
            Debug.Log("MANIPULATOR Ability One Pressed");
        }

        void ISubclass.AbilityTwo()
        {
            Debug.Log("MANIPULATOR Ability Two Pressed");
        }

        void ISubclass.AbilityThree()
        {
            Debug.Log("MANIPULATOR Ability Three Pressed");
        }
    }
}