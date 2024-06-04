using UnityEngine;

namespace Asteroid
{
    public class LaserView : MovableObjectView
    {
        public new LaserModel Model { get; private set; }
        public new LaserController Controller { get; private set; }

        public void SetModel(LaserModel model)
        {
            base.SetModel(model);
            Model = model;
        }

        public void SetController(LaserController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }

        protected override void Update()
        {
            transform.rotation = Quaternion.Euler(0f, 0f, Model.Rotation);
        }

        public new void Destroy()
        {
            Destroy(gameObject);
        }
    }
}