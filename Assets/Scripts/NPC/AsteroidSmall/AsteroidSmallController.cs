using UnityEngine;

namespace Asteroid
{
    public class AsteroidSmallController : NPCController
    {
        public new AsteroidSmallModel Model { get; private set; }

        public AsteroidSmallController(AsteroidSmallModel model, AsteroidSmallView view) : base(model, view)
        {
            Model = model;
        }
    }
}