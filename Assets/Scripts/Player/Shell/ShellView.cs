using UnityEngine;

namespace Asteroid
{
    public class ShellView : MovableObjectView
    {
        public new ShellModel Model { get; private set; }
        public new ShellController Controller { get; private set; }

        public void SetModel(ShellModel model)
        {
            base.SetModel(model);
            Model = model;
        }

        public void SetController(ShellController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }

        public new void Destroy()
        {
            Destroy(gameObject);
        }
    }
}