using UnityEngine;

namespace Asteroid
{
    public class LaserController : MovableObjectController, IPlayerDamage
    {
        public new LaserModel Model { get; private set; }

        public DamageType DamageType => DamageType.Laser;

        Timer destroyTimer;

        public LaserController(LaserModel model, LaserView view) : base(model, view)
        {
            Model = model;
            destroyTimer = new Timer(model.LifeTime, Dispose);
        }

        public void Damage()
        { 
        }
    }
}