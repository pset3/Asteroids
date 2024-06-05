namespace Asteroid
{
    public class UIInfoController
    {
        private UIInfoView View;

        public UIInfoController(UI ui, Game game)
        {
            View = ui.AddUIElement("InfoText").GetComponent<UIInfoView>();
            View.Init(game);
        }
    }
}
