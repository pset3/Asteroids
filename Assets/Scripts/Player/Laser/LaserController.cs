using UnityEngine;

namespace Asteroid
{
    public class LaserController : MovableObjectController, IPlayerDamage
    {
        public new LaserModel Model { get; private set; }

        public DamageType DamageType => DamageType.Laser;

        Timer destroyTimer;

        public LaserController(LaserModel model, LaserView view, Game game) : base(model, view, game)
        {
            Model = model;
            destroyTimer = new Timer(model.LifeTime, game, Dispose);
        }

        public void Damage()
        { 
        }
    }
}