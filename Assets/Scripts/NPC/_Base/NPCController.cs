using System;

namespace Asteroid
{
    public class NPCController : MovableObjectController
    {
        public new NPCModel Model { get; private set; }
        Game game;

        public NPCController(NPCModel model, NPCView view, Game game) : base(model, view, game)
        {
            Model = model;
            this.game = game;
        }

        public virtual void Damage(IPlayerDamage playerDamage)
        {
            game.Player.TakeScore(Model.Score);
            playerDamage.Damage();
            Dispose();
        }
    }
}