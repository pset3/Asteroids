using UnityEngine;

namespace Asteroid
{
    public static class ShellFactory
    {
        public static ShellController CreateShell(Vector2 position, float rotation)
        {
            var model = new ShellModel();
            model.Position = position;
            model.Speed = 10f;
            model.Rotation = rotation;
            model.LifeTime = 1f;
            var view = Game.GameObjectLoader.Load("Shell").GetComponent<ShellView>();
            var controller = new ShellController(model, view);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}