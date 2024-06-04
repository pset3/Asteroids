namespace Asteroid
{
    public static class PlayerFactory
    {
        public static PlayerController CreatePlayer()
        {
            var model = new PlayerModel();
            var view = Game.GameObjectLoader.Load("Player").GetComponent<PlayerView>();
            var controller = new PlayerController(model, view);
            view.SetModel(model);
            view.SetController(controller);
            return controller;
        }
    }
}