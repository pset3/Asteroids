using UnityEngine;

namespace Asteroid
{
    public static class UI
    {
        private static Transform canvasTransform;

        public static void Init()
        {
            LoadCanvas();
            UIInfoController.Init();
            GameOverWindowController.Init();
        }

        private static void LoadCanvas()
        {
            canvasTransform = Game.GameObjectLoader.Load("Canvas").transform;
        }

        public static GameObject AddUIElement(string uiElementName)
        {
            GameObject go = Game.GameObjectLoader.Load(uiElementName);
            go.transform.SetParent(canvasTransform, false);
            return go;
        }
    }
}
