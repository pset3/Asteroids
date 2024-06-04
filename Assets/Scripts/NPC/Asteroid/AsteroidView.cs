namespace Asteroid
{
    public class AsteroidView : NPCView
    {
        public new AsteroidSmallModel Model { get; private set; }
        public new AsteroidController Controller { get; private set; }

        public void SetModel(AsteroidSmallModel model)
        {
            base.SetModel(model);
            Model = model;
        }

        public void SetController(AsteroidController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }
    }
}