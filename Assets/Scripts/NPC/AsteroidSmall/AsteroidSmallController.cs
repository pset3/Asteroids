using UnityEngine;

namespace Asteroid
{
    public class AsteroidSmallController : NPCController
    {
        public new AsteroidSmallModel Model { get; private set; }

        public AsteroidSmallController(AsteroidSmallModel model, AsteroidSmallView view, Game game ) : base(model, view, game)
        {
            Model = model;
        }
    }
}