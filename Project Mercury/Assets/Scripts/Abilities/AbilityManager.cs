using UnityEngine;
using Assets.Scripts.Player;

namespace Assets.Scripts.Abilities
{
    public class AbilityManager : MonoBehaviour
    {
        private IBasePlayer _player;

        void Start()
        {
            _player = GetComponent<PlayableCharacter>().player;
        }

        void Update()
        {
            ActivateAbility();
        }

        private void ActivateAbility()
        {
            if (Input.GetButtonDown("AbilityOne") && !(Input.GetButton("L2") || Input.GetButton("R2")))
            {
                _player.BaseAbilityOne();
            }

            if (Input.GetButtonDown("AbilityTwo") && !(Input.GetButton("L2") || Input.GetButton("R2")))
            {
                _player.BaseAbilityTwo();
            }

            if (Input.GetButtonDown("AbilityThree") && !(Input.GetButton("L2") || Input.GetButton("R2")))
            {
                _player.BaseAbilityThree();
            }

            if (Input.GetButton("L2") && Input.GetButtonDown("AbilityOne") && !Input.GetButton("R2"))
            {
                _player.SecondaryAbilityOne();
            }

            if (Input.GetButton("L2") && Input.GetButtonDown("AbilityTwo") && !Input.GetButton("R2"))
            {
                _player.SecondaryAbilityTwo();
            }

            if (Input.GetButton("L2") && Input.GetButtonDown("AbilityThree") && !Input.GetButton("R2"))
            {
                _player.SecondaryAbilityThree();
            }

            if (Input.GetButton("R2") && Input.GetButtonDown("AbilityOne"))
            {
                _player.TertiaryAbilityOne();
            }

            if (Input.GetButton("R2") && Input.GetButtonDown("AbilityTwo"))
            {
                _player.TertiaryAbilityTwo();
            }

            if (Input.GetButton("R2") && Input.GetButtonDown("AbilityThree"))
            {
                _player.TertiaryAbilityThree();
            }
        }
    }
}