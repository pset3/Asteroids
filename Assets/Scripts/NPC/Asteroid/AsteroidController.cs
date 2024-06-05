using UnityEngine;

namespace Asteroid
{
    public class AsteroidController : NPCController
    {
        public new AsteroidSmallModel Model { get; private set; }

        const int SpawnSmallAsteroidsCount = 2;
        private readonly Game game;

        public AsteroidController(AsteroidSmallModel model, AsteroidView view, Game game) : base(model, view, game)
        {
            Model = model;
            this.game = game;
        }

        public override void Damage(IPlayerDamage playerDamage)
        {
            base.Damage(playerDamage);

            if (playerDamage.DamageType == DamageType.Shell)
            {
                for (int i = 0; i < SpawnSmallAsteroidsCount; i++)
                {
                    AsteroidSmallFactory.CreateAsteroidSmall(Model.Position, game);
                }
            }
        }
    }
}