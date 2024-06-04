using UnityEngine;

namespace Asteroid
{
    public class UFOView : NPCView
    {
        public new UFOModel Model { get; private set; }
        public new UFOController Controller { get; private set; }

        public void SetModel(UFOModel model)
        {
            base.SetModel(model);
            Model = model;
        }

        public void SetController(UFOController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }
    }
}