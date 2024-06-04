namespace Asteroid
{
    public class AsteroidSmallView : NPCView
    {
        public new AsteroidSmallModel Model { get; private set; }
        public new AsteroidSmallController Controller { get; private set; }

        public void SetModel(AsteroidSmallModel model)
        {
            base.SetModel(model);
            Model = model;
        }

        public void SetController(AsteroidSmallController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }
    }
}