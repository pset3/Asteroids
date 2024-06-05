namespace Asteroid
{
    public class GameOverWindowController
    {
        private GameOverWindowView View;

        public GameOverWindowController(UI ui, Game game)
        {
            View = ui.AddUIElement("GameOverWindow").GetComponent<GameOverWindowView>();
            View.Init(game);
            View.Hide();
        }

        public void Show()
        {
            View.Show();
        }

        public void Hide()
        {
            View.Hide();
        }
    }
}
