using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    public class NPCSpawnController : IUpdatable
    {
        private bool isDisposed;
        float spawnTime;

        public NPCSpawnController()
        {
            Game.UpdateManager.Register(this);
            ScheduleSpawn();
        }

        void IUpdatable.Update()
        {
            if (spawnTime > 0f)
            {
                spawnTime -= Time.deltaTime;

                if (spawnTime <= 0f)
                {
                    spawnTime = 0f;
                    Spawn();
                }
            }
        }

        void ScheduleSpawn()
        {
            spawnTime = UnityEngine.Random.Range(Game.SpawnTimeMin, Game.SpawnTimeMax);
        }

        void Spawn()
        {
            if (UnityEngine.Random.value <= 0.5f)
                AsteroidFactory.CreateAsteroid();
            else
                UFOFactory.CreateUFO();

            ScheduleSpawn();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Game.UpdateManager.Unregister(this);
                }

                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}