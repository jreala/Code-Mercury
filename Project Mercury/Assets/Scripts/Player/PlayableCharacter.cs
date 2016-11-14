using UnityEngine;
using Assets.Scripts.Classes.BaseClasses;
using Assets.Scripts.Classes.SubClasses;
using Assets.Scripts.Classes;

namespace Assets.Scripts.Player
{
    public class PlayableCharacter : MonoBehaviour
    {
        public IBasePlayer player;
        private ClassName _primaryClass;
        private ClassName _secondaryClass;
        private ClassName _tertiaryClass;

        void Awake()
        {
            player = BasePlayer.GetInstance();
            player.SetBaseClass(new Brawler());
            player.SetSecondaryClass(new Manipulator());
            player.SetTertiaryClass(new Conjurer());
        }
        
        void Update()
        {
            ActivateAbility();
        }

        private void ActivateAbility()
        {
            if (Input.GetButtonDown("AbilityOne") && !(Input.GetButton("L2") || Input.GetButton("R2")))
            {   
                player.BaseAbilityOne();
            }

            if (Input.GetButtonDown("AbilityTwo") && !(Input.GetButton("L2") || Input.GetButton("R2")))
            {
                player.BaseAbilityTwo();
            }

            if (Input.GetButtonDown("AbilityThree") && !(Input.GetButton("L2") || Input.GetButton("R2")))
            {
                player.BaseAbilityThree();
            }

            if (Input.GetButton("L2") && Input.GetButtonDown("AbilityOne") && !Input.GetButton("R2"))
            {
                player.SecondaryAbilityOne();
            }

            if (Input.GetButton("L2") && Input.GetButtonDown("AbilityTwo") && !Input.GetButton("R2"))
            {
                player.SecondaryAbilityTwo();
            }

            if (Input.GetButton("L2") && Input.GetButtonDown("AbilityThree") && !Input.GetButton("R2"))
            {
                player.SecondaryAbilityThree();
            }

            if (Input.GetButton("R2") && Input.GetButtonDown("AbilityOne"))
            {
                player.TertiaryAbilityOne();
            }

            if (Input.GetButton("R2") && Input.GetButtonDown("AbilityTwo"))
            {
                player.TertiaryAbilityTwo();
            }

            if (Input.GetButton("R2") && Input.GetButtonDown("AbilityThree"))
            {
                player.TertiaryAbilityThree();
            }
        }
    }
}