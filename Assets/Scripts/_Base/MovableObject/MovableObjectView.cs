namespace Asteroid
{
    public class MovableObjectView : ObjectView
    {
        public new MovableObjectModel Model { get; private set; }
        public new MovableObjectController Controller { get; private set; }

        public void SetModel(MovableObjectModel model)
        {
            base.SetModel(model);
            Model = model;
            UpdatePosition();
        }

        public void SetController(MovableObjectController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }

        protected override void Update()
        {
            base.Update();
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            transform.position = Model.Position;
        }
    }
}