using UnityEngine;
using Assets.Scripts.Classes.BaseClasses;
using Assets.Scripts.Classes.SubClasses;
using Assets.Scripts.Classes;

namespace Assets.Scripts.Player
{
    public class PlayableCharacter : MonoBehaviour
    {
        public IBasePlayer _player;
        private Attributes _attributes;
        private ClassName _primaryClass;
        private ClassName _secondaryClass;
        private ClassName _tertiaryClass;

        void Awake()
        {
            _player = BasePlayer.GetInstance();
            _player.SetBaseClass(new Brawler());
            _player.SetSecondaryClass(new Manipulator());
            _player.SetTertiaryClass(new Conjurer());
            CalculateAttributePoints();
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

        private void CalculateAttributePoints()
        {
            _attributes = _player.SecondaryClass != null
                ? _player.TertiaryClass != null
                ? _player.BaseClass.GetAttributes() + _player.SecondaryClass.GetAttributes() + _player.TertiaryClass.GetAttributes()
                : _player.BaseClass.GetAttributes() + _player.SecondaryClass.GetAttributes()
                : _player.BaseClass.GetAttributes();
        }
    }
}