using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    public interface IPlayerDamage
    {
        public DamageType DamageType { get; }

        public void Damage();
    }

    public enum DamageType 
    {
        Shell, 
        Laser 
    };
}
