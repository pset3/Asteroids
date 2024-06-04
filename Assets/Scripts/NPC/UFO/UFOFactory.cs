using UnityEngine;

namespace Asteroid
{
    public static class UFOFactory
    {
        public static UFOController CreateUFO()
        {
            Vector2 position;
            position.x = Random.Range(Game.MinX, Game.MaxX);
            position.y = Random.Range(Game.MinY, Game.MaxY);
            var model = new UFOModel();
            model.Position = position;
            model.Speed = 1.25f;
            model.Rotation = Random.Range(0, 360f);
            model.Score = 200;
            var view = Game.GameObjectLoader.Load("UFO").GetComponent<UFOView>();
            var controller = new UFOController(model, view);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}