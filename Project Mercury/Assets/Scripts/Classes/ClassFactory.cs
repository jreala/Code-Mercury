using Assets.Scripts.Classes.BaseClasses;
using Assets.Scripts.Classes.SubClasses;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    public class ClassFactory
    {
        public IBaseClass CreateClass(ClassName name)
        {
            Debug.Log("Creating base class... " + name);
            switch(name)
            {
                case ClassName.Attacker: return new Attacker();
                case ClassName.Brawler: return new Brawler();
                case ClassName.Defender: return new Defender();
                case ClassName.Speedster: return new Speedster();
                default:
                    Debug.Log("Hit default");
                    return null;
            }
        }

        public ISubclass CreateSubClass(ClassName name)
        {
            switch(name)
            {
                case ClassName.Conjurer: return new Conjurer();
                case ClassName.Enhancer: return new Enhancer();
                case ClassName.Invoker: return new Invoker();
                case ClassName.Manipulator: return new Manipulator();
                case ClassName.Ravager: return new Ravager();
                case ClassName.Rifter: return new Rifter();
                case ClassName.Tracker: return new Tracker();
                default: return null;
            }
        }
    }
}
