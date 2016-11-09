﻿using UnityEngine;

namespace Assets.Scripts.Abilities.Rifter
{
    public enum RifterAbilityList
    {
        BattleCry,
        HeavySlash,
        Taunt
    }

    public class RifterAbilities
    {
        public void BattleCry()
        {
            Debug.Log("RAWWWRRRRRR!!!");
        }

        public void HeavySlash()
        {
            Debug.Log("-Slings sword through the air-");
        }

        public void Taunt()
        {
            Debug.Log("HAHAHAHAHA YOU CALL THAT A PUNCH");
        }
    }
}
