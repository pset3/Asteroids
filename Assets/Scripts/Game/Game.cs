using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    public static class Game
    {
        public static GameObjectLoader GameObjectLoader { get; private set; }
        public static UpdateManager UpdateManager { get; private set; }
        public static PlayerController Player { get; private set; }
        public static NPCSpawnController NPCSpawnController { get; private set; }

        public const float Aspect = 16f / 9f;
        public const float MinY = -5f;
        public const float MaxY = 5f;
        public const float MinX = -5f * Aspect;
        public const float MaxX = 5f * Aspect;
        public const float SpawnTimeMin = 5f;
        public const float SpawnTimeMax = 10f;
        public const int MaxNPC = 10;

        private static List<ObjectController> objects = new List<ObjectController>();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void OnBeforeSceneLoad()
        {
            Init();
        }

        public static void Init()
        {
            Debug.Log("Game Init");
            LoadGameObjectLoader();
            UpdateManager = GameObjectLoader.Load("UpdateManager").GetComponent<UpdateManager>();
            Player = PlayerFactory.CreatePlayer();
            NPCSpawnController = new NPCSpawnController();
            UI.Init();
        }

        private static void LoadGameObjectLoader()
        {
            GameObjectLoader = Resources.Load<GameObjectLoader>("GameObjectLoader");
        }

        public static void GameOver()
        {
            UpdateManager.Pause();
            GameOverWindowController.Show();
        }

        public static void RestartGame()
        {
            DisposeObjects();
            GameOverWindowController.Hide();
            UpdateManager.Unpause();
            Player = PlayerFactory.CreatePlayer();
        }

        public static void AddObject(ObjectController obj)
        {
            objects.Add(obj);
        }

        public static void RemoveObject(ObjectController obj)
        {
            objects.Remove(obj);
        }

        public static void DisposeObjects()
        {
            var objs = objects.ToArray();

            for (int i = 0; i < objs.Length; i++)
            {
                objs[i].Dispose();
            }

            objects.Clear();
        }
    }
}
