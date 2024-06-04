using UnityEngine;

namespace Asteroid
{
    public class MovableObjectController : ObjectController
    {
        public new MovableObjectModel Model { get; private set; }

        protected new MovableObjectView view;
        protected bool defaultMove = true;

        public MovableObjectController(MovableObjectModel model, MovableObjectView view) : base(model, view)
        {
            Model = model;
            this.view = view;
        }

        protected override void Update()
        {
            Vector2 position = Model.Position;

            if (defaultMove)
            {
                Model.SpeedX = Model.Speed * Mathf.Cos(Model.Rotation * Mathf.Deg2Rad);
                Model.SpeedY = Model.Speed * Mathf.Sin(Model.Rotation * Mathf.Deg2Rad);
            }

            position.x += Model.SpeedX * Time.deltaTime;
            position.y += Model.SpeedY * Time.deltaTime;

            if (position.x > Game.MaxX)
                position.x -= Game.MaxX * 2f;

            if (position.x < Game.MinX)
                position.x += Game.MaxX * 2f;

            if (position.y > Game.MaxY)
                position.y -= Game.MaxY * 2f;

            if (position.y < Game.MinY)
                position.y += Game.MaxY * 2f;

            Model.Position = position;
        }
    }
}