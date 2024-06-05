namespace Asteroid
{
    public static class PlayerFactory
    {
        public static PlayerController CreatePlayer(Game game)
        {
            var model = new PlayerModel();
            var view = game.GameObjectLoader.Load("Player").GetComponent<PlayerView>();
            var controller = new PlayerController(model, view, game);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}