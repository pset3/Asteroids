using UnityEngine;

namespace Asteroid
{
    public class UFOController : NPCController
    {
        private Game game;

        public new UFOModel Model { get; private set; }

        public UFOController(UFOModel model, UFOView view, Game game) : base(model, view, game)
        {
            Model = model;
            this.game = game;
        }

        protected override void Update()
        {
            base.Update();
            Vector2 playerPosition = game.Player.Model.Position;
            Vector2 ufoPosition = Model.Position;
            Vector2 delta = (playerPosition - ufoPosition).normalized;
            Model.Rotation = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
        }
    }
}