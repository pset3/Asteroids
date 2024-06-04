using UnityEngine;

namespace Asteroid
{
    public static class AsteroidFactory
    {
        public static AsteroidController CreateAsteroid()
        {
            Vector2 position;
            position.x = Random.Range(Game.MinX, Game.MaxX);
            position.y = Random.Range(Game.MinY, Game.MaxY);
            var model = new AsteroidSmallModel();
            model.Position = position;
            model.Speed = 1f;
            model.Rotation = Random.Range(0, 360f);
            model.Score = 100;
            var view = Game.GameObjectLoader.Load("Asteroid").GetComponent<AsteroidView>();
            var controller = new AsteroidController(model, view);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}