using UnityEngine;

namespace Asteroid
{
    public class NPCView : MovableObjectView
    {
        public new NPCModel Model { get; private set; }
        public new NPCController Controller { get; private set; }

        public void SetModel(NPCModel model)
        {
            base.SetModel(model);
            Model = model;
        }

        public void SetController(NPCController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            ShellView shell = collision.gameObject.GetComponent<ShellView>();

            if (shell != null)
            {
                Controller.Damage(shell.Controller);
                return;
            }

            LaserView laser = collision.gameObject.GetComponent<LaserView>();

            if (laser != null)
            {
                Controller.Damage(laser.Controller);
                return;
            }
        }
    }
}