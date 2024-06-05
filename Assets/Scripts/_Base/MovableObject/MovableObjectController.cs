using UnityEngine;

namespace Asteroid
{
    public class MovableObjectController : ObjectController
    {
        public new MovableObjectModel Model { get; private set; }

        protected new MovableObjectView view;
        protected bool defaultMove = true;

        public MovableObjectController(MovableObjectModel model, MovableObjectView view, Game game) : base(model, view, game)
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

            if (position.x > GameConstant.MaxX)
                position.x -= GameConstant.MaxX * 2f;

            if (position.x < GameConstant.MinX)
                position.x += GameConstant.MaxX * 2f;

            if (position.y > GameConstant.MaxY)
                position.y -= GameConstant.MaxY * 2f;

            if (position.y < GameConstant.MinY)
                position.y += GameConstant.MaxY * 2f;

            Model.Position = position;
        }
    }
}