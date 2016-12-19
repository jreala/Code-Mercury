using UnityEngine;
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
        }
    }
}