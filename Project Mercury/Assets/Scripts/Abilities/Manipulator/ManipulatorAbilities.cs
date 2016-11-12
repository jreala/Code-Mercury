using UnityEngine;

namespace Assets.Scripts.Abilities.Manipulator
{
    public enum ManipulatorAbilityList
    {
        None,
        Animate,
        Release,
        Command
    }

    public class ManipulatorAbilities
    {
        public void Animate()
        {
            Debug.Log("Brings object to life");
        }

        public void Release()
        {
            Debug.Log("Reverts object back to natural form");
        }

        public void Command()
        {
            Debug.Log("Orders object");
        }
    }
}
