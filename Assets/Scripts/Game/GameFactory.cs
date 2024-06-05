using UnityEngine;

namespace Asteroid
{
    public class GameFactory
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void OnBeforeSceneLoad()
        {
            CreateGame();
        }

        public static Game CreateGame()
        { 
            return new Game();
        }
    }
}
