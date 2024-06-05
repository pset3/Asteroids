using UnityEngine;

namespace Asteroid
{
    public static class UFOFactory
    {
        public static UFOController CreateUFO(Game game)
        {
            Vector2 position;
            position.x = Random.Range(GameConstant.MinX, GameConstant.MaxX);
            position.y = Random.Range(GameConstant.MinY, GameConstant.MaxY);
            var model = new UFOModel();
            model.Position = position;
            model.Speed = 1.25f;
            model.Rotation = Random.Range(0, 360f);
            model.Score = 200;
            var view = game.GameObjectLoader.Load("UFO").GetComponent<UFOView>();
            var controller = new UFOController(model, view, game);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}