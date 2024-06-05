using UnityEngine;

namespace Asteroid
{
    public class ShellController : MovableObjectController, IPlayerDamage
    {
        public new ShellModel Model { get; private set; }

        public DamageType DamageType => DamageType.Shell;

        Timer destroyTimer;

        public ShellController(ShellModel model, ShellView view, Game game) : base(model, view, game)
        {
            Model = model;
            destroyTimer = new Timer(model.LifeTime, game, Dispose);
        }

        public void Damage()
        {
            Dispose();
        }
    }
}