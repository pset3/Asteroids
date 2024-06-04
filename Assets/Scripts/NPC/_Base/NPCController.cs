using System;

namespace Asteroid
{
    public class NPCController : MovableObjectController
    {
        public new NPCModel Model { get; private set; }

        public NPCController(NPCModel model, NPCView view) : base(model, view)
        {
            Model = model;
        }

        public virtual void Damage(IPlayerDamage playerDamage)
        {
            Game.Player.TakeScore(Model.Score);
            playerDamage.Damage();
            Dispose();
        }
    }

}