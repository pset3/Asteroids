namespace Asteroid
{
    public static class GameOverWindowController
    {
        private static GameOverWindowView View;

        public static void Init()
        {
            View = UI.AddUIElement("GameOverWindow").GetComponent<GameOverWindowView>();
            View.Init();
            View.Hide();
        }

        public static void Show()
        {
            View.Show();
        }

        public static void Hide()
        {
            View.Hide();
        }
    }
}
