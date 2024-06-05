using UnityEngine;

namespace Asteroid
{
    public class UI
    {
        private Transform canvasTransform;
        private Game game;

        public UI(Game game)
        {
            this.game = game;
            LoadCanvas();
        }

        private void LoadCanvas()
        {
            canvasTransform = game.GameObjectLoader.Load("Canvas").transform;
        }

        public GameObject AddUIElement(string uiElementName)
        {
            GameObject go = game.GameObjectLoader.Load(uiElementName);
            go.transform.SetParent(canvasTransform, false);
            return go;
        }
    }
}
