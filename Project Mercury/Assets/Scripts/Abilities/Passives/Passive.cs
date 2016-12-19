using UnityEngine;
using Assets.Scripts.Player;

namespace Assets.Scripts.Abilities.Passives
{
    public class Passive : MonoBehaviour
    {
        private static Attributes _attributes;

        void Start()
        {
            _attributes = GetComponent<Attributes>();
            ApplyPassive(PassiveList.AttackUp);
        }

        public void ApplyPassive(PassiveList passive)
        {
            switch (passive)
            {
                case PassiveList.AutoRegen:
                    Debug.Log("Applied Passive : " + passive);
                    break;
                case PassiveList.AttackUp:
                    Debug.Log("Applied Passive : " + passive);
                    _attributes.Attack += 10;
                    Debug.Log("New Stats: " + _attributes.ToString());
                    break;
                case PassiveList.DefenseUp:
                    Debug.Log("Applied Passive : " + passive);
                    _attributes.Defense += 10;
                    Debug.Log("New Stats: " + _attributes.ToString());
                    break;
                case PassiveList.SpeedUp:
                    Debug.Log("Applied Passive : " + passive);
                    _attributes.Speed += 10;
                    Debug.Log("New Stats: " + _attributes.ToString());
                    break;
                case PassiveList.MovementUp:
                    Debug.Log("Applied Passive : " + passive);
                    break;
                case PassiveList.CriticalHit:
                    Debug.Log("Applied Passive : " + passive);
                    break;
                default:
                    Debug.Log("No Passive Applied.");
                    return;
            }
        }
    }
}