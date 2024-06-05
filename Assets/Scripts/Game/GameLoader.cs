using UnityEngine;

namespace Asteroid
{
    public class GameLoader
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void OnBeforeSceneLoad()
        {
            new Game();
        }
    }
}
