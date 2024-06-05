using UnityEngine;

namespace Asteroid
{
    public static class AsteroidFactory
    {
        public static AsteroidController CreateAsteroid(Game game)
        {
            Vector2 position;
            position.x = Random.Range(GameConstant.MinX, GameConstant.MaxX);
            position.y = Random.Range(GameConstant.MinY, GameConstant.MaxY);
            var model = new AsteroidSmallModel();
            model.Position = position;
            model.Speed = 1f;
            model.Rotation = Random.Range(0, 360f);
            model.Score = 100;
            var view = game.GameObjectLoader.Load("Asteroid").GetComponent<AsteroidView>();
            var controller = new AsteroidController(model, view, game);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}