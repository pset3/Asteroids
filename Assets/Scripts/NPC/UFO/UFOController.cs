using UnityEngine;

namespace Asteroid
{
    public class UFOController : NPCController
    {
        public new UFOModel Model { get; private set; }

        public UFOController(UFOModel model, UFOView view) : base(model, view)
        {
            Model = model;
        }

        protected override void Update()
        {
            base.Update();
            Vector2 playerPosition = Game.Player.Model.Position;
            Vector2 ufoPosition = Model.Position;
            Vector2 delta = (playerPosition - ufoPosition).normalized;
            Model.Rotation = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
        }
    }
}