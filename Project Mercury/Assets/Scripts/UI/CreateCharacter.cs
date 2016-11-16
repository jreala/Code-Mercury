using Assets.Scripts.Classes;
using Assets.Scripts.Player;
using Assets.Scripts.Helpers;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class CreateCharacter : MonoBehaviour
    {
        private ClassFactory _classFactory;

        void Awake()
        {
            _classFactory = new ClassFactory();
        }

        public void SetPrimaryClass(string primary)
        {
            var className = EnumUtil.ParseEnum<ClassName>(primary);
            BasePlayer.GetInstance().SetBaseClass(_classFactory.CreateClass(className));
            Debug.Log(BasePlayer.GetInstance().BaseClass.ToString());
        }
    }
}
