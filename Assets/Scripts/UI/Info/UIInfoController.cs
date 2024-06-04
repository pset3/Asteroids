namespace Asteroid
{
    public static class UIInfoController
    {
        private static UIInfoView View;

        public static void Init()
        {
            View = UI.AddUIElement("InfoText").GetComponent<UIInfoView>();
            View.Init();
        }
    }
}
