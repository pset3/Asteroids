using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{

    public class Game
    {
        private GameObjectLoader gameObjectLoader;
        private UpdateManager updateManager;
        private PlayerController player;
        private NPCSpawnController NPCSpawnController;
        private List<ObjectController> objects = new List<ObjectController>();
        private UI ui;
        private UIInfoController uIInfoController;
        private GameOverWindowController gameOverWindowController;

        public PlayerController Player => player;
        public GameObjectLoader GameObjectLoader => gameObjectLoader;
        public UpdateManager UpdateManager => updateManager;

        public Game()
        {
            Debug.Log("Game Init");
            LoadGameObjectLoader();
            updateManager = gameObjectLoader.Load("UpdateManager").GetComponent<UpdateManager>();
            player = PlayerFactory.CreatePlayer(this);
            NPCSpawnController = new NPCSpawnController(this);
            ui = new UI(this);
            uIInfoController = new UIInfoController(ui, this);
            gameOverWindowController = new GameOverWindowController(ui, this);
        }

        private void LoadGameObjectLoader()
        {
            gameObjectLoader = Resources.Load<GameObjectLoader>("GameObjectLoader");
        }

        public void GameOver()
        {
            updateManager.Pause();
            gameOverWindowController.Show();
        }

        public void RestartGame()
        {
            DisposeObjects();
            gameOverWindowController.Hide();
            updateManager.Unpause();
            player = PlayerFactory.CreatePlayer(this);
        }

        public void AddObject(ObjectController obj)
        {
            objects.Add(obj);
        }

        public void RemoveObject(ObjectController obj)
        {
            objects.Remove(obj);
        }

        public void DisposeObjects()
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
