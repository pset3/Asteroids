using UnityEngine;

namespace Asteroid
{
    public class AsteroidController : NPCController
    {
        public new AsteroidSmallModel Model { get; private set; }

        const int SpawnSmallAsteroidsCount = 2;

        public AsteroidController(AsteroidSmallModel model, AsteroidView view) : base(model, view)
        {
            Model = model;
        }

        public override void Damage(IPlayerDamage playerDamage)
        {
            base.Damage(playerDamage);

            if (playerDamage.DamageType == DamageType.Shell)
            {
                for (int i = 0; i < SpawnSmallAsteroidsCount; i++)
                {
                    AsteroidSmallFactory.CreateAsteroidSmall(Model.Position);
                }
            }
        }
    }
}