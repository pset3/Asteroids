using UnityEngine;

namespace Asteroid
{
    public static class AsteroidSmallFactory
    {
        const float SpawnRange = 1f;

        public static AsteroidSmallController CreateAsteroidSmall(Vector2 position, Game game)
        {
            position.x += Random.Range(-SpawnRange, SpawnRange);
            position.y += Random.Range(-SpawnRange, SpawnRange);
            var model = new AsteroidSmallModel();
            model.Position = position;
            model.Speed = 1.5f;
            model.Rotation = Random.Range(0, 360f);
            model.Score = 100;
            var view = game.GameObjectLoader.Load("SmallAsteroid").GetComponent<AsteroidSmallView>();
            var controller = new AsteroidSmallController(model, view, game);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}