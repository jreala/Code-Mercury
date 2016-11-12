using UnityEngine;

namespace Assets.Scripts.Abilities.Invoker
{
    public enum InvokerAbilityList
    {
        None,
        Barrier,
        HyperthermalCombustion,
        ShadeStep
    }

    public class InvokerAbilities
    {
        public void Barrier()
        {
            Debug.Log("Negate incoming damage");
        }

        public void HyperthermalCombustion()
        {
            Debug.Log("-Shoots an exploding burst of energy-");
        }

        public void ShadeStep()
        {
            Debug.Log("Travel between shadows");
        }
    }
}
