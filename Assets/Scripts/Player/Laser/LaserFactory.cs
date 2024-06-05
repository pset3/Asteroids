using UnityEngine;

namespace Asteroid
{
    public static class LaserFactory
    {
        public static LaserController CreateLaser(Vector2 position, float rotation, Game game)
        {
            var model = new LaserModel();
            model.Position = position;
            model.Speed = 0f;
            model.Rotation = rotation;
            model.LifeTime = 0.25f;
            var view = game.GameObjectLoader.Load("Laser").GetComponent<LaserView>();
            var controller = new LaserController(model, view, game);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}